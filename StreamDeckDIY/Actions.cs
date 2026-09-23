using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace StreamDeckDIY;

public static class Actions
{
    [DllImport("user32.dll")]
    static extern void keybd_event(byte vk, byte scan, uint flags, UIntPtr extra);

    public static readonly string[] MediaKeys =
        { "PlayPause", "Next", "Previous", "Stop", "VolumeMute", "VolumeUp", "VolumeDown" };

    // ---------- Abrir programa / URL ----------
    // Formatos: C:\ruta\app.exe | "C:\ruta con espacios\app.exe" --arg | https://... | .lnk / .bat
    public static void Open(string param)
    {
        param = param.Trim();
        if (param.Length == 0) return;

        string file = param, args = "";
        if (param.StartsWith('"'))
        {
            int end = param.IndexOf('"', 1);
            if (end > 0) { file = param[1..end]; args = param[(end + 1)..].Trim(); }
        }
        else if (!File.Exists(param) && !param.Contains("://"))
        {
            int sp = param.IndexOf(' ');
            if (sp > 0) { file = param[..sp]; args = param[(sp + 1)..].Trim(); }
        }
        Process.Start(new ProcessStartInfo(file, args) { UseShellExecute = true });
    }

    // ---------- Teclas multimedia ----------
    public static void Media(string name)
    {
        int vk = name.Trim().ToLowerInvariant() switch
        {
            "playpause" => 0xB3,
            "next" => 0xB0,
            "previous" => 0xB1,
            "stop" => 0xB2,
            "volumemute" => 0xAD,
            "volumeup" => 0xAF,
            "volumedown" => 0xAE,
            _ => throw new ArgumentException($"Tecla multimedia desconocida: '{name}'")
        };
        Tap((byte)vk);
    }

    // ---------- Atajos y macros ----------
    // Pasos separados por ';'. Cada paso puede ser:
    //   Ctrl+Shift+M          → atajo de teclado
    //   "Hola, mundo"         → escribe ese texto (\n = Enter, \t = Tab, "" = comilla)
    //   wait:500              → espera 500 ms (también "esperar:500")
    // Ejemplo: Ctrl+A ; "usuario@correo.com" ; Tab ; "mi clave\n"
    public static void SendMacro(string macro)
    {
        foreach (var step in SplitSteps(macro))
        {
            if (step.StartsWith('"'))
            {
                if (step.Length < 2 || !step.EndsWith('"'))
                    throw new ArgumentException($"Comillas sin cerrar en: {step}");
                TypeText(step[1..^1].Replace("\"\"", "\""));
            }
            else if (step.StartsWith("wait:", StringComparison.OrdinalIgnoreCase) ||
                     step.StartsWith("esperar:", StringComparison.OrdinalIgnoreCase))
            {
                if (!int.TryParse(step[(step.IndexOf(':') + 1)..].Trim(), out int ms))
                    throw new ArgumentException($"Tiempo no válido en: {step}");
                Thread.Sleep(Math.Clamp(ms, 0, 10_000));
            }
            else
            {
                var keys = step.Split('+', StringSplitOptions.TrimEntries).Select(ParseKey).ToList();
                if (keys.Contains(0)) throw new ArgumentException($"Tecla no válida en '{step}'");

                foreach (var k in keys) Key(k, false);
                for (int i = keys.Count - 1; i >= 0; i--) Key(keys[i], true);
            }
            Thread.Sleep(30);
        }
    }

    /// <summary>Separa por ';' ignorando los que estén dentro de comillas.</summary>
    static List<string> SplitSteps(string macro)
    {
        var steps = new List<string>();
        var sb = new StringBuilder();
        bool inQuotes = false;

        void Flush()
        {
            var s = sb.ToString().Trim();
            if (s.Length > 0) steps.Add(s);
            sb.Clear();
        }

        for (int i = 0; i < macro.Length; i++)
        {
            char c = macro[i];
            if (c == '"')
            {
                if (inQuotes && i + 1 < macro.Length && macro[i + 1] == '"') { sb.Append("\"\""); i++; continue; }
                inQuotes = !inQuotes;
                sb.Append(c);
            }
            else if (c == ';' && !inQuotes) Flush();
            else sb.Append(c);
        }
        Flush();
        return steps;
    }

    // ---------- Escribir texto (Unicode: vale para ñ, acentos, @, emojis...) ----------
    static void TypeText(string text)
    {
        text = text.Replace("\\n", "\n").Replace("\\t", "\t");
        foreach (char c in text)
        {
            if (c == '\r') continue;
            if (c == '\n') Tap(0x0D);       // Enter
            else if (c == '\t') Tap(0x09);  // Tab
            else SendUnicode(c);
            Thread.Sleep(4);                // evita que algunas aplicaciones pierdan caracteres
        }
    }

    static void SendUnicode(char c)
    {
        var inputs = new[] { UnicodeKey(c, false), UnicodeKey(c, true) };
        SendInput((uint)inputs.Length, inputs, Marshal.SizeOf<INPUT>());
    }

    static INPUT UnicodeKey(char c, bool up) => new()
    {
        type = 1, // INPUT_KEYBOARD
        u = new InputUnion { ki = new KEYBDINPUT { wScan = c, dwFlags = 0x0004 | (up ? 0x0002u : 0u) } } // UNICODE | KEYUP
    };

    [DllImport("user32.dll", SetLastError = true)]
    static extern uint SendInput(uint count, INPUT[] inputs, int size);

    [StructLayout(LayoutKind.Sequential)] struct INPUT { public uint type; public InputUnion u; }
    [StructLayout(LayoutKind.Explicit)]
    struct InputUnion
    {
        [FieldOffset(0)] public MOUSEINPUT mi; // necesario para que el tamaño de la unión sea el correcto
        [FieldOffset(0)] public KEYBDINPUT ki;
    }
    [StructLayout(LayoutKind.Sequential)]
    struct MOUSEINPUT { public int dx, dy; public uint mouseData, dwFlags, time; public UIntPtr dwExtraInfo; }
    [StructLayout(LayoutKind.Sequential)]
    struct KEYBDINPUT { public ushort wVk, wScan; public uint dwFlags, time; public UIntPtr dwExtraInfo; }

    static byte ParseKey(string t)
    {
        switch (t.ToLowerInvariant())
        {
            case "ctrl": case "control": return 0x11;
            case "shift": return 0x10;
            case "alt": return 0x12;
            case "win": case "windows": return 0x5B;
            case "esc": return 0x1B;
            case "enter": return 0x0D;
            case "del": return 0x2E;
            case "ins": return 0x2D;
        }
        if (t.Length == 1 && char.IsAsciiLetterOrDigit(t[0])) return (byte)char.ToUpperInvariant(t[0]);
        if (t.Length == 0 || t.All(char.IsDigit)) return 0;
        return Enum.TryParse<Keys>(t, true, out var k) && (int)k is > 0 and <= 255 ? (byte)(int)k : (byte)0;
    }

    static void Tap(byte vk) { Key(vk, false); Key(vk, true); }

    static void Key(byte vk, bool up)
    {
        bool ext = vk is (>= 0x21 and <= 0x28) or 0x2D or 0x2E or (>= 0xA6 and <= 0xB7);
        keybd_event(vk, 0, (ext ? 1u : 0u) | (up ? 2u : 0u), UIntPtr.Zero);
    }
}
