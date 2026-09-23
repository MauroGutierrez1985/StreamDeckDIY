using System.IO.Ports;
using Microsoft.Win32;
using NAudio.CoreAudioApi;

namespace StreamDeckDIY;

/// <summary>
/// La parte visual vive en MainForm.Designer.cs (editable con el diseñador de Visual Studio).
/// Este archivo solo contiene la lógica.
/// </summary>
public sealed partial class MainForm : Form
{
    sealed record Opt<T>(string Text, T Value) { public override string ToString() => Text; }

    const int NS = SerialService.SliderCount, NB = 10;

    // Los combos se rellenan en tiempo de ejecución porque están ligados a enums.
    static readonly Opt<SliderTarget>[] SliderTypes =
    {
        new("Sin asignar", SliderTarget.None), new("Volumen master", SliderTarget.Master),
        new("Micrófono", SliderTarget.Microphone), new("Aplicación", SliderTarget.Application),
        new("Dispositivo de audio", SliderTarget.Device), new("Ventana activa", SliderTarget.ActiveWindow)
    };
    static readonly Opt<ButtonAction>[] ButtonActions =
    {
        new("Sin acción", ButtonAction.None), new("Abrir programa / URL", ButtonAction.OpenProgram),
        new("Atajo / macro de teclado", ButtonAction.Hotkey), new("Tecla multimedia", ButtonAction.Media),
        new("Silenciar aplicación", ButtonAction.MuteApp), new("Silenciar micrófono", ButtonAction.MuteMic),
        new("Silenciar master", ButtonAction.MuteMaster), new("Cambiar salida de audio", ButtonAction.SwitchOutput),
        new("Cambiar micrófono predeterminado", ButtonAction.SwitchInput)
    };
    static readonly Opt<LedMode>[] LedModes =
    {
        new("Arcoíris", LedMode.Rainbow), new("Rojo", LedMode.Red), new("Verde", LedMode.Green),
        new("Azul", LedMode.Blue), new("Blanco", LedMode.White), new("Apagado", LedMode.Off),
        new("Color personalizado", LedMode.Custom)
    };

    readonly AppConfig _cfg;
    readonly DeckController _deck;
    bool _startHidden, _exiting, _loading, _minimizeToTray;

    // Grupos de controles del diseñador, localizados por nombre (prefijo + número).
    // Si renombras controles en el diseñador, actualiza el prefijo aquí.
    readonly TextBox[] _sName;
    readonly ComboBox[] _sType, _sParam;
    readonly CheckBox[] _sInv;
    readonly ProgressBar[] _sBar;
    readonly Label[] _bLbl;
    readonly TextBox[] _bName;
    readonly ComboBox[] _bAct, _bParam;
    readonly Button[] _bBrowse, _bTest;

    public MainForm(AppConfig cfg, bool startHidden)
    {
        InitializeComponent(); // ← controles creados por el diseñador

        _cfg = cfg;
        _startHidden = startHidden;
        _deck = new DeckController(cfg);

        _sName = Grab<TextBox>("txtSliderName", NS);
        _sType = Grab<ComboBox>("cmbSliderType", NS);
        _sParam = Grab<ComboBox>("cmbSliderParam", NS);
        _sInv = Grab<CheckBox>("chkSliderInvert", NS);
        _sBar = Grab<ProgressBar>("pbSlider", NS);
        _bLbl = Grab<Label>("lblBtn", NB);
        _bName = Grab<TextBox>("txtBtnName", NB);
        _bAct = Grab<ComboBox>("cmbBtnAction", NB);
        _bParam = Grab<ComboBox>("cmbBtnParam", NB);
        _bBrowse = Grab<Button>("btnBrowse", NB);
        _bTest = Grab<Button>("btnTest", NB);

        //Icon = SystemIcons.Application;
        //notifyIcon.Icon = SystemIcons.Application;

        LoadConfigToUi();

        _deck.Serial.Status += s => Ui(() =>
        {
            lblStatus.Text = s;
            var t = "Stream Deck DIY - " + s;
            notifyIcon.Text = t.Length > 63 ? t[..63] : t;
            btnConnect.Text = _deck.Serial.IsRunning ? "Desconectar" : "Conectar";
        });
    }

