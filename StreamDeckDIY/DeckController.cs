using System.Text;
using NAudio.CoreAudioApi;

namespace StreamDeckDIY;

/// <summary>Conecta los eventos del Arduino con el audio de Windows y las acciones.</summary>
public sealed class DeckController : IDisposable
{
    public AppConfig Config { get; }
    public SerialService Serial { get; } = new();
    public AudioService Audio { get; } = new();

    /// <summary>Posición actual de cada slider (0..1, ya invertida si procede). Lo lee la interfaz.</summary>
    public float[] Values { get; } = new float[SerialService.SliderCount];
    /// <summary>TickCount64 de la última pulsación de cada botón (para iluminarlo en la interfaz).</summary>
    public long[] LastPress { get; } = Enumerable.Repeat(-10_000L, 10).ToArray();

    readonly float[] _applied = Enumerable.Repeat(-1f, SerialService.SliderCount).ToArray();
    readonly long[] _lastApplyTick = new long[SerialService.SliderCount];

    public DeckController(AppConfig cfg)
    {
        Config = cfg;
        Serial.SlidersReceived += OnSliders;
        Serial.ButtonPressed += OnButton;
        Serial.Connected += connected =>
        {
            if (!connected) return;
            Array.Fill(_applied, -1f); // reaplicar volúmenes según la posición física de los sliders
            SendLed();
        };
    }

    public void Connect() => Serial.Start(Config.Port);
    public void Disconnect() => Serial.Stop();

    // ---------------- Sliders ----------------

    void OnSliders(int[] raw)
    {
        long now = Environment.TickCount64;
        for (int i = 0; i < raw.Length && i < Config.Sliders.Count; i++)
        {
            var cfg = Config.Sliders[i];
            float v = Math.Clamp((raw[i] - 4) / 1015f, 0f, 1f); // pequeña zona muerta en los extremos
            if (cfg.Invert) v = 1f - v;
            Values[i] = v;

            bool edge = (v == 0f || v == 1f) && v != _applied[i];
            if (!edge && Math.Abs(v - _applied[i]) < 0.006f) continue; // filtra ruido del potenciómetro
            if (now - _lastApplyTick[i] < 20) continue;                // limita llamadas a Windows

            _applied[i] = v;
            _lastApplyTick[i] = now;
            try { Audio.SetVolume(cfg, v); } catch { }
        }
    }

    // ---------------- Botones ----------------

    void OnButton(int i)
    {
        if (i < 0 || i >= Config.Buttons.Count) return;
        long now = Environment.TickCount64;
        if (now - LastPress[i] < 150) return; // antirrebote por software
        LastPress[i] = now;

        var b = Config.Buttons[i];
        Task.Run(() => { try { Execute(b); } catch { } });
    }

    /// <summary>Ejecuta una acción (también se usa desde el botón "Probar"). Lanza excepción si falla.</summary>
    public void Execute(ButtonConfig b)
    {
        switch (b.Action)
        {
            case ButtonAction.OpenProgram: Actions.Open(b.Param); break;
            case ButtonAction.Hotkey: Actions.SendMacro(b.Param); break;
            case ButtonAction.Media: Actions.Media(b.Param); break;
            case ButtonAction.MuteApp: Audio.ToggleMuteApp(b.Param); break;
            case ButtonAction.MuteMic: Audio.ToggleMute(DataFlow.Capture); break;
            case ButtonAction.MuteMaster: Audio.ToggleMute(DataFlow.Render); break;
            case ButtonAction.SwitchOutput: Audio.SwitchDefault(DataFlow.Render, b.Param); break;
            case ButtonAction.SwitchInput: Audio.SwitchDefault(DataFlow.Capture, b.Param); break;
        }
    }

    // ---------------- LEDs ----------------

    public void SendLed()
    {
        Serial.Send((byte)Math.Clamp(Config.LedSpeed, 1, 30));
        switch (Config.Led)
        {
            case LedMode.Rainbow: Serial.Send((byte)'R'); break;
            case LedMode.Red: Serial.Send((byte)'F'); break;
            case LedMode.Green: Serial.Send((byte)'G'); break;
            case LedMode.Blue: Serial.Send((byte)'B'); break;
            case LedMode.White: Serial.Send((byte)'W'); break;
            case LedMode.Off: Serial.Send((byte)'O'); break;
            case LedMode.Custom:
                Color c;
                try { c = ColorTranslator.FromHtml(Config.LedColor); } catch { c = Color.White; }
                // Solo '\n' como terminador: el firmware interpreta un byte 10/13 suelto como "velocidad"
                Serial.Send(Encoding.ASCII.GetBytes($"C{c.R},{c.G},{c.B}\n"));
                break;
        }
    }

    public void Dispose() => Serial.Dispose();
}
