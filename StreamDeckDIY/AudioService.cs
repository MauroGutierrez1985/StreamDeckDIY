using System.Diagnostics;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;

namespace StreamDeckDIY;

public sealed class AudioService
{
    // ---------------- Volumen ----------------

    public void SetVolume(SliderConfig s, float v)
    {
        switch (s.Target)
        {
            case SliderTarget.Master: SetEndpointVolume(DataFlow.Render, v); break;
            case SliderTarget.Microphone: SetEndpointVolume(DataFlow.Capture, v); break;
            case SliderTarget.Device: SetDeviceVolume(s.Param, v); break;
            case SliderTarget.Application:
                ForSessions(pid => MatchesAny(pid, s.Param), a => a.Volume = v);
                break;
            case SliderTarget.ActiveWindow:
                {
                    var fg = ForegroundPid();
                    ForSessions(pid => pid == fg, a => a.Volume = v);
                    break;
                }
        }
    }

    static void SetEndpointVolume(DataFlow flow, float v)
    {
        using var en = new MMDeviceEnumerator();
        using var dev = en.GetDefaultAudioEndpoint(flow, Role.Multimedia);
        dev.AudioEndpointVolume.MasterVolumeLevelScalar = v;
    }

    static void SetDeviceVolume(string name, float v)
    {
        if (string.IsNullOrWhiteSpace(name)) return;
        using var en = new MMDeviceEnumerator();
        foreach (var d in en.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active))
        {
            if (d.FriendlyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                d.AudioEndpointVolume.MasterVolumeLevelScalar = v;
            d.Dispose();
        }
    }

    // ---------------- Silenciar ----------------

    public void ToggleMute(DataFlow flow)
    {
        using var en = new MMDeviceEnumerator();
        using var dev = en.GetDefaultAudioEndpoint(flow, Role.Multimedia);
        dev.AudioEndpointVolume.Mute = !dev.AudioEndpointVolume.Mute;
    }

    public void ToggleMuteApp(string apps)
    {
        bool? target = null;
        ForSessions(pid => MatchesAny(pid, apps), a => { target ??= !a.Mute; a.Mute = target.Value; });
    }

    // ---------------- Sesiones de aplicaciones ----------------

    static void ForSessions(Func<uint, bool> filter, Action<SimpleAudioVolume> action)
    {
        using var en = new MMDeviceEnumerator();
        using var dev = en.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        var sessions = dev.AudioSessionManager.Sessions;
        for (int i = 0; i < sessions.Count; i++)
        {
            var s = sessions[i];
            if (filter(s.GetProcessID)) action(s.SimpleAudioVolume);
        }
    }

    static bool MatchesAny(uint pid, string list)
    {
        if (pid == 0 || string.IsNullOrWhiteSpace(list)) return false;
        var name = ProcessName(pid);
        return list.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Any(n => string.Equals(n.Replace(".exe", "", StringComparison.OrdinalIgnoreCase),
                                    name, StringComparison.OrdinalIgnoreCase));
    }

    static string ProcessName(uint pid)
    {
        try { return Process.GetProcessById((int)pid).ProcessName; } catch { return ""; }
    }

    // ---------------- Listas para la interfaz ----------------

    public List<string> GetAudioProcesses()
    {
        var names = new SortedSet<string>(StringComparer.OrdinalIgnoreCase);
        ForSessions(pid =>
        {
            if (pid != 0) { var n = ProcessName(pid); if (n != "") names.Add(n); }
            return false;
        }, _ => { });
        return names.ToList();
    }

    public List<string> GetDeviceNames(DataFlow flow = DataFlow.All)
    {
        using var en = new MMDeviceEnumerator();
        var list = new List<string>();
        foreach (var d in en.EnumerateAudioEndPoints(flow, DeviceState.Active))
        {
            list.Add(d.FriendlyName);
            d.Dispose();
        }
        return list;
    }

    // ---------------- Cambiar dispositivo predeterminado ----------------

    /// <param name="names">Nombres (o parte) separados por ';'. Vacío = rotar entre todos.</param>
    public void SwitchDefault(DataFlow flow, string names)
    {
        using var en = new MMDeviceEnumerator();
        var all = en.EnumerateAudioEndPoints(flow, DeviceState.Active).ToList();
        try
        {
            var wanted = names.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var list = wanted.Length == 0
                ? all
                : wanted.Select(n => all.FirstOrDefault(d =>
                        d.FriendlyName.Contains(n, StringComparison.OrdinalIgnoreCase)))
                    .OfType<MMDevice>().ToList();
            if (list.Count == 0) return;

            using var cur = en.GetDefaultAudioEndpoint(flow, Role.Multimedia);
            int idx = list.FindIndex(d => d.ID == cur.ID);
            var target = list[(idx + 1) % list.Count];

            var policy = (IPolicyConfig)new PolicyConfigClient();
            for (int role = 0; role < 3; role++) // consola, multimedia, comunicaciones
                policy.SetDefaultEndpoint(target.ID, role);
        }
        finally { foreach (var d in all) d.Dispose(); }
    }

    // ---------------- Interop ----------------

    [DllImport("user32.dll")] static extern IntPtr GetForegroundWindow();
    [DllImport("user32.dll")] static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint pid);

    static uint ForegroundPid()
    {
        GetWindowThreadProcessId(GetForegroundWindow(), out uint pid);
        return pid;
    }

    // Interfaz COM no documentada de Windows para cambiar el dispositivo predeterminado.
    // El orden de los métodos importa (vtable), los parámetros anteriores a SetDefaultEndpoint son relleno.
    [ComImport, Guid("F8679F50-850A-41CF-9C72-430F290290C8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IPolicyConfig
    {
        [PreserveSig] int GetMixFormat(IntPtr a, IntPtr b);
        [PreserveSig] int GetDeviceFormat(IntPtr a, int b, IntPtr c);
        [PreserveSig] int ResetDeviceFormat(IntPtr a);
        [PreserveSig] int SetDeviceFormat(IntPtr a, IntPtr b, IntPtr c);
        [PreserveSig] int GetProcessingPeriod(IntPtr a, int b, IntPtr c, IntPtr d);
        [PreserveSig] int SetProcessingPeriod(IntPtr a, IntPtr b);
        [PreserveSig] int GetShareMode(IntPtr a, IntPtr b);
        [PreserveSig] int SetShareMode(IntPtr a, IntPtr b);
        [PreserveSig] int GetPropertyValue(IntPtr a, IntPtr b, IntPtr c);
        [PreserveSig] int SetPropertyValue(IntPtr a, IntPtr b, IntPtr c);
        [PreserveSig] int SetDefaultEndpoint([MarshalAs(UnmanagedType.LPWStr)] string deviceId, int role);
        [PreserveSig] int SetEndpointVisibility([MarshalAs(UnmanagedType.LPWStr)] string deviceId, int visible);
    }

    [ComImport, Guid("870AF99C-171D-4F9E-AF0D-E63DF40C2BC9")]
    class PolicyConfigClient { }
}