    T[] Grab<T>(string prefix, int count) where T : Control =>
        Enumerable.Range(1, count).Select(i => (T)Controls.Find(prefix + i, true).Single()).ToArray();

    // ================= Config → interfaz =================

    void LoadConfigToUi()
    {
        _loading = true;

        for (int i = 0; i < NS; i++)
        {
            var s = _cfg.Sliders[i];
            _sName[i].Text = s.Name;
            FillCombo(_sType[i], SliderTypes, s.Target);
            _sParam[i].Text = s.Param;
            _sInv[i].Checked = s.Invert;
            UpdateSliderRow(i);
        }
        for (int i = 0; i < NB; i++)
        {
            var b = _cfg.Buttons[i];
            _bName[i].Text = b.Name;
            FillCombo(_bAct[i], ButtonActions, b.Action);
            _bParam[i].Text = b.Param;
            UpdateButtonRow(i);
        }

        FillCombo(cmbLedMode, LedModes, _cfg.Led);
        trackLedSpeed.Value = Math.Clamp(_cfg.LedSpeed, 1, 30);
        pnlLedSwatch.BackColor = ParseColor(_cfg.LedColor);
        UpdateLedUi();

        RefreshPorts();
        chkAutoConnect.Checked = _cfg.AutoConnect;
        chkStartup.Checked = IsStartupEnabled();

        _loading = false;
    }

    // ================= Eventos: sliders y botones (compartidos por todas las filas) =================

