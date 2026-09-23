namespace StreamDeckDIY
{
    partial class MainForm
    {
        /// <summary>Contenedor de componentes (NotifyIcon, Timer, menús).</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>Método necesario para admitir el Diseñador. No se puede modificar el contenido de este método con el editor de código.</summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tblSliders = new TableLayoutPanel();
            lblSliderHeader1 = new Label();
            lblSliderHeader2 = new Label();
            lblSliderHeader3 = new Label();
            lblSliderHeader4 = new Label();
            lblSliderHeader5 = new Label();
            lblSlider1 = new Label();
            txtSliderName1 = new TextBox();
            cmbSliderType1 = new ComboBox();
            cmbSliderParam1 = new ComboBox();
            chkSliderInvert1 = new CheckBox();
            pbSlider1 = new ProgressBar();
            lblSlider2 = new Label();
            txtSliderName2 = new TextBox();
            cmbSliderType2 = new ComboBox();
            cmbSliderParam2 = new ComboBox();
            chkSliderInvert2 = new CheckBox();
            pbSlider2 = new ProgressBar();
            lblSlider3 = new Label();
            txtSliderName3 = new TextBox();
            cmbSliderType3 = new ComboBox();
            cmbSliderParam3 = new ComboBox();
            chkSliderInvert3 = new CheckBox();
            pbSlider3 = new ProgressBar();
            lblSlider4 = new Label();
            txtSliderName4 = new TextBox();
            cmbSliderType4 = new ComboBox();
            cmbSliderParam4 = new ComboBox();
            chkSliderInvert4 = new CheckBox();
            pbSlider4 = new ProgressBar();
            lblSlider5 = new Label();
            txtSliderName5 = new TextBox();
            cmbSliderType5 = new ComboBox();
            cmbSliderParam5 = new ComboBox();
            chkSliderInvert5 = new CheckBox();
            pbSlider5 = new ProgressBar();
            lblSlidersHint = new Label();
            tabSliders = new TabPage();
            tblButtons = new TableLayoutPanel();
            lblButtonHeader1 = new Label();
            lblButtonHeader2 = new Label();
            lblButtonHeader3 = new Label();
            lblBtn1 = new Label();
            txtBtnName1 = new TextBox();
            cmbBtnAction1 = new ComboBox();
            cmbBtnParam1 = new ComboBox();
            btnBrowse1 = new Button();
            btnTest1 = new Button();
            lblBtn2 = new Label();
            txtBtnName2 = new TextBox();
            cmbBtnAction2 = new ComboBox();
            cmbBtnParam2 = new ComboBox();
            btnBrowse2 = new Button();
            btnTest2 = new Button();
            lblBtn3 = new Label();
            txtBtnName3 = new TextBox();
            cmbBtnAction3 = new ComboBox();
            cmbBtnParam3 = new ComboBox();
            btnBrowse3 = new Button();
            btnTest3 = new Button();
            lblBtn4 = new Label();
            txtBtnName4 = new TextBox();
            cmbBtnAction4 = new ComboBox();
            cmbBtnParam4 = new ComboBox();
            btnBrowse4 = new Button();
            btnTest4 = new Button();
            lblBtn5 = new Label();
            txtBtnName5 = new TextBox();
            cmbBtnAction5 = new ComboBox();
            cmbBtnParam5 = new ComboBox();
            btnBrowse5 = new Button();
            btnTest5 = new Button();
            lblBtn6 = new Label();
            txtBtnName6 = new TextBox();
            cmbBtnAction6 = new ComboBox();
            cmbBtnParam6 = new ComboBox();
            btnBrowse6 = new Button();
            btnTest6 = new Button();
            lblBtn7 = new Label();
            txtBtnName7 = new TextBox();
            cmbBtnAction7 = new ComboBox();
            cmbBtnParam7 = new ComboBox();
            btnBrowse7 = new Button();
            btnTest7 = new Button();
            lblBtn8 = new Label();
            txtBtnName8 = new TextBox();
            cmbBtnAction8 = new ComboBox();
            cmbBtnParam8 = new ComboBox();
            btnBrowse8 = new Button();
            btnTest8 = new Button();
            lblBtn9 = new Label();
            txtBtnName9 = new TextBox();
            cmbBtnAction9 = new ComboBox();
            cmbBtnParam9 = new ComboBox();
            btnBrowse9 = new Button();
            btnTest9 = new Button();
            lblBtn10 = new Label();
            txtBtnName10 = new TextBox();
            cmbBtnAction10 = new ComboBox();
            cmbBtnParam10 = new ComboBox();
            btnBrowse10 = new Button();
            btnTest10 = new Button();
            lblButtonsHint = new Label();
            tabButtons = new TabPage();
            tblLeds = new TableLayoutPanel();
            lblLedMode = new Label();
            cmbLedMode = new ComboBox();
            lblLedSpeed = new Label();
            flowLedSpeed = new FlowLayoutPanel();
            trackLedSpeed = new TrackBar();
            lblLedSpeedValue = new Label();
            lblLedColor = new Label();
            flowLedColor = new FlowLayoutPanel();
            btnLedColor = new Button();
            pnlLedSwatch = new Panel();
            lblLedsHint = new Label();
            tabLeds = new TabPage();
            tblGeneral = new TableLayoutPanel();
            lblPort = new Label();
            cmbPort = new ComboBox();
            btnRefreshPorts = new Button();
            lblStatusCaption = new Label();
            lblStatus = new Label();
            btnConnect = new Button();
            chkAutoConnect = new CheckBox();
            chkStartup = new CheckBox();
            tabGeneral = new TabPage();
            tabMain = new TabControl();
            btnSave = new Button();
            mnuOpen = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            trayMenu = new ContextMenuStrip(components);
            notifyIcon = new NotifyIcon(components);
            timerUi = new System.Windows.Forms.Timer(components);
            tblSliders.SuspendLayout();
            tabSliders.SuspendLayout();
            tblButtons.SuspendLayout();
            tabButtons.SuspendLayout();
            tblLeds.SuspendLayout();
            flowLedSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackLedSpeed).BeginInit();
            flowLedColor.SuspendLayout();
            tabLeds.SuspendLayout();
            tblGeneral.SuspendLayout();
            tabGeneral.SuspendLayout();
            tabMain.SuspendLayout();
            trayMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tblSliders
            // 
            tblSliders.AutoScroll = true;
            tblSliders.ColumnCount = 6;
            tblSliders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblSliders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblSliders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tblSliders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tblSliders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tblSliders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSliders.Controls.Add(lblSliderHeader1, 1, 0);
            tblSliders.Controls.Add(lblSliderHeader2, 2, 0);
            tblSliders.Controls.Add(lblSliderHeader3, 3, 0);
            tblSliders.Controls.Add(lblSliderHeader4, 4, 0);
            tblSliders.Controls.Add(lblSliderHeader5, 5, 0);
            tblSliders.Controls.Add(lblSlider1, 0, 1);
            tblSliders.Controls.Add(txtSliderName1, 1, 1);
            tblSliders.Controls.Add(cmbSliderType1, 2, 1);
            tblSliders.Controls.Add(cmbSliderParam1, 3, 1);
            tblSliders.Controls.Add(chkSliderInvert1, 4, 1);
            tblSliders.Controls.Add(pbSlider1, 5, 1);
            tblSliders.Controls.Add(lblSlider2, 0, 2);
            tblSliders.Controls.Add(txtSliderName2, 1, 2);
            tblSliders.Controls.Add(cmbSliderType2, 2, 2);
            tblSliders.Controls.Add(cmbSliderParam2, 3, 2);
            tblSliders.Controls.Add(chkSliderInvert2, 4, 2);
            tblSliders.Controls.Add(pbSlider2, 5, 2);
            tblSliders.Controls.Add(lblSlider3, 0, 3);
            tblSliders.Controls.Add(txtSliderName3, 1, 3);
            tblSliders.Controls.Add(cmbSliderType3, 2, 3);
            tblSliders.Controls.Add(cmbSliderParam3, 3, 3);
            tblSliders.Controls.Add(chkSliderInvert3, 4, 3);
            tblSliders.Controls.Add(pbSlider3, 5, 3);
            tblSliders.Controls.Add(lblSlider4, 0, 4);
            tblSliders.Controls.Add(txtSliderName4, 1, 4);
            tblSliders.Controls.Add(cmbSliderType4, 2, 4);
            tblSliders.Controls.Add(cmbSliderParam4, 3, 4);
            tblSliders.Controls.Add(chkSliderInvert4, 4, 4);
            tblSliders.Controls.Add(pbSlider4, 5, 4);
            tblSliders.Controls.Add(lblSlider5, 0, 5);
            tblSliders.Controls.Add(txtSliderName5, 1, 5);
            tblSliders.Controls.Add(cmbSliderType5, 2, 5);
            tblSliders.Controls.Add(cmbSliderParam5, 3, 5);
            tblSliders.Controls.Add(chkSliderInvert5, 4, 5);
            tblSliders.Controls.Add(pbSlider5, 5, 5);
            tblSliders.Dock = DockStyle.Fill;
            tblSliders.Location = new Point(3, 3);
            tblSliders.Name = "tblSliders";
            tblSliders.Padding = new Padding(10);
            tblSliders.RowCount = 6;
            tblSliders.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblSliders.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblSliders.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblSliders.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblSliders.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblSliders.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblSliders.Size = new Size(926, 426);
            tblSliders.TabIndex = 0;
            // 
            // lblSliderHeader1
            // 
            lblSliderHeader1.Anchor = AnchorStyles.Left;
            lblSliderHeader1.AutoSize = true;
            lblSliderHeader1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSliderHeader1.Location = new Point(93, 16);
            lblSliderHeader1.Name = "lblSliderHeader1";
            lblSliderHeader1.Size = new Size(53, 15);
            lblSliderHeader1.TabIndex = 1;
            lblSliderHeader1.Text = "Nombre";
            // 
            // lblSliderHeader2
            // 
            lblSliderHeader2.Anchor = AnchorStyles.Left;
            lblSliderHeader2.AutoSize = true;
            lblSliderHeader2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSliderHeader2.Location = new Point(243, 16);
            lblSliderHeader2.Name = "lblSliderHeader2";
            lblSliderHeader2.Size = new Size(50, 15);
            lblSliderHeader2.TabIndex = 2;
            lblSliderHeader2.Text = "Función";
            // 
            // lblSliderHeader3
            // 
            lblSliderHeader3.Anchor = AnchorStyles.Left;
            lblSliderHeader3.AutoSize = true;
            lblSliderHeader3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSliderHeader3.Location = new Point(423, 16);
            lblSliderHeader3.Name = "lblSliderHeader3";
            lblSliderHeader3.Size = new Size(133, 15);
            lblSliderHeader3.TabIndex = 3;
            lblSliderHeader3.Text = "Aplicación / dispositivo";
            // 
            // lblSliderHeader4
            // 
            lblSliderHeader4.Anchor = AnchorStyles.Left;
            lblSliderHeader4.AutoSize = true;
            lblSliderHeader4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSliderHeader4.Location = new Point(703, 16);
            lblSliderHeader4.Name = "lblSliderHeader4";
            lblSliderHeader4.Size = new Size(50, 15);
            lblSliderHeader4.TabIndex = 4;
            lblSliderHeader4.Text = "Invertir";
            // 
            // lblSliderHeader5
            // 
            lblSliderHeader5.Anchor = AnchorStyles.Left;
            lblSliderHeader5.AutoSize = true;
            lblSliderHeader5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSliderHeader5.Location = new Point(773, 16);
            lblSliderHeader5.Name = "lblSliderHeader5";
            lblSliderHeader5.Size = new Size(36, 15);
            lblSliderHeader5.TabIndex = 5;
            lblSliderHeader5.Text = "Nivel";
            // 
            // lblSlider1
            // 
            lblSlider1.Anchor = AnchorStyles.Left;
            lblSlider1.AutoSize = true;
            lblSlider1.Location = new Point(13, 47);
            lblSlider1.Name = "lblSlider1";
            lblSlider1.Size = new Size(45, 15);
            lblSlider1.TabIndex = 6;
            lblSlider1.Text = "Slider 1";
            // 
            // txtSliderName1
            // 
            txtSliderName1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSliderName1.Location = new Point(93, 43);
            txtSliderName1.Name = "txtSliderName1";
            txtSliderName1.Size = new Size(144, 23);
            txtSliderName1.TabIndex = 7;
            // 
            // cmbSliderType1
            // 
            cmbSliderType1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderType1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSliderType1.FormattingEnabled = true;
            cmbSliderType1.Location = new Point(243, 43);
            cmbSliderType1.Name = "cmbSliderType1";
            cmbSliderType1.Size = new Size(174, 23);
            cmbSliderType1.TabIndex = 8;
            cmbSliderType1.SelectedIndexChanged += cmbSliderType_SelectedIndexChanged;
            // 
            // cmbSliderParam1
            // 
            cmbSliderParam1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderParam1.FormattingEnabled = true;
            cmbSliderParam1.Location = new Point(423, 43);
            cmbSliderParam1.Name = "cmbSliderParam1";
            cmbSliderParam1.Size = new Size(274, 23);
            cmbSliderParam1.TabIndex = 9;
            cmbSliderParam1.DropDown += cmbSliderParam_DropDown;
            // 
            // chkSliderInvert1
            // 
            chkSliderInvert1.Anchor = AnchorStyles.Left;
            chkSliderInvert1.AutoSize = true;
            chkSliderInvert1.Location = new Point(703, 48);
            chkSliderInvert1.Name = "chkSliderInvert1";
            chkSliderInvert1.Size = new Size(15, 14);
            chkSliderInvert1.TabIndex = 10;
            chkSliderInvert1.UseVisualStyleBackColor = true;
            // 
            // pbSlider1
            // 
            pbSlider1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbSlider1.Location = new Point(773, 46);
            pbSlider1.Maximum = 1000;
            pbSlider1.Name = "pbSlider1";
            pbSlider1.Size = new Size(140, 18);
            pbSlider1.TabIndex = 11;
            // 
            // lblSlider2
            // 
            lblSlider2.Anchor = AnchorStyles.Left;
            lblSlider2.AutoSize = true;
            lblSlider2.Location = new Point(13, 81);
            lblSlider2.Name = "lblSlider2";
            lblSlider2.Size = new Size(45, 15);
            lblSlider2.TabIndex = 12;
            lblSlider2.Text = "Slider 2";
            // 
            // txtSliderName2
            // 
            txtSliderName2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSliderName2.Location = new Point(93, 77);
            txtSliderName2.Name = "txtSliderName2";
            txtSliderName2.Size = new Size(144, 23);
            txtSliderName2.TabIndex = 13;
            // 
            // cmbSliderType2
            // 
            cmbSliderType2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderType2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSliderType2.FormattingEnabled = true;
            cmbSliderType2.Location = new Point(243, 77);
            cmbSliderType2.Name = "cmbSliderType2";
            cmbSliderType2.Size = new Size(174, 23);
            cmbSliderType2.TabIndex = 14;
            cmbSliderType2.SelectedIndexChanged += cmbSliderType_SelectedIndexChanged;
            // 
            // cmbSliderParam2
            // 
            cmbSliderParam2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderParam2.FormattingEnabled = true;
            cmbSliderParam2.Location = new Point(423, 77);
            cmbSliderParam2.Name = "cmbSliderParam2";
            cmbSliderParam2.Size = new Size(274, 23);
            cmbSliderParam2.TabIndex = 15;
            cmbSliderParam2.DropDown += cmbSliderParam_DropDown;
            // 
            // chkSliderInvert2
            // 
            chkSliderInvert2.Anchor = AnchorStyles.Left;
            chkSliderInvert2.AutoSize = true;
            chkSliderInvert2.Location = new Point(703, 82);
            chkSliderInvert2.Name = "chkSliderInvert2";
            chkSliderInvert2.Size = new Size(15, 14);
            chkSliderInvert2.TabIndex = 16;
            chkSliderInvert2.UseVisualStyleBackColor = true;
            // 
            // pbSlider2
            // 
            pbSlider2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbSlider2.Location = new Point(773, 80);
            pbSlider2.Maximum = 1000;
            pbSlider2.Name = "pbSlider2";
            pbSlider2.Size = new Size(140, 18);
            pbSlider2.TabIndex = 17;
            // 
            // lblSlider3
            // 
            lblSlider3.Anchor = AnchorStyles.Left;
            lblSlider3.AutoSize = true;
            lblSlider3.Location = new Point(13, 115);
            lblSlider3.Name = "lblSlider3";
            lblSlider3.Size = new Size(45, 15);
            lblSlider3.TabIndex = 18;
            lblSlider3.Text = "Slider 3";
            // 
            // txtSliderName3
            // 
            txtSliderName3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSliderName3.Location = new Point(93, 111);
            txtSliderName3.Name = "txtSliderName3";
            txtSliderName3.Size = new Size(144, 23);
            txtSliderName3.TabIndex = 19;
            // 
            // cmbSliderType3
            // 
            cmbSliderType3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderType3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSliderType3.FormattingEnabled = true;
            cmbSliderType3.Location = new Point(243, 111);
            cmbSliderType3.Name = "cmbSliderType3";
            cmbSliderType3.Size = new Size(174, 23);
            cmbSliderType3.TabIndex = 20;
            cmbSliderType3.SelectedIndexChanged += cmbSliderType_SelectedIndexChanged;
            // 
            // cmbSliderParam3
            // 
            cmbSliderParam3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderParam3.FormattingEnabled = true;
            cmbSliderParam3.Location = new Point(423, 111);
            cmbSliderParam3.Name = "cmbSliderParam3";
            cmbSliderParam3.Size = new Size(274, 23);
            cmbSliderParam3.TabIndex = 21;
            cmbSliderParam3.DropDown += cmbSliderParam_DropDown;
            // 
            // chkSliderInvert3
            // 
            chkSliderInvert3.Anchor = AnchorStyles.Left;
            chkSliderInvert3.AutoSize = true;
            chkSliderInvert3.Location = new Point(703, 116);
            chkSliderInvert3.Name = "chkSliderInvert3";
            chkSliderInvert3.Size = new Size(15, 14);
            chkSliderInvert3.TabIndex = 22;
            chkSliderInvert3.UseVisualStyleBackColor = true;
            // 
            // pbSlider3
            // 
            pbSlider3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbSlider3.Location = new Point(773, 114);
            pbSlider3.Maximum = 1000;
            pbSlider3.Name = "pbSlider3";
            pbSlider3.Size = new Size(140, 18);
            pbSlider3.TabIndex = 23;
            // 
            // lblSlider4
            // 
            lblSlider4.Anchor = AnchorStyles.Left;
            lblSlider4.AutoSize = true;
            lblSlider4.Location = new Point(13, 149);
            lblSlider4.Name = "lblSlider4";
            lblSlider4.Size = new Size(45, 15);
            lblSlider4.TabIndex = 24;
            lblSlider4.Text = "Slider 4";
            // 
            // txtSliderName4
            // 
            txtSliderName4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSliderName4.Location = new Point(93, 145);
            txtSliderName4.Name = "txtSliderName4";
            txtSliderName4.Size = new Size(144, 23);
            txtSliderName4.TabIndex = 25;
            // 
            // cmbSliderType4
            // 
            cmbSliderType4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderType4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSliderType4.FormattingEnabled = true;
            cmbSliderType4.Location = new Point(243, 145);
            cmbSliderType4.Name = "cmbSliderType4";
            cmbSliderType4.Size = new Size(174, 23);
            cmbSliderType4.TabIndex = 26;
            cmbSliderType4.SelectedIndexChanged += cmbSliderType_SelectedIndexChanged;
            // 
            // cmbSliderParam4
            // 
            cmbSliderParam4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderParam4.FormattingEnabled = true;
            cmbSliderParam4.Location = new Point(423, 145);
            cmbSliderParam4.Name = "cmbSliderParam4";
            cmbSliderParam4.Size = new Size(274, 23);
            cmbSliderParam4.TabIndex = 27;
            cmbSliderParam4.DropDown += cmbSliderParam_DropDown;
            // 
            // chkSliderInvert4
            // 
            chkSliderInvert4.Anchor = AnchorStyles.Left;
            chkSliderInvert4.AutoSize = true;
            chkSliderInvert4.Location = new Point(703, 150);
            chkSliderInvert4.Name = "chkSliderInvert4";
            chkSliderInvert4.Size = new Size(15, 14);
            chkSliderInvert4.TabIndex = 28;
            chkSliderInvert4.UseVisualStyleBackColor = true;
            // 
            // pbSlider4
            // 
            pbSlider4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbSlider4.Location = new Point(773, 148);
            pbSlider4.Maximum = 1000;
            pbSlider4.Name = "pbSlider4";
            pbSlider4.Size = new Size(140, 18);
            pbSlider4.TabIndex = 29;
            // 
            // lblSlider5
            // 
            lblSlider5.Anchor = AnchorStyles.Left;
            lblSlider5.AutoSize = true;
            lblSlider5.Location = new Point(13, 287);
            lblSlider5.Name = "lblSlider5";
            lblSlider5.Size = new Size(45, 15);
            lblSlider5.TabIndex = 30;
            lblSlider5.Text = "Slider 5";
            // 
            // txtSliderName5
            // 
            txtSliderName5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSliderName5.Location = new Point(93, 283);
            txtSliderName5.Name = "txtSliderName5";
            txtSliderName5.Size = new Size(144, 23);
            txtSliderName5.TabIndex = 31;
            // 
            // cmbSliderType5
            // 
            cmbSliderType5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderType5.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSliderType5.FormattingEnabled = true;
            cmbSliderType5.Location = new Point(243, 283);
            cmbSliderType5.Name = "cmbSliderType5";
            cmbSliderType5.Size = new Size(174, 23);
            cmbSliderType5.TabIndex = 32;
            cmbSliderType5.SelectedIndexChanged += cmbSliderType_SelectedIndexChanged;
            // 
            // cmbSliderParam5
            // 
            cmbSliderParam5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSliderParam5.FormattingEnabled = true;
            cmbSliderParam5.Location = new Point(423, 283);
            cmbSliderParam5.Name = "cmbSliderParam5";
            cmbSliderParam5.Size = new Size(274, 23);
            cmbSliderParam5.TabIndex = 33;
            cmbSliderParam5.DropDown += cmbSliderParam_DropDown;
            // 
            // chkSliderInvert5
            // 
            chkSliderInvert5.Anchor = AnchorStyles.Left;
            chkSliderInvert5.AutoSize = true;
            chkSliderInvert5.Location = new Point(703, 288);
            chkSliderInvert5.Name = "chkSliderInvert5";
            chkSliderInvert5.Size = new Size(15, 14);
            chkSliderInvert5.TabIndex = 34;
            chkSliderInvert5.UseVisualStyleBackColor = true;
            // 
            // pbSlider5
            // 
            pbSlider5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pbSlider5.Location = new Point(773, 286);
            pbSlider5.Maximum = 1000;
            pbSlider5.Name = "pbSlider5";
            pbSlider5.Size = new Size(140, 18);
            pbSlider5.TabIndex = 35;
            // 
            // lblSlidersHint
            // 
            lblSlidersHint.Dock = DockStyle.Bottom;
            lblSlidersHint.ForeColor = SystemColors.GrayText;
            lblSlidersHint.Location = new Point(3, 429);
            lblSlidersHint.Name = "lblSlidersHint";
            lblSlidersHint.Padding = new Padding(10, 4, 10, 0);
            lblSlidersHint.Size = new Size(926, 60);
            lblSlidersHint.TabIndex = 36;
            lblSlidersHint.Text = resources.GetString("lblSlidersHint.Text");
            // 
            // tabSliders
            // 
            tabSliders.Controls.Add(tblSliders);
            tabSliders.Controls.Add(lblSlidersHint);
            tabSliders.Location = new Point(4, 24);
            tabSliders.Name = "tabSliders";
            tabSliders.Padding = new Padding(3);
            tabSliders.Size = new Size(932, 492);
            tabSliders.TabIndex = 37;
            tabSliders.Text = "Sliders";
            tabSliders.UseVisualStyleBackColor = true;
            // 
            // tblButtons
            // 
            tblButtons.AutoScroll = true;
            tblButtons.ColumnCount = 6;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblButtons.Controls.Add(lblButtonHeader1, 1, 0);
            tblButtons.Controls.Add(lblButtonHeader2, 2, 0);
            tblButtons.Controls.Add(lblButtonHeader3, 3, 0);
            tblButtons.Controls.Add(lblBtn1, 0, 1);
            tblButtons.Controls.Add(txtBtnName1, 1, 1);
            tblButtons.Controls.Add(cmbBtnAction1, 2, 1);
            tblButtons.Controls.Add(cmbBtnParam1, 3, 1);
            tblButtons.Controls.Add(btnBrowse1, 4, 1);
            tblButtons.Controls.Add(btnTest1, 5, 1);
            tblButtons.Controls.Add(lblBtn2, 0, 2);
            tblButtons.Controls.Add(txtBtnName2, 1, 2);
            tblButtons.Controls.Add(cmbBtnAction2, 2, 2);
            tblButtons.Controls.Add(cmbBtnParam2, 3, 2);
            tblButtons.Controls.Add(btnBrowse2, 4, 2);
            tblButtons.Controls.Add(btnTest2, 5, 2);
            tblButtons.Controls.Add(lblBtn3, 0, 3);
            tblButtons.Controls.Add(txtBtnName3, 1, 3);
            tblButtons.Controls.Add(cmbBtnAction3, 2, 3);
            tblButtons.Controls.Add(cmbBtnParam3, 3, 3);
            tblButtons.Controls.Add(btnBrowse3, 4, 3);
            tblButtons.Controls.Add(btnTest3, 5, 3);
            tblButtons.Controls.Add(lblBtn4, 0, 4);
            tblButtons.Controls.Add(txtBtnName4, 1, 4);
            tblButtons.Controls.Add(cmbBtnAction4, 2, 4);
            tblButtons.Controls.Add(cmbBtnParam4, 3, 4);
            tblButtons.Controls.Add(btnBrowse4, 4, 4);
            tblButtons.Controls.Add(btnTest4, 5, 4);
            tblButtons.Controls.Add(lblBtn5, 0, 5);
            tblButtons.Controls.Add(txtBtnName5, 1, 5);
            tblButtons.Controls.Add(cmbBtnAction5, 2, 5);
            tblButtons.Controls.Add(cmbBtnParam5, 3, 5);
            tblButtons.Controls.Add(btnBrowse5, 4, 5);
            tblButtons.Controls.Add(btnTest5, 5, 5);
            tblButtons.Controls.Add(lblBtn6, 0, 6);
            tblButtons.Controls.Add(txtBtnName6, 1, 6);
            tblButtons.Controls.Add(cmbBtnAction6, 2, 6);
            tblButtons.Controls.Add(cmbBtnParam6, 3, 6);
            tblButtons.Controls.Add(btnBrowse6, 4, 6);
            tblButtons.Controls.Add(btnTest6, 5, 6);
            tblButtons.Controls.Add(lblBtn7, 0, 7);
            tblButtons.Controls.Add(txtBtnName7, 1, 7);
            tblButtons.Controls.Add(cmbBtnAction7, 2, 7);
            tblButtons.Controls.Add(cmbBtnParam7, 3, 7);
            tblButtons.Controls.Add(btnBrowse7, 4, 7);
            tblButtons.Controls.Add(btnTest7, 5, 7);
            tblButtons.Controls.Add(lblBtn8, 0, 8);
            tblButtons.Controls.Add(txtBtnName8, 1, 8);
            tblButtons.Controls.Add(cmbBtnAction8, 2, 8);
            tblButtons.Controls.Add(cmbBtnParam8, 3, 8);
            tblButtons.Controls.Add(btnBrowse8, 4, 8);
            tblButtons.Controls.Add(btnTest8, 5, 8);
            tblButtons.Controls.Add(lblBtn9, 0, 9);
            tblButtons.Controls.Add(txtBtnName9, 1, 9);
            tblButtons.Controls.Add(cmbBtnAction9, 2, 9);
            tblButtons.Controls.Add(cmbBtnParam9, 3, 9);
            tblButtons.Controls.Add(btnBrowse9, 4, 9);
            tblButtons.Controls.Add(btnTest9, 5, 9);
            tblButtons.Controls.Add(lblBtn10, 0, 10);
            tblButtons.Controls.Add(txtBtnName10, 1, 10);
            tblButtons.Controls.Add(cmbBtnAction10, 2, 10);
            tblButtons.Controls.Add(cmbBtnParam10, 3, 10);
            tblButtons.Controls.Add(btnBrowse10, 4, 10);
            tblButtons.Controls.Add(btnTest10, 5, 10);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.Padding = new Padding(10);
            tblButtons.RowCount = 11;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblButtons.Size = new Size(926, 390);
            tblButtons.TabIndex = 38;
            // 
            // lblButtonHeader1
            // 
            lblButtonHeader1.Anchor = AnchorStyles.Left;
            lblButtonHeader1.AutoSize = true;
            lblButtonHeader1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblButtonHeader1.Location = new Point(93, 16);
            lblButtonHeader1.Name = "lblButtonHeader1";
            lblButtonHeader1.Size = new Size(53, 15);
            lblButtonHeader1.TabIndex = 39;
            lblButtonHeader1.Text = "Nombre";
            // 
            // lblButtonHeader2
            // 
            lblButtonHeader2.Anchor = AnchorStyles.Left;
            lblButtonHeader2.AutoSize = true;
            lblButtonHeader2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblButtonHeader2.Location = new Point(253, 16);
            lblButtonHeader2.Name = "lblButtonHeader2";
            lblButtonHeader2.Size = new Size(44, 15);
            lblButtonHeader2.TabIndex = 40;
            lblButtonHeader2.Text = "Acción";
            // 
            // lblButtonHeader3
            // 
            lblButtonHeader3.Anchor = AnchorStyles.Left;
            lblButtonHeader3.AutoSize = true;
            lblButtonHeader3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblButtonHeader3.Location = new Point(483, 16);
            lblButtonHeader3.Name = "lblButtonHeader3";
            lblButtonHeader3.Size = new Size(66, 15);
            lblButtonHeader3.TabIndex = 41;
            lblButtonHeader3.Text = "Parámetro";
            // 
            // lblBtn1
            // 
            lblBtn1.Dock = DockStyle.Fill;
            lblBtn1.Location = new Point(10, 40);
            lblBtn1.Margin = new Padding(0, 2, 0, 2);
            lblBtn1.Name = "lblBtn1";
            lblBtn1.Size = new Size(80, 30);
            lblBtn1.TabIndex = 42;
            lblBtn1.Text = "Botón 1";
            lblBtn1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName1
            // 
            txtBtnName1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName1.Location = new Point(93, 43);
            txtBtnName1.Name = "txtBtnName1";
            txtBtnName1.Size = new Size(154, 23);
            txtBtnName1.TabIndex = 43;
            // 
            // cmbBtnAction1
            // 
            cmbBtnAction1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction1.FormattingEnabled = true;
            cmbBtnAction1.Location = new Point(253, 43);
            cmbBtnAction1.Name = "cmbBtnAction1";
            cmbBtnAction1.Size = new Size(224, 23);
            cmbBtnAction1.TabIndex = 44;
            cmbBtnAction1.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam1
            // 
            cmbBtnParam1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam1.FormattingEnabled = true;
            cmbBtnParam1.Location = new Point(483, 43);
            cmbBtnParam1.Name = "cmbBtnParam1";
            cmbBtnParam1.Size = new Size(310, 23);
            cmbBtnParam1.TabIndex = 45;
            cmbBtnParam1.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse1
            // 
            btnBrowse1.Anchor = AnchorStyles.Left;
            btnBrowse1.Location = new Point(799, 42);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(32, 25);
            btnBrowse1.TabIndex = 46;
            btnBrowse1.Text = "…";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse_Click;
            // 
            // btnTest1
            // 
            btnTest1.Anchor = AnchorStyles.Left;
            btnTest1.Location = new Point(839, 42);
            btnTest1.Name = "btnTest1";
            btnTest1.Size = new Size(70, 25);
            btnTest1.TabIndex = 47;
            btnTest1.Text = "Probar";
            btnTest1.UseVisualStyleBackColor = true;
            btnTest1.Click += btnTest_Click;
            // 
            // lblBtn2
            // 
            lblBtn2.Dock = DockStyle.Fill;
            lblBtn2.Location = new Point(10, 74);
            lblBtn2.Margin = new Padding(0, 2, 0, 2);
            lblBtn2.Name = "lblBtn2";
            lblBtn2.Size = new Size(80, 30);
            lblBtn2.TabIndex = 48;
            lblBtn2.Text = "Botón 2";
            lblBtn2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName2
            // 
            txtBtnName2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName2.Location = new Point(93, 77);
            txtBtnName2.Name = "txtBtnName2";
            txtBtnName2.Size = new Size(154, 23);
            txtBtnName2.TabIndex = 49;
            // 
            // cmbBtnAction2
            // 
            cmbBtnAction2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction2.FormattingEnabled = true;
            cmbBtnAction2.Location = new Point(253, 77);
            cmbBtnAction2.Name = "cmbBtnAction2";
            cmbBtnAction2.Size = new Size(224, 23);
            cmbBtnAction2.TabIndex = 50;
            cmbBtnAction2.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam2
            // 
            cmbBtnParam2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam2.FormattingEnabled = true;
            cmbBtnParam2.Location = new Point(483, 77);
            cmbBtnParam2.Name = "cmbBtnParam2";
            cmbBtnParam2.Size = new Size(310, 23);
            cmbBtnParam2.TabIndex = 51;
            cmbBtnParam2.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Anchor = AnchorStyles.Left;
            btnBrowse2.Location = new Point(799, 76);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(32, 25);
            btnBrowse2.TabIndex = 52;
            btnBrowse2.Text = "…";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse_Click;
            // 
            // btnTest2
            // 
            btnTest2.Anchor = AnchorStyles.Left;
            btnTest2.Location = new Point(839, 76);
            btnTest2.Name = "btnTest2";
            btnTest2.Size = new Size(70, 25);
            btnTest2.TabIndex = 53;
            btnTest2.Text = "Probar";
            btnTest2.UseVisualStyleBackColor = true;
            btnTest2.Click += btnTest_Click;
            // 
            // lblBtn3
            // 
            lblBtn3.Dock = DockStyle.Fill;
            lblBtn3.Location = new Point(10, 108);
            lblBtn3.Margin = new Padding(0, 2, 0, 2);
            lblBtn3.Name = "lblBtn3";
            lblBtn3.Size = new Size(80, 30);
            lblBtn3.TabIndex = 54;
            lblBtn3.Text = "Botón 3";
            lblBtn3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName3
            // 
            txtBtnName3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName3.Location = new Point(93, 111);
            txtBtnName3.Name = "txtBtnName3";
            txtBtnName3.Size = new Size(154, 23);
            txtBtnName3.TabIndex = 55;
            // 
            // cmbBtnAction3
            // 
            cmbBtnAction3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction3.FormattingEnabled = true;
            cmbBtnAction3.Location = new Point(253, 111);
            cmbBtnAction3.Name = "cmbBtnAction3";
            cmbBtnAction3.Size = new Size(224, 23);
            cmbBtnAction3.TabIndex = 56;
            cmbBtnAction3.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam3
            // 
            cmbBtnParam3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam3.FormattingEnabled = true;
            cmbBtnParam3.Location = new Point(483, 111);
            cmbBtnParam3.Name = "cmbBtnParam3";
            cmbBtnParam3.Size = new Size(310, 23);
            cmbBtnParam3.TabIndex = 57;
            cmbBtnParam3.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse3
            // 
            btnBrowse3.Anchor = AnchorStyles.Left;
            btnBrowse3.Location = new Point(799, 110);
            btnBrowse3.Name = "btnBrowse3";
            btnBrowse3.Size = new Size(32, 25);
            btnBrowse3.TabIndex = 58;
            btnBrowse3.Text = "…";
            btnBrowse3.UseVisualStyleBackColor = true;
            btnBrowse3.Click += btnBrowse_Click;
            // 
            // btnTest3
            // 
            btnTest3.Anchor = AnchorStyles.Left;
            btnTest3.Location = new Point(839, 110);
            btnTest3.Name = "btnTest3";
            btnTest3.Size = new Size(70, 25);
            btnTest3.TabIndex = 59;
            btnTest3.Text = "Probar";
            btnTest3.UseVisualStyleBackColor = true;
            btnTest3.Click += btnTest_Click;
            // 
            // lblBtn4
            // 
            lblBtn4.Dock = DockStyle.Fill;
            lblBtn4.Location = new Point(10, 142);
            lblBtn4.Margin = new Padding(0, 2, 0, 2);
            lblBtn4.Name = "lblBtn4";
            lblBtn4.Size = new Size(80, 30);
            lblBtn4.TabIndex = 60;
            lblBtn4.Text = "Botón 4";
            lblBtn4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName4
            // 
            txtBtnName4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName4.Location = new Point(93, 145);
            txtBtnName4.Name = "txtBtnName4";
            txtBtnName4.Size = new Size(154, 23);
            txtBtnName4.TabIndex = 61;
            // 
            // cmbBtnAction4
            // 
            cmbBtnAction4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction4.FormattingEnabled = true;
            cmbBtnAction4.Location = new Point(253, 145);
            cmbBtnAction4.Name = "cmbBtnAction4";
            cmbBtnAction4.Size = new Size(224, 23);
            cmbBtnAction4.TabIndex = 62;
            cmbBtnAction4.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam4
            // 
            cmbBtnParam4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam4.FormattingEnabled = true;
            cmbBtnParam4.Location = new Point(483, 145);
            cmbBtnParam4.Name = "cmbBtnParam4";
            cmbBtnParam4.Size = new Size(310, 23);
            cmbBtnParam4.TabIndex = 63;
            cmbBtnParam4.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse4
            // 
            btnBrowse4.Anchor = AnchorStyles.Left;
            btnBrowse4.Location = new Point(799, 144);
            btnBrowse4.Name = "btnBrowse4";
            btnBrowse4.Size = new Size(32, 25);
            btnBrowse4.TabIndex = 64;
            btnBrowse4.Text = "…";
            btnBrowse4.UseVisualStyleBackColor = true;
            btnBrowse4.Click += btnBrowse_Click;
            // 
            // btnTest4
            // 
            btnTest4.Anchor = AnchorStyles.Left;
            btnTest4.Location = new Point(839, 144);
            btnTest4.Name = "btnTest4";
            btnTest4.Size = new Size(70, 25);
            btnTest4.TabIndex = 65;
            btnTest4.Text = "Probar";
            btnTest4.UseVisualStyleBackColor = true;
            btnTest4.Click += btnTest_Click;
            // 
            // lblBtn5
            // 
            lblBtn5.Dock = DockStyle.Fill;
            lblBtn5.Location = new Point(10, 176);
            lblBtn5.Margin = new Padding(0, 2, 0, 2);
            lblBtn5.Name = "lblBtn5";
            lblBtn5.Size = new Size(80, 30);
            lblBtn5.TabIndex = 66;
            lblBtn5.Text = "Botón 5";
            lblBtn5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName5
            // 
            txtBtnName5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName5.Location = new Point(93, 179);
            txtBtnName5.Name = "txtBtnName5";
            txtBtnName5.Size = new Size(154, 23);
            txtBtnName5.TabIndex = 67;
            // 
            // cmbBtnAction5
            // 
            cmbBtnAction5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction5.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction5.FormattingEnabled = true;
            cmbBtnAction5.Location = new Point(253, 179);
            cmbBtnAction5.Name = "cmbBtnAction5";
            cmbBtnAction5.Size = new Size(224, 23);
            cmbBtnAction5.TabIndex = 68;
            cmbBtnAction5.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam5
            // 
            cmbBtnParam5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam5.FormattingEnabled = true;
            cmbBtnParam5.Location = new Point(483, 179);
            cmbBtnParam5.Name = "cmbBtnParam5";
            cmbBtnParam5.Size = new Size(310, 23);
            cmbBtnParam5.TabIndex = 69;
            cmbBtnParam5.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse5
            // 
            btnBrowse5.Anchor = AnchorStyles.Left;
            btnBrowse5.Location = new Point(799, 178);
            btnBrowse5.Name = "btnBrowse5";
            btnBrowse5.Size = new Size(32, 25);
            btnBrowse5.TabIndex = 70;
            btnBrowse5.Text = "…";
            btnBrowse5.UseVisualStyleBackColor = true;
            btnBrowse5.Click += btnBrowse_Click;
            // 
            // btnTest5
            // 
            btnTest5.Anchor = AnchorStyles.Left;
            btnTest5.Location = new Point(839, 178);
            btnTest5.Name = "btnTest5";
            btnTest5.Size = new Size(70, 25);
            btnTest5.TabIndex = 71;
            btnTest5.Text = "Probar";
            btnTest5.UseVisualStyleBackColor = true;
            btnTest5.Click += btnTest_Click;
            // 
            // lblBtn6
            // 
            lblBtn6.Dock = DockStyle.Fill;
            lblBtn6.Location = new Point(10, 210);
            lblBtn6.Margin = new Padding(0, 2, 0, 2);
            lblBtn6.Name = "lblBtn6";
            lblBtn6.Size = new Size(80, 30);
            lblBtn6.TabIndex = 72;
            lblBtn6.Text = "Botón 6";
            lblBtn6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName6
            // 
            txtBtnName6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName6.Location = new Point(93, 213);
            txtBtnName6.Name = "txtBtnName6";
            txtBtnName6.Size = new Size(154, 23);
            txtBtnName6.TabIndex = 73;
            // 
            // cmbBtnAction6
            // 
            cmbBtnAction6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction6.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction6.FormattingEnabled = true;
            cmbBtnAction6.Location = new Point(253, 213);
            cmbBtnAction6.Name = "cmbBtnAction6";
            cmbBtnAction6.Size = new Size(224, 23);
            cmbBtnAction6.TabIndex = 74;
            cmbBtnAction6.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam6
            // 
            cmbBtnParam6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam6.FormattingEnabled = true;
            cmbBtnParam6.Location = new Point(483, 213);
            cmbBtnParam6.Name = "cmbBtnParam6";
            cmbBtnParam6.Size = new Size(310, 23);
            cmbBtnParam6.TabIndex = 75;
            cmbBtnParam6.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse6
            // 
            btnBrowse6.Anchor = AnchorStyles.Left;
            btnBrowse6.Location = new Point(799, 212);
            btnBrowse6.Name = "btnBrowse6";
            btnBrowse6.Size = new Size(32, 25);
            btnBrowse6.TabIndex = 76;
            btnBrowse6.Text = "…";
            btnBrowse6.UseVisualStyleBackColor = true;
            btnBrowse6.Click += btnBrowse_Click;
            // 
            // btnTest6
            // 
            btnTest6.Anchor = AnchorStyles.Left;
            btnTest6.Location = new Point(839, 212);
            btnTest6.Name = "btnTest6";
            btnTest6.Size = new Size(70, 25);
            btnTest6.TabIndex = 77;
            btnTest6.Text = "Probar";
            btnTest6.UseVisualStyleBackColor = true;
            btnTest6.Click += btnTest_Click;
            // 
            // lblBtn7
            // 
            lblBtn7.Dock = DockStyle.Fill;
            lblBtn7.Location = new Point(10, 244);
            lblBtn7.Margin = new Padding(0, 2, 0, 2);
            lblBtn7.Name = "lblBtn7";
            lblBtn7.Size = new Size(80, 30);
            lblBtn7.TabIndex = 78;
            lblBtn7.Text = "Botón 7";
            lblBtn7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName7
            // 
            txtBtnName7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName7.Location = new Point(93, 247);
            txtBtnName7.Name = "txtBtnName7";
            txtBtnName7.Size = new Size(154, 23);
            txtBtnName7.TabIndex = 79;
            // 
            // cmbBtnAction7
            // 
            cmbBtnAction7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction7.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction7.FormattingEnabled = true;
            cmbBtnAction7.Location = new Point(253, 247);
            cmbBtnAction7.Name = "cmbBtnAction7";
            cmbBtnAction7.Size = new Size(224, 23);
            cmbBtnAction7.TabIndex = 80;
            cmbBtnAction7.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam7
            // 
            cmbBtnParam7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam7.FormattingEnabled = true;
            cmbBtnParam7.Location = new Point(483, 247);
            cmbBtnParam7.Name = "cmbBtnParam7";
            cmbBtnParam7.Size = new Size(310, 23);
            cmbBtnParam7.TabIndex = 81;
            cmbBtnParam7.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse7
            // 
            btnBrowse7.Anchor = AnchorStyles.Left;
            btnBrowse7.Location = new Point(799, 246);
            btnBrowse7.Name = "btnBrowse7";
            btnBrowse7.Size = new Size(32, 25);
            btnBrowse7.TabIndex = 82;
            btnBrowse7.Text = "…";
            btnBrowse7.UseVisualStyleBackColor = true;
            btnBrowse7.Click += btnBrowse_Click;
            // 
            // btnTest7
            // 
            btnTest7.Anchor = AnchorStyles.Left;
            btnTest7.Location = new Point(839, 246);
            btnTest7.Name = "btnTest7";
            btnTest7.Size = new Size(70, 25);
            btnTest7.TabIndex = 83;
            btnTest7.Text = "Probar";
            btnTest7.UseVisualStyleBackColor = true;
            btnTest7.Click += btnTest_Click;
            // 
            // lblBtn8
            // 
            lblBtn8.Dock = DockStyle.Fill;
            lblBtn8.Location = new Point(10, 278);
            lblBtn8.Margin = new Padding(0, 2, 0, 2);
            lblBtn8.Name = "lblBtn8";
            lblBtn8.Size = new Size(80, 30);
            lblBtn8.TabIndex = 84;
            lblBtn8.Text = "Botón 8";
            lblBtn8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName8
            // 
            txtBtnName8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName8.Location = new Point(93, 281);
            txtBtnName8.Name = "txtBtnName8";
            txtBtnName8.Size = new Size(154, 23);
            txtBtnName8.TabIndex = 85;
            // 
            // cmbBtnAction8
            // 
            cmbBtnAction8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction8.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction8.FormattingEnabled = true;
            cmbBtnAction8.Location = new Point(253, 281);
            cmbBtnAction8.Name = "cmbBtnAction8";
            cmbBtnAction8.Size = new Size(224, 23);
            cmbBtnAction8.TabIndex = 86;
            cmbBtnAction8.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam8
            // 
            cmbBtnParam8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam8.FormattingEnabled = true;
            cmbBtnParam8.Location = new Point(483, 281);
            cmbBtnParam8.Name = "cmbBtnParam8";
            cmbBtnParam8.Size = new Size(310, 23);
            cmbBtnParam8.TabIndex = 87;
            cmbBtnParam8.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse8
            // 
            btnBrowse8.Anchor = AnchorStyles.Left;
            btnBrowse8.Location = new Point(799, 280);
            btnBrowse8.Name = "btnBrowse8";
            btnBrowse8.Size = new Size(32, 25);
            btnBrowse8.TabIndex = 88;
            btnBrowse8.Text = "…";
            btnBrowse8.UseVisualStyleBackColor = true;
            btnBrowse8.Click += btnBrowse_Click;
            // 
            // btnTest8
            // 
            btnTest8.Anchor = AnchorStyles.Left;
            btnTest8.Location = new Point(839, 280);
            btnTest8.Name = "btnTest8";
            btnTest8.Size = new Size(70, 25);
            btnTest8.TabIndex = 89;
            btnTest8.Text = "Probar";
            btnTest8.UseVisualStyleBackColor = true;
            btnTest8.Click += btnTest_Click;
            // 
            // lblBtn9
            // 
            lblBtn9.Dock = DockStyle.Fill;
            lblBtn9.Location = new Point(10, 312);
            lblBtn9.Margin = new Padding(0, 2, 0, 2);
            lblBtn9.Name = "lblBtn9";
            lblBtn9.Size = new Size(80, 30);
            lblBtn9.TabIndex = 90;
            lblBtn9.Text = "Botón 9";
            lblBtn9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName9
            // 
            txtBtnName9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName9.Location = new Point(93, 315);
            txtBtnName9.Name = "txtBtnName9";
            txtBtnName9.Size = new Size(154, 23);
            txtBtnName9.TabIndex = 91;
            // 
            // cmbBtnAction9
            // 
            cmbBtnAction9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction9.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction9.FormattingEnabled = true;
            cmbBtnAction9.Location = new Point(253, 315);
            cmbBtnAction9.Name = "cmbBtnAction9";
            cmbBtnAction9.Size = new Size(224, 23);
            cmbBtnAction9.TabIndex = 92;
            cmbBtnAction9.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam9
            // 
            cmbBtnParam9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam9.FormattingEnabled = true;
            cmbBtnParam9.Location = new Point(483, 315);
            cmbBtnParam9.Name = "cmbBtnParam9";
            cmbBtnParam9.Size = new Size(310, 23);
            cmbBtnParam9.TabIndex = 93;
            cmbBtnParam9.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse9
            // 
            btnBrowse9.Anchor = AnchorStyles.Left;
            btnBrowse9.Location = new Point(799, 314);
            btnBrowse9.Name = "btnBrowse9";
            btnBrowse9.Size = new Size(32, 25);
            btnBrowse9.TabIndex = 94;
            btnBrowse9.Text = "…";
            btnBrowse9.UseVisualStyleBackColor = true;
            btnBrowse9.Click += btnBrowse_Click;
            // 
            // btnTest9
            // 
            btnTest9.Anchor = AnchorStyles.Left;
            btnTest9.Location = new Point(839, 314);
            btnTest9.Name = "btnTest9";
            btnTest9.Size = new Size(70, 25);
            btnTest9.TabIndex = 95;
            btnTest9.Text = "Probar";
            btnTest9.UseVisualStyleBackColor = true;
            btnTest9.Click += btnTest_Click;
            // 
            // lblBtn10
            // 
            lblBtn10.Dock = DockStyle.Fill;
            lblBtn10.Location = new Point(10, 346);
            lblBtn10.Margin = new Padding(0, 2, 0, 2);
            lblBtn10.Name = "lblBtn10";
            lblBtn10.Size = new Size(80, 32);
            lblBtn10.TabIndex = 96;
            lblBtn10.Text = "Botón 10";
            lblBtn10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBtnName10
            // 
            txtBtnName10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBtnName10.Location = new Point(93, 350);
            txtBtnName10.Name = "txtBtnName10";
            txtBtnName10.Size = new Size(154, 23);
            txtBtnName10.TabIndex = 97;
            // 
            // cmbBtnAction10
            // 
            cmbBtnAction10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnAction10.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBtnAction10.FormattingEnabled = true;
            cmbBtnAction10.Location = new Point(253, 350);
            cmbBtnAction10.Name = "cmbBtnAction10";
            cmbBtnAction10.Size = new Size(224, 23);
            cmbBtnAction10.TabIndex = 98;
            cmbBtnAction10.SelectedIndexChanged += cmbBtnAction_SelectedIndexChanged;
            // 
            // cmbBtnParam10
            // 
            cmbBtnParam10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBtnParam10.FormattingEnabled = true;
            cmbBtnParam10.Location = new Point(483, 350);
            cmbBtnParam10.Name = "cmbBtnParam10";
            cmbBtnParam10.Size = new Size(310, 23);
            cmbBtnParam10.TabIndex = 99;
            cmbBtnParam10.DropDown += cmbBtnParam_DropDown;
            // 
            // btnBrowse10
            // 
            btnBrowse10.Anchor = AnchorStyles.Left;
            btnBrowse10.Location = new Point(799, 349);
            btnBrowse10.Name = "btnBrowse10";
            btnBrowse10.Size = new Size(32, 25);
            btnBrowse10.TabIndex = 100;
            btnBrowse10.Text = "…";
            btnBrowse10.UseVisualStyleBackColor = true;
            btnBrowse10.Click += btnBrowse_Click;
            // 
            // btnTest10
            // 
            btnTest10.Anchor = AnchorStyles.Left;
            btnTest10.Location = new Point(839, 349);
            btnTest10.Name = "btnTest10";
            btnTest10.Size = new Size(70, 25);
            btnTest10.TabIndex = 101;
            btnTest10.Text = "Probar";
            btnTest10.UseVisualStyleBackColor = true;
            btnTest10.Click += btnTest_Click;
            // 
            // lblButtonsHint
            // 
            lblButtonsHint.Dock = DockStyle.Bottom;
            lblButtonsHint.ForeColor = SystemColors.GrayText;
            lblButtonsHint.Location = new Point(3, 393);
            lblButtonsHint.Name = "lblButtonsHint";
            lblButtonsHint.Padding = new Padding(10, 4, 10, 0);
            lblButtonsHint.Size = new Size(926, 96);
            lblButtonsHint.TabIndex = 102;
            lblButtonsHint.Text = resources.GetString("lblButtonsHint.Text");
            // 
            // tabButtons
            // 
            tabButtons.Controls.Add(tblButtons);
            tabButtons.Controls.Add(lblButtonsHint);
            tabButtons.Location = new Point(4, 24);
            tabButtons.Name = "tabButtons";
            tabButtons.Padding = new Padding(3);
            tabButtons.Size = new Size(932, 492);
            tabButtons.TabIndex = 103;
            tabButtons.Text = "Botones";
            tabButtons.UseVisualStyleBackColor = true;
            // 
            // tblLeds
            // 
            tblLeds.AutoScroll = true;
            tblLeds.ColumnCount = 2;
            tblLeds.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tblLeds.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLeds.Controls.Add(lblLedMode, 0, 0);
            tblLeds.Controls.Add(cmbLedMode, 1, 0);
            tblLeds.Controls.Add(lblLedSpeed, 0, 1);
            tblLeds.Controls.Add(flowLedSpeed, 1, 1);
            tblLeds.Controls.Add(lblLedColor, 0, 2);
            tblLeds.Controls.Add(flowLedColor, 1, 2);
            tblLeds.Dock = DockStyle.Fill;
            tblLeds.Location = new Point(3, 3);
            tblLeds.Name = "tblLeds";
            tblLeds.Padding = new Padding(10);
            tblLeds.RowCount = 3;
            tblLeds.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblLeds.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblLeds.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblLeds.Size = new Size(926, 456);
            tblLeds.TabIndex = 104;
            // 
            // lblLedMode
            // 
            lblLedMode.Anchor = AnchorStyles.Left;
            lblLedMode.AutoSize = true;
            lblLedMode.Location = new Point(13, 24);
            lblLedMode.Name = "lblLedMode";
            lblLedMode.Size = new Size(39, 15);
            lblLedMode.TabIndex = 105;
            lblLedMode.Text = "Modo";
            // 
            // cmbLedMode
            // 
            cmbLedMode.Anchor = AnchorStyles.Left;
            cmbLedMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLedMode.FormattingEnabled = true;
            cmbLedMode.Location = new Point(223, 20);
            cmbLedMode.Name = "cmbLedMode";
            cmbLedMode.Size = new Size(260, 23);
            cmbLedMode.TabIndex = 106;
            cmbLedMode.SelectedIndexChanged += cmbLedMode_SelectedIndexChanged;
            // 
            // lblLedSpeed
            // 
            lblLedSpeed.Anchor = AnchorStyles.Left;
            lblLedSpeed.AutoSize = true;
            lblLedSpeed.Location = new Point(13, 76);
            lblLedSpeed.Name = "lblLedSpeed";
            lblLedSpeed.Size = new Size(164, 15);
            lblLedSpeed.TabIndex = 107;
            lblLedSpeed.Text = "Velocidad (1 lenta – 30 rápida)";
            // 
            // flowLedSpeed
            // 
            flowLedSpeed.Anchor = AnchorStyles.Left;
            flowLedSpeed.AutoSize = true;
            flowLedSpeed.Controls.Add(trackLedSpeed);
            flowLedSpeed.Controls.Add(lblLedSpeedValue);
            flowLedSpeed.Location = new Point(223, 58);
            flowLedSpeed.Name = "flowLedSpeed";
            flowLedSpeed.Size = new Size(331, 51);
            flowLedSpeed.TabIndex = 110;
            // 
            // trackLedSpeed
            // 
            trackLedSpeed.Location = new Point(3, 3);
            trackLedSpeed.Maximum = 30;
            trackLedSpeed.Minimum = 1;
            trackLedSpeed.Name = "trackLedSpeed";
            trackLedSpeed.Size = new Size(300, 45);
            trackLedSpeed.TabIndex = 108;
            trackLedSpeed.TickFrequency = 5;
            trackLedSpeed.Value = 10;
            trackLedSpeed.ValueChanged += trackLedSpeed_ValueChanged;
            // 
            // lblLedSpeedValue
            // 
            lblLedSpeedValue.Anchor = AnchorStyles.Left;
            lblLedSpeedValue.AutoSize = true;
            lblLedSpeedValue.Location = new Point(312, 24);
            lblLedSpeedValue.Margin = new Padding(6, 12, 0, 0);
            lblLedSpeedValue.Name = "lblLedSpeedValue";
            lblLedSpeedValue.Size = new Size(19, 15);
            lblLedSpeedValue.TabIndex = 109;
            lblLedSpeedValue.Text = "10";
            // 
            // lblLedColor
            // 
            lblLedColor.Anchor = AnchorStyles.Left;
            lblLedColor.AutoSize = true;
            lblLedColor.Location = new Point(13, 272);
            lblLedColor.Name = "lblLedColor";
            lblLedColor.Size = new Size(36, 15);
            lblLedColor.TabIndex = 111;
            lblLedColor.Text = "Color";
            // 
            // flowLedColor
            // 
            flowLedColor.Anchor = AnchorStyles.Left;
            flowLedColor.AutoSize = true;
            flowLedColor.Controls.Add(btnLedColor);
            flowLedColor.Controls.Add(pnlLedSwatch);
            flowLedColor.Location = new Point(223, 264);
            flowLedColor.Name = "flowLedColor";
            flowLedColor.Size = new Size(172, 32);
            flowLedColor.TabIndex = 114;
            // 
            // btnLedColor
            // 
            btnLedColor.AutoSize = true;
            btnLedColor.Location = new Point(3, 3);
            btnLedColor.Name = "btnLedColor";
            btnLedColor.Size = new Size(100, 25);
            btnLedColor.TabIndex = 112;
            btnLedColor.Text = "Elegir color...";
            btnLedColor.UseVisualStyleBackColor = true;
            btnLedColor.Click += btnLedColor_Click;
            // 
            // pnlLedSwatch
            // 
            pnlLedSwatch.BackColor = Color.White;
            pnlLedSwatch.BorderStyle = BorderStyle.FixedSingle;
            pnlLedSwatch.Location = new Point(109, 3);
            pnlLedSwatch.Name = "pnlLedSwatch";
            pnlLedSwatch.Size = new Size(60, 26);
            pnlLedSwatch.TabIndex = 113;
            // 
            // lblLedsHint
            // 
            lblLedsHint.Dock = DockStyle.Bottom;
            lblLedsHint.ForeColor = SystemColors.GrayText;
            lblLedsHint.Location = new Point(3, 459);
            lblLedsHint.Name = "lblLedsHint";
            lblLedsHint.Padding = new Padding(10, 4, 10, 0);
            lblLedsHint.Size = new Size(926, 30);
            lblLedsHint.TabIndex = 115;
            lblLedsHint.Text = "Los cambios se envían al instante al Arduino. El brillo está fijado en el firmware (150).";
            // 
            // tabLeds
            // 
            tabLeds.Controls.Add(tblLeds);
            tabLeds.Controls.Add(lblLedsHint);
            tabLeds.Location = new Point(4, 24);
            tabLeds.Name = "tabLeds";
            tabLeds.Padding = new Padding(3);
            tabLeds.Size = new Size(932, 492);
            tabLeds.TabIndex = 116;
            tabLeds.Text = "LEDs";
            tabLeds.UseVisualStyleBackColor = true;
            // 
            // tblGeneral
            // 
            tblGeneral.AutoScroll = true;
            tblGeneral.ColumnCount = 3;
            tblGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tblGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tblGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblGeneral.Controls.Add(lblPort, 0, 0);
            tblGeneral.Controls.Add(cmbPort, 1, 0);
            tblGeneral.Controls.Add(btnRefreshPorts, 2, 0);
            tblGeneral.Controls.Add(lblStatusCaption, 0, 1);
            tblGeneral.Controls.Add(lblStatus, 1, 1);
            tblGeneral.Controls.Add(btnConnect, 2, 1);
            tblGeneral.Controls.Add(chkAutoConnect, 1, 2);
            tblGeneral.Controls.Add(chkStartup, 1, 3);
            tblGeneral.Dock = DockStyle.Fill;
            tblGeneral.Location = new Point(3, 3);
            tblGeneral.Name = "tblGeneral";
            tblGeneral.Padding = new Padding(10);
            tblGeneral.RowCount = 4;
            tblGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblGeneral.Size = new Size(926, 486);
            tblGeneral.TabIndex = 117;
            // 
            // lblPort
            // 
            lblPort.Anchor = AnchorStyles.Left;
            lblPort.AutoSize = true;
            lblPort.Location = new Point(13, 20);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(73, 15);
            lblPort.TabIndex = 118;
            lblPort.Text = "Puerto COM";
            // 
            // cmbPort
            // 
            cmbPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(143, 16);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(314, 23);
            cmbPort.TabIndex = 119;
            // 
            // btnRefreshPorts
            // 
            btnRefreshPorts.Anchor = AnchorStyles.Left;
            btnRefreshPorts.AutoSize = true;
            btnRefreshPorts.Location = new Point(463, 15);
            btnRefreshPorts.Name = "btnRefreshPorts";
            btnRefreshPorts.Size = new Size(69, 25);
            btnRefreshPorts.TabIndex = 120;
            btnRefreshPorts.Text = "Actualizar";
            btnRefreshPorts.UseVisualStyleBackColor = true;
            btnRefreshPorts.Click += btnRefreshPorts_Click;
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.Anchor = AnchorStyles.Left;
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Location = new Point(13, 56);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(42, 15);
            lblStatusCaption.TabIndex = 121;
            lblStatusCaption.Text = "Estado";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(143, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(82, 15);
            lblStatus.TabIndex = 122;
            lblStatus.Text = "Desconectado";
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Left;
            btnConnect.AutoSize = true;
            btnConnect.Location = new Point(463, 51);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(65, 25);
            btnConnect.TabIndex = 123;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // chkAutoConnect
            // 
            chkAutoConnect.Anchor = AnchorStyles.Left;
            chkAutoConnect.AutoSize = true;
            chkAutoConnect.Checked = true;
            chkAutoConnect.CheckState = CheckState.Checked;
            tblGeneral.SetColumnSpan(chkAutoConnect, 2);
            chkAutoConnect.Location = new Point(143, 90);
            chkAutoConnect.Name = "chkAutoConnect";
            chkAutoConnect.Size = new Size(279, 19);
            chkAutoConnect.TabIndex = 124;
            chkAutoConnect.Text = "Conectar automáticamente al abrir la aplicación";
            chkAutoConnect.UseVisualStyleBackColor = true;
            // 
            // chkStartup
            // 
            chkStartup.Anchor = AnchorStyles.Left;
            chkStartup.AutoSize = true;
            tblGeneral.SetColumnSpan(chkStartup, 2);
            chkStartup.Location = new Point(143, 287);
            chkStartup.Name = "chkStartup";
            chkStartup.Size = new Size(280, 19);
            chkStartup.TabIndex = 125;
            chkStartup.Text = "Iniciar con Windows (minimizado en la bandeja)";
            chkStartup.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(tblGeneral);
            tabGeneral.Location = new Point(4, 24);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(932, 492);
            tabGeneral.TabIndex = 126;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabSliders);
            tabMain.Controls.Add(tabButtons);
            tabMain.Controls.Add(tabLeds);
            tabMain.Controls.Add(tabGeneral);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(940, 520);
            tabMain.TabIndex = 127;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 520);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(940, 40);
            btnSave.TabIndex = 128;
            btnSave.Text = "Guardar y aplicar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(100, 22);
            mnuOpen.Text = "Abrir";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(100, 22);
            mnuExit.Text = "Salir";
            mnuExit.Click += mnuExit_Click;
            // 
            // trayMenu
            // 
            trayMenu.Items.AddRange(new ToolStripItem[] { mnuOpen, mnuExit });
            trayMenu.Name = "trayMenu";
            trayMenu.Size = new Size(101, 48);
            trayMenu.ItemClicked += trayMenu_ItemClicked;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = trayMenu;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            // 
            // timerUi
            // 
            timerUi.Enabled = true;
            timerUi.Tick += timerUi_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 560);
            Controls.Add(tabMain);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(900, 520);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stream Deck DIY";
            FormClosing += MainForm_FormClosing;
            Resize += MainForm_Resize;
            tblSliders.ResumeLayout(false);
            tblSliders.PerformLayout();
            tabSliders.ResumeLayout(false);
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tabButtons.ResumeLayout(false);
            tblLeds.ResumeLayout(false);
            tblLeds.PerformLayout();
            flowLedSpeed.ResumeLayout(false);
            flowLedSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackLedSpeed).EndInit();
            flowLedColor.ResumeLayout(false);
            flowLedColor.PerformLayout();
            tabLeds.ResumeLayout(false);
            tblGeneral.ResumeLayout(false);
            tblGeneral.PerformLayout();
            tabGeneral.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            trayMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSliders;
        private System.Windows.Forms.Label lblSliderHeader1;
        private System.Windows.Forms.Label lblSliderHeader2;
        private System.Windows.Forms.Label lblSliderHeader3;
        private System.Windows.Forms.Label lblSliderHeader4;
        private System.Windows.Forms.Label lblSliderHeader5;
        private System.Windows.Forms.Label lblSlider1;
        private System.Windows.Forms.TextBox txtSliderName1;
        private System.Windows.Forms.ComboBox cmbSliderType1;
        private System.Windows.Forms.ComboBox cmbSliderParam1;
        private System.Windows.Forms.CheckBox chkSliderInvert1;
        private System.Windows.Forms.ProgressBar pbSlider1;
        private System.Windows.Forms.Label lblSlider2;
        private System.Windows.Forms.TextBox txtSliderName2;
        private System.Windows.Forms.ComboBox cmbSliderType2;
        private System.Windows.Forms.ComboBox cmbSliderParam2;
        private System.Windows.Forms.CheckBox chkSliderInvert2;
        private System.Windows.Forms.ProgressBar pbSlider2;
        private System.Windows.Forms.Label lblSlider3;
        private System.Windows.Forms.TextBox txtSliderName3;
        private System.Windows.Forms.ComboBox cmbSliderType3;
        private System.Windows.Forms.ComboBox cmbSliderParam3;
        private System.Windows.Forms.CheckBox chkSliderInvert3;
        private System.Windows.Forms.ProgressBar pbSlider3;
        private System.Windows.Forms.Label lblSlider4;
        private System.Windows.Forms.TextBox txtSliderName4;
        private System.Windows.Forms.ComboBox cmbSliderType4;
        private System.Windows.Forms.ComboBox cmbSliderParam4;
        private System.Windows.Forms.CheckBox chkSliderInvert4;
        private System.Windows.Forms.ProgressBar pbSlider4;
        private System.Windows.Forms.Label lblSlider5;
        private System.Windows.Forms.TextBox txtSliderName5;
        private System.Windows.Forms.ComboBox cmbSliderType5;
        private System.Windows.Forms.ComboBox cmbSliderParam5;
        private System.Windows.Forms.CheckBox chkSliderInvert5;
        private System.Windows.Forms.ProgressBar pbSlider5;
        private System.Windows.Forms.Label lblSlidersHint;
        private System.Windows.Forms.TabPage tabSliders;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Label lblButtonHeader1;
        private System.Windows.Forms.Label lblButtonHeader2;
        private System.Windows.Forms.Label lblButtonHeader3;
        private System.Windows.Forms.Label lblBtn1;
        private System.Windows.Forms.TextBox txtBtnName1;
        private System.Windows.Forms.ComboBox cmbBtnAction1;
        private System.Windows.Forms.ComboBox cmbBtnParam1;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Label lblBtn2;
        private System.Windows.Forms.TextBox txtBtnName2;
        private System.Windows.Forms.ComboBox cmbBtnAction2;
        private System.Windows.Forms.ComboBox cmbBtnParam2;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Label lblBtn3;
        private System.Windows.Forms.TextBox txtBtnName3;
        private System.Windows.Forms.ComboBox cmbBtnAction3;
        private System.Windows.Forms.ComboBox cmbBtnParam3;
        private System.Windows.Forms.Button btnBrowse3;
        private System.Windows.Forms.Button btnTest3;
        private System.Windows.Forms.Label lblBtn4;
        private System.Windows.Forms.TextBox txtBtnName4;
        private System.Windows.Forms.ComboBox cmbBtnAction4;
        private System.Windows.Forms.ComboBox cmbBtnParam4;
        private System.Windows.Forms.Button btnBrowse4;
        private System.Windows.Forms.Button btnTest4;
        private System.Windows.Forms.Label lblBtn5;
        private System.Windows.Forms.TextBox txtBtnName5;
        private System.Windows.Forms.ComboBox cmbBtnAction5;
        private System.Windows.Forms.ComboBox cmbBtnParam5;
        private System.Windows.Forms.Button btnBrowse5;
        private System.Windows.Forms.Button btnTest5;
        private System.Windows.Forms.Label lblBtn6;
        private System.Windows.Forms.TextBox txtBtnName6;
        private System.Windows.Forms.ComboBox cmbBtnAction6;
        private System.Windows.Forms.ComboBox cmbBtnParam6;
        private System.Windows.Forms.Button btnBrowse6;
        private System.Windows.Forms.Button btnTest6;
        private System.Windows.Forms.Label lblBtn7;
        private System.Windows.Forms.TextBox txtBtnName7;
        private System.Windows.Forms.ComboBox cmbBtnAction7;
        private System.Windows.Forms.ComboBox cmbBtnParam7;
        private System.Windows.Forms.Button btnBrowse7;
        private System.Windows.Forms.Button btnTest7;
        private System.Windows.Forms.Label lblBtn8;
        private System.Windows.Forms.TextBox txtBtnName8;
        private System.Windows.Forms.ComboBox cmbBtnAction8;
        private System.Windows.Forms.ComboBox cmbBtnParam8;
        private System.Windows.Forms.Button btnBrowse8;
        private System.Windows.Forms.Button btnTest8;
        private System.Windows.Forms.Label lblBtn9;
        private System.Windows.Forms.TextBox txtBtnName9;
        private System.Windows.Forms.ComboBox cmbBtnAction9;
        private System.Windows.Forms.ComboBox cmbBtnParam9;
        private System.Windows.Forms.Button btnBrowse9;
        private System.Windows.Forms.Button btnTest9;
        private System.Windows.Forms.Label lblBtn10;
        private System.Windows.Forms.TextBox txtBtnName10;
        private System.Windows.Forms.ComboBox cmbBtnAction10;
        private System.Windows.Forms.ComboBox cmbBtnParam10;
        private System.Windows.Forms.Button btnBrowse10;
        private System.Windows.Forms.Button btnTest10;
        private System.Windows.Forms.Label lblButtonsHint;
        private System.Windows.Forms.TabPage tabButtons;
        private System.Windows.Forms.TableLayoutPanel tblLeds;
        private System.Windows.Forms.Label lblLedMode;
        private System.Windows.Forms.ComboBox cmbLedMode;
        private System.Windows.Forms.Label lblLedSpeed;
        private System.Windows.Forms.TrackBar trackLedSpeed;
        private System.Windows.Forms.Label lblLedSpeedValue;
        private System.Windows.Forms.FlowLayoutPanel flowLedSpeed;
        private System.Windows.Forms.Label lblLedColor;
        private System.Windows.Forms.Button btnLedColor;
        private System.Windows.Forms.Panel pnlLedSwatch;
        private System.Windows.Forms.FlowLayoutPanel flowLedColor;
        private System.Windows.Forms.Label lblLedsHint;
        private System.Windows.Forms.TabPage tabLeds;
        private System.Windows.Forms.TableLayoutPanel tblGeneral;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkAutoConnect;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timerUi;
    }
}
