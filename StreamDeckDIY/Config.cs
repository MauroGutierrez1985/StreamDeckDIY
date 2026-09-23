using System.Text.Json;
using System.Text.Json.Serialization;

namespace StreamDeckDIY;

public enum SliderTarget { None, Master, Microphone, Application, Device, ActiveWindow }
public enum ButtonAction { None, OpenProgram, Hotkey, Media, MuteApp, MuteMic, MuteMaster, SwitchOutput, SwitchInput }
public enum LedMode { Rainbow, Red, Green, Blue, White, Off, Custom }

public class SliderConfig
{
    public string Name { get; set; } = "";
    public SliderTarget Target { get; set; } = SliderTarget.None;
    /// <summary>Aplicación(es) separadas por ';' o nombre del dispositivo.</summary>
    public string Param { get; set; } = "";
    public bool Invert { get; set; }
}

public class ButtonConfig
{
    public string Name { get; set; } = "";
    public ButtonAction Action { get; set; } = ButtonAction.None;
    public string Param { get; set; } = "";
}

public class AppConfig
{
    public string Port { get; set; } = "";          // "" = detección automática
    public bool AutoConnect { get; set; } = true;
    public LedMode Led { get; set; } = LedMode.Rainbow;
    public int LedSpeed { get; set; } = 10;          // 1..30
    public string LedColor { get; set; } = "#FFFFFF";
    public List<SliderConfig> Sliders { get; set; } = new();
    public List<ButtonConfig> Buttons { get; set; } = new();
}

public static class ConfigStore
{
    static readonly string Dir = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StreamDeckDIY");
    static readonly string FilePath = Path.Combine(Dir, "config.json");
    static readonly JsonSerializerOptions Opts = new()
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public static AppConfig Load()
    {
        AppConfig cfg;
        try
        {
            cfg = File.Exists(FilePath)
                ? JsonSerializer.Deserialize<AppConfig>(File.ReadAllText(FilePath), Opts) ?? new()
                : new();
        }
        catch { cfg = new(); }

        // Valores por defecto y relleno hasta 5 sliders / 10 botones
        if (cfg.Sliders.Count == 0)
        {
            cfg.Sliders.Add(new SliderConfig { Name = "Master", Target = SliderTarget.Master });
            cfg.Sliders.Add(new SliderConfig { Name = "Micrófono", Target = SliderTarget.Microphone });
        }
        while (cfg.Sliders.Count < SerialService.SliderCount)
            cfg.Sliders.Add(new SliderConfig { Name = $"Slider {cfg.Sliders.Count + 1}" });
        while (cfg.Buttons.Count < 10)
            cfg.Buttons.Add(new ButtonConfig { Name = $"Botón {cfg.Buttons.Count + 1}" });
        return cfg;
    }

    public static void Save(AppConfig cfg)
    {
        Directory.CreateDirectory(Dir);
        File.WriteAllText(FilePath, JsonSerializer.Serialize(cfg, Opts));
    }
}
