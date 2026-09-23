using System.IO.Ports;

namespace StreamDeckDIY;

/// <summary>
/// Lee el protocolo del Arduino ("S512|...|..." y "B3") y envía comandos de LEDs.
/// Detecta el puerto automáticamente y reconecta si se desenchufa.
/// Los eventos se disparan en un hilo secundario.
/// </summary>
public sealed class SerialService : IDisposable
{
    public const int SliderCount = 5;

    public event Action<int[]>? SlidersReceived;
    public event Action<int>? ButtonPressed;
    public event Action<string>? Status;
    public event Action<bool>? Connected;

    SerialPort? _port;
    CancellationTokenSource? _cts;
    readonly object _lock = new();

    public bool IsRunning => _cts != null;

    /// <param name="portName">"" para detectar automáticamente</param>
    public void Start(string portName)
    {
        Stop();
        var cts = new CancellationTokenSource();
        _cts = cts;
        Task.Run(() => Loop(portName, cts.Token));
    }

    public void Stop()
    {
        var wasRunning = _cts != null;
        _cts?.Cancel();
        _cts = null;
        lock (_lock)
        {
            try { _port?.Close(); } catch { }
            _port = null;
        }
        if (wasRunning)
        {
            Connected?.Invoke(false);
            Status?.Invoke("Desconectado");
        }
    }

    public void Send(params byte[] data)
    {
        lock (_lock)
        {
            try { if (_port?.IsOpen == true) _port.Write(data, 0, data.Length); }
            catch { }
        }
    }

    void Loop(string portName, CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            SerialPort? port = null;
            try
            {
                Status?.Invoke("Buscando dispositivo...");
                port = string.IsNullOrEmpty(portName) ? AutoDetect(ct) : Open(portName);
                if (port == null) { ct.WaitHandle.WaitOne(2000); continue; }

                lock (_lock)
                {
                    if (ct.IsCancellationRequested) { port.Dispose(); return; }
                    _port = port;
                }
                Connected?.Invoke(true);
                Status?.Invoke($"Conectado a {port.PortName}");
                ReadLoop(port, ct);
            }
            catch { /* desconexión, timeout, puerto ocupado... */ }
            finally
            {
                lock (_lock) { if (ReferenceEquals(_port, port)) _port = null; }
                try { port?.Dispose(); } catch { }
            }

            if (ct.IsCancellationRequested) return;
            Connected?.Invoke(false);
            Status?.Invoke("Conexión perdida, reintentando...");
            ct.WaitHandle.WaitOne(2000);
        }
    }

    static SerialPort Open(string name)
    {
        var p = new SerialPort(name, 115200)
        {
            NewLine = "\n",
            ReadTimeout = 1500,
            WriteTimeout = 500,
            DtrEnable = true // necesario en el ATmega32u4 (Pro Micro) para que envíe datos
        };
        p.Open();
        return p;
    }

    static SerialPort? AutoDetect(CancellationToken ct)
    {
        foreach (var name in SerialPort.GetPortNames().OrderBy(n => n))
        {
            if (ct.IsCancellationRequested) break;
            SerialPort? p = null;
            try
            {
                p = Open(name);
                for (int i = 0; i < 5; i++)
                    if (IsDeckLine(p.ReadLine())) return p;
            }
            catch { }
            try { p?.Dispose(); } catch { }
        }
        return null;
    }

    static bool IsDeckLine(string line)
    {
        line = line.Trim();
        return line.StartsWith('S') && line.Count(c => c == '|') == SliderCount - 1;
    }

    void ReadLoop(SerialPort port, CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            var line = port.ReadLine().Trim(); // lanza TimeoutException si el Arduino calla
            if (line.Length < 2) continue;

            if (line[0] == 'S')
            {
                var parts = line[1..].Split('|');
                if (parts.Length != SliderCount) continue;
                var v = new int[SliderCount];
                bool ok = true;
                for (int i = 0; i < SliderCount; i++) ok &= int.TryParse(parts[i], out v[i]);
                if (ok) SlidersReceived?.Invoke(v);
            }
            else if (line[0] == 'B' && int.TryParse(line[1..], out int b))
            {
                ButtonPressed?.Invoke(b);
            }
        }
    }

    public void Dispose() => Stop();
}
