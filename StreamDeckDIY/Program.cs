namespace StreamDeckDIY;

static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        using var mutex = new Mutex(true, "StreamDeckDIY.SingleInstance", out bool isNew);
        if (!isNew) return; // ya hay una instancia en la bandeja

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm(ConfigStore.Load(), args.Contains("--minimized")));
    }
}