    void cmbSliderType_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (_loading) return;
        int i = Array.IndexOf(_sType, sender);
        if (i >= 0) UpdateSliderRow(i);
    }

    void cmbSliderParam_DropDown(object? sender, EventArgs e)
    {
        int i = Array.IndexOf(_sParam, sender);
        if (i < 0) return;
        Populate(_sParam[i], () => Val<SliderTarget>(_sType[i]) switch
        {
            SliderTarget.Application => _deck.Audio.GetAudioProcesses(),
            SliderTarget.Device => _deck.Audio.GetDeviceNames(),
            _ => Array.Empty<string>()
        });
    }

    void cmbBtnAction_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (_loading) return;
        int i = Array.IndexOf(_bAct, sender);
        if (i >= 0) UpdateButtonRow(i);
    }

    void cmbBtnParam_DropDown(object? sender, EventArgs e)
    {
        int i = Array.IndexOf(_bParam, sender);
        if (i < 0) return;
        Populate(_bParam[i], () => Val<ButtonAction>(_bAct[i]) switch
        {
            ButtonAction.Media => Actions.MediaKeys,
            ButtonAction.MuteApp => _deck.Audio.GetAudioProcesses(),
            ButtonAction.SwitchOutput => _deck.Audio.GetDeviceNames(DataFlow.Render),
            ButtonAction.SwitchInput => _deck.Audio.GetDeviceNames(DataFlow.Capture),
            _ => Array.Empty<string>()
        });
    }

    void btnBrowse_Click(object? sender, EventArgs e)
    {
        int i = Array.IndexOf(_bBrowse, sender);
        if (i < 0) return;
        using var dlg = new OpenFileDialog { Filter = "Programas|*.exe;*.lnk;*.bat;*.cmd|Todos|*.*" };
        if (dlg.ShowDialog(this) == DialogResult.OK)
            _bParam[i].Text = dlg.FileName.Contains(' ') ? $"\"{dlg.FileName}\"" : dlg.FileName;
    }

    async void btnTest_Click(object? sender, EventArgs e)
    {
        int i = Array.IndexOf(_bTest, sender);
        if (i < 0) return;
        var test = _bTest[i];
        try
        {
            var cfg = CollectButton(i);
            if (cfg.Action == ButtonAction.Hotkey)
            {
                // Da tiempo a poner el foco en la ventana donde quieres probar el atajo o el texto
                test.Enabled = false;
                for (int s = 3; s > 0; s--) { test.Text = $"{s}..."; await Task.Delay(1000); }
                test.Text = "Probar";
                test.Enabled = true;
                await Task.Run(() => _deck.Execute(cfg));
            }
            else _deck.Execute(cfg);
        }
        catch (Exception ex)
        {
            test.Text = "Probar";
            test.Enabled = true;
            MessageBox.Show(ex.Message, "No se pudo ejecutar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // ================= Eventos: LEDs =================

    void cmbLedMode_SelectedIndexChanged(object? sender, EventArgs e) => OnLedChanged();
    void trackLedSpeed_ValueChanged(object? sender, EventArgs e) => OnLedChanged();

    void btnLedColor_Click(object? sender, EventArgs e)
    {
        using var dlg = new ColorDialog { FullOpen = true, Color = pnlLedSwatch.BackColor };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        pnlLedSwatch.BackColor = dlg.Color;
        _cfg.LedColor = $"#{dlg.Color.R:X2}{dlg.Color.G:X2}{dlg.Color.B:X2}";
        OnLedChanged();
    }

    void OnLedChanged()
    {
        if (_loading) return;
        _cfg.Led = Val<LedMode>(cmbLedMode);
        _cfg.LedSpeed = trackLedSpeed.Value;
        UpdateLedUi();
        _deck.SendLed(); // vista previa en el Arduino al instante
    }

    // ================= Eventos: General, guardar, bandeja, temporizador =================

    void btnRefreshPorts_Click(object? sender, EventArgs e) => RefreshPorts();

    void btnConnect_Click(object? sender, EventArgs e)
    {
        if (_deck.Serial.IsRunning) _deck.Disconnect();
        else
        {
            _cfg.Port = cmbPort.SelectedIndex <= 0 ? "" : cmbPort.Text;
            _deck.Connect();
        }
        btnConnect.Text = _deck.Serial.IsRunning ? "Desconectar" : "Conectar";
    }

    void btnSave_Click(object? sender, EventArgs e) => SaveAll();

    void notifyIcon_DoubleClick(object? sender, EventArgs e) => ShowFromTray();
    void mnuOpen_Click(object? sender, EventArgs e) => ShowFromTray();
    void mnuExit_Click(object? sender, EventArgs e) => ExitApp();

    void timerUi_Tick(object? sender, EventArgs e)
    {
        if (!Visible) return;
        for (int i = 0; i < NS; i++)
            _sBar[i].Value = Math.Clamp((int)(_deck.Values[i] * 1000), 0, 1000);
        long now = Environment.TickCount64;
        for (int i = 0; i < NB; i++) // ilumina la etiqueta del botón recién pulsado
            _bLbl[i].BackColor = now - _deck.LastPress[i] < 300 ? Color.LightGreen : Color.Transparent;
    }

    // ================= Lógica de interfaz =================

    void UpdateSliderRow(int i)
    {
        var target = Val<SliderTarget>(_sType[i]);
        _sParam[i].Enabled = target is SliderTarget.Application or SliderTarget.Device;
    }

    void UpdateButtonRow(int i)
    {
        var a = Val<ButtonAction>(_bAct[i]);
        _bBrowse[i].Enabled = a == ButtonAction.OpenProgram;
        _bParam[i].Enabled = a is not (ButtonAction.None or ButtonAction.MuteMic or ButtonAction.MuteMaster);
    }

    void UpdateLedUi()
    {
        var mode = Val<LedMode>(cmbLedMode);
        trackLedSpeed.Enabled = mode == LedMode.Rainbow;
        btnLedColor.Enabled = mode == LedMode.Custom;
        lblLedSpeedValue.Text = trackLedSpeed.Value.ToString();
    }

    ButtonConfig CollectButton(int i) => new()
    {
        Name = _bName[i].Text.Trim(),
        Action = Val<ButtonAction>(_bAct[i]),
        Param = _bParam[i].Text.Trim()
    };

    void RefreshPorts()
    {
        cmbPort.Items.Clear();
        cmbPort.Items.Add("Automático (detectar)");
        foreach (var p in SerialPort.GetPortNames().OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
            cmbPort.Items.Add(p);
        if (!string.IsNullOrEmpty(_cfg.Port) && !cmbPort.Items.Contains(_cfg.Port))
            cmbPort.Items.Add(_cfg.Port);
        cmbPort.SelectedIndex = string.IsNullOrEmpty(_cfg.Port) ? 0 : Math.Max(cmbPort.Items.IndexOf(_cfg.Port), 0);
    }

    void SaveAll()
    {
        for (int i = 0; i < NS; i++)
        {
            var s = _cfg.Sliders[i];
            s.Name = _sName[i].Text.Trim();
            s.Target = Val<SliderTarget>(_sType[i]);
            s.Param = _sParam[i].Text.Trim();
            s.Invert = _sInv[i].Checked;
        }
        for (int i = 0; i < NB; i++) _cfg.Buttons[i] = CollectButton(i);

        _cfg.Port = cmbPort.SelectedIndex <= 0 ? "" : cmbPort.Text;
        _cfg.AutoConnect = chkAutoConnect.Checked;
        try { SetStartup(chkStartup.Checked); } catch { }
        ConfigStore.Save(_cfg);

        if (_deck.Serial.IsRunning) _deck.Connect(); // reconecta con el puerto elegido
        _deck.SendLed();

        btnSave.Text = "Guardado ✓";
        Task.Delay(1500).ContinueWith(_ => Ui(() => btnSave.Text = "Guardar y aplicar"));
    }

    // ================= Ventana / bandeja =================

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        timerUi.Start();
        if (_cfg.AutoConnect && !_deck.Serial.IsRunning) _deck.Connect();
    }

    // Permite arrancar oculto (solo bandeja) con --minimized
    protected override void SetVisibleCore(bool value)
    {
        if (_startHidden)
        {
            _startHidden = false;
            if (!IsHandleCreated) CreateHandle();
            value = false;
        }
        base.SetVisibleCore(value);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (!_exiting && e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true; // la X minimiza a la bandeja
            Hide();
            return;
        }
        else if (!_minimizeToTray && e.CloseReason == CloseReason.ApplicationExitCall)
        {
            e.Cancel = false; // cerrar la app desde el menú de bandeja
        }
    }

    void ShowFromTray()
    {
        Show();
        WindowState = FormWindowState.Normal;
        Activate();
    }
    void ExitApp()
    {
        _exiting = true;
        Application.Exit();
    }
    void Ui(Action a) { if (IsHandleCreated && !IsDisposed) BeginInvoke(a); }

    // ================= Inicio con Windows =================

    const string RunKey = @"Software\Microsoft\Windows\CurrentVersion\Run";
    const string RunName = "StreamDeckDIY";

    static bool IsStartupEnabled()
    {
        using var k = Registry.CurrentUser.OpenSubKey(RunKey);
        return k?.GetValue(RunName) != null;
    }

    static void SetStartup(bool on)
    {
        using var k = Registry.CurrentUser.OpenSubKey(RunKey, true);
        if (k == null) return;
        if (on) k.SetValue(RunName, $"\"{Environment.ProcessPath}\" --minimized");
        else k.DeleteValue(RunName, false);
    }

    // ================= Helpers =================

    static void FillCombo<T>(ComboBox c, Opt<T>[] items, T selected)
    {
        c.Items.Clear();
        c.Items.AddRange(items);
        c.SelectedIndex = Math.Max(Array.FindIndex(items, o => EqualityComparer<T>.Default.Equals(o.Value, selected)), 0);
    }

    static T Val<T>(ComboBox c) => ((Opt<T>)c.SelectedItem!).Value;

    /// <summary>Rellena la lista de un ComboBox editable justo al desplegarlo, conservando el texto.</summary>
    static void Populate(ComboBox c, Func<IEnumerable<string>> source)
    {
        var keep = c.Text;
        c.Items.Clear();
        try { c.Items.AddRange(source().Cast<object>().ToArray()); } catch { }
        c.Text = keep;
    }

    static Color ParseColor(string hex)
    {
        try { return ColorTranslator.FromHtml(hex); } catch { return Color.White; }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        OnFormClosing(e);
    }

    private void trayMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        // si hace click en salir, cierra la app; si hace click en abrir, muestra la ventana
        if (e.ClickedItem == mnuExit)
        {
            _minimizeToTray = false;
            ExitApp();
        }
        else if (e.ClickedItem == mnuOpen)
        {
            ShowFromTray();
        }
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
        {
            Hide();
        }
    }
}
