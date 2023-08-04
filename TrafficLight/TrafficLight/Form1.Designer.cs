namespace TrafficLight
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxSelectCOM = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxDataSize = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxStopBit = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYellowB = new System.Windows.Forms.TextBox();
            this.txtGreenB = new System.Windows.Forms.TextBox();
            this.txtYellowA = new System.Windows.Forms.TextBox();
            this.txtGreenA = new System.Windows.Forms.TextBox();
            this.BtnSendtoAVR = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sdGreenB1 = new SymbolFactoryDotNet.StandardControl();
            this.sdYellowB1 = new SymbolFactoryDotNet.StandardControl();
            this.sdRedB1 = new SymbolFactoryDotNet.StandardControl();
            this.sdRedB2 = new SymbolFactoryDotNet.StandardControl();
            this.sdYellowB2 = new SymbolFactoryDotNet.StandardControl();
            this.sdGreenB2 = new SymbolFactoryDotNet.StandardControl();
            this.sdRedA1 = new SymbolFactoryDotNet.StandardControl();
            this.sdYellowA1 = new SymbolFactoryDotNet.StandardControl();
            this.sdGreenA1 = new SymbolFactoryDotNet.StandardControl();
            this.sdRedA2 = new SymbolFactoryDotNet.StandardControl();
            this.sdYellowA2 = new SymbolFactoryDotNet.StandardControl();
            this.sdGreenA2 = new SymbolFactoryDotNet.StandardControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimeB1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTimeA1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTimeB2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTimeA2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.myPorts = new System.IO.Ports.SerialPort(this.components);
            this.rdBMode1 = new System.Windows.Forms.RadioButton();
            this.rdBMode2 = new System.Windows.Forms.RadioButton();
            this.rdBOffSystem = new System.Windows.Forms.RadioButton();
            this.timerPorts = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenA2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSelectCOM
            // 
            this.cbxSelectCOM.FormattingEnabled = true;
            this.cbxSelectCOM.Location = new System.Drawing.Point(111, 23);
            this.cbxSelectCOM.Name = "cbxSelectCOM";
            this.cbxSelectCOM.Size = new System.Drawing.Size(111, 21);
            this.cbxSelectCOM.TabIndex = 0;
            this.cbxSelectCOM.SelectedIndexChanged += new System.EventHandler(this.cbxSelectCOM_SelectedIndexChanged);
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(111, 64);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(111, 21);
            this.cbxBaudRate.TabIndex = 1;
            // 
            // cbxDataSize
            // 
            this.cbxDataSize.FormattingEnabled = true;
            this.cbxDataSize.Location = new System.Drawing.Point(111, 108);
            this.cbxDataSize.Name = "cbxDataSize";
            this.cbxDataSize.Size = new System.Drawing.Size(111, 21);
            this.cbxDataSize.TabIndex = 2;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(111, 152);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(111, 21);
            this.cbxParity.TabIndex = 3;
            // 
            // cbxStopBit
            // 
            this.cbxStopBit.FormattingEnabled = true;
            this.cbxStopBit.Location = new System.Drawing.Point(111, 191);
            this.cbxStopBit.Name = "cbxStopBit";
            this.cbxStopBit.Size = new System.Drawing.Size(111, 21);
            this.cbxStopBit.TabIndex = 4;
            // 
            // BtnConnect
            // 
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnect.Location = new System.Drawing.Point(126, 230);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(94, 27);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.Text = "Disconnect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM_Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "BaudRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DataSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "StopBit";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(29, 233);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(23, 18);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYellowB);
            this.groupBox1.Controls.Add(this.txtGreenB);
            this.groupBox1.Controls.Add(this.txtYellowA);
            this.groupBox1.Controls.Add(this.txtGreenA);
            this.groupBox1.Controls.Add(this.BtnSendtoAVR);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(28, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 197);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtYellowB
            // 
            this.txtYellowB.Location = new System.Drawing.Point(109, 138);
            this.txtYellowB.Name = "txtYellowB";
            this.txtYellowB.Size = new System.Drawing.Size(66, 20);
            this.txtYellowB.TabIndex = 17;
            this.txtYellowB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYellowB.TextChanged += new System.EventHandler(this.txtGreenA_TextChanged);
            // 
            // txtGreenB
            // 
            this.txtGreenB.Location = new System.Drawing.Point(109, 104);
            this.txtGreenB.Name = "txtGreenB";
            this.txtGreenB.Size = new System.Drawing.Size(66, 20);
            this.txtGreenB.TabIndex = 16;
            this.txtGreenB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGreenB.TextChanged += new System.EventHandler(this.txtGreenA_TextChanged);
            // 
            // txtYellowA
            // 
            this.txtYellowA.Location = new System.Drawing.Point(109, 70);
            this.txtYellowA.Name = "txtYellowA";
            this.txtYellowA.Size = new System.Drawing.Size(66, 20);
            this.txtYellowA.TabIndex = 15;
            this.txtYellowA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYellowA.TextChanged += new System.EventHandler(this.txtGreenA_TextChanged);
            // 
            // txtGreenA
            // 
            this.txtGreenA.Location = new System.Drawing.Point(109, 40);
            this.txtGreenA.Name = "txtGreenA";
            this.txtGreenA.Size = new System.Drawing.Size(66, 20);
            this.txtGreenA.TabIndex = 14;
            this.txtGreenA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGreenA.TextChanged += new System.EventHandler(this.txtGreenA_TextChanged);
            // 
            // BtnSendtoAVR
            // 
            this.BtnSendtoAVR.Enabled = false;
            this.BtnSendtoAVR.Location = new System.Drawing.Point(64, 167);
            this.BtnSendtoAVR.Name = "BtnSendtoAVR";
            this.BtnSendtoAVR.Size = new System.Drawing.Size(59, 24);
            this.BtnSendtoAVR.TabIndex = 13;
            this.BtnSendtoAVR.Text = "SEND";
            this.BtnSendtoAVR.UseVisualStyleBackColor = true;
            this.BtnSendtoAVR.Click += new System.EventHandler(this.BtnSendtoAVR_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "YellowB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "GreenB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "YellowA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "GreenA";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhập thời gian";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdGreenB1
            // 
            this.sdGreenB1.AnalogIntValue1 = ((short)(0));
            this.sdGreenB1.AnalogValue1 = 0D;
            this.sdGreenB1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdGreenB1.BackColor = System.Drawing.SystemColors.Control;
            this.sdGreenB1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdGreenB1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))), "Band1"));
            this.sdGreenB1.BlinkColor = System.Drawing.Color.Red;
            this.sdGreenB1.Category = "1Btn.cat2";
            this.sdGreenB1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdGreenB1.DebugData"));
            this.sdGreenB1.FillColor = System.Drawing.Color.White;
            this.sdGreenB1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdGreenB1.Location = new System.Drawing.Point(10, 115);
            this.sdGreenB1.Name = "sdGreenB1";
            this.sdGreenB1.Size = new System.Drawing.Size(40, 42);
            this.sdGreenB1.SymbolHandle = ((long)(703557272));
            this.sdGreenB1.TabIndex = 13;
            // 
            // sdYellowB1
            // 
            this.sdYellowB1.AnalogIntValue1 = ((short)(0));
            this.sdYellowB1.AnalogValue1 = 0D;
            this.sdYellowB1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdYellowB1.BackColor = System.Drawing.SystemColors.Control;
            this.sdYellowB1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdYellowB1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band1"));
            this.sdYellowB1.BlinkColor = System.Drawing.Color.Red;
            this.sdYellowB1.Category = "1Btn.cat2";
            this.sdYellowB1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdYellowB1.DebugData"));
            this.sdYellowB1.FillColor = System.Drawing.Color.White;
            this.sdYellowB1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdYellowB1.Location = new System.Drawing.Point(10, 67);
            this.sdYellowB1.Name = "sdYellowB1";
            this.sdYellowB1.Size = new System.Drawing.Size(40, 42);
            this.sdYellowB1.SymbolHandle = ((long)(703557272));
            this.sdYellowB1.TabIndex = 14;
            // 
            // sdRedB1
            // 
            this.sdRedB1.AnalogIntValue1 = ((short)(0));
            this.sdRedB1.AnalogValue1 = 0D;
            this.sdRedB1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdRedB1.BackColor = System.Drawing.SystemColors.Control;
            this.sdRedB1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdRedB1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Red, "Band1"));
            this.sdRedB1.BlinkColor = System.Drawing.Color.Red;
            this.sdRedB1.Category = "1Btn.cat2";
            this.sdRedB1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdRedB1.DebugData"));
            this.sdRedB1.FillColor = System.Drawing.Color.White;
            this.sdRedB1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdRedB1.Location = new System.Drawing.Point(10, 19);
            this.sdRedB1.Name = "sdRedB1";
            this.sdRedB1.Size = new System.Drawing.Size(40, 42);
            this.sdRedB1.SymbolHandle = ((long)(703557272));
            this.sdRedB1.TabIndex = 15;
            // 
            // sdRedB2
            // 
            this.sdRedB2.AnalogIntValue1 = ((short)(0));
            this.sdRedB2.AnalogValue1 = 0D;
            this.sdRedB2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdRedB2.BackColor = System.Drawing.SystemColors.Control;
            this.sdRedB2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdRedB2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Red, "Band1"));
            this.sdRedB2.BlinkColor = System.Drawing.Color.Red;
            this.sdRedB2.Category = "1Btn.cat2";
            this.sdRedB2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdRedB2.DebugData"));
            this.sdRedB2.FillColor = System.Drawing.Color.White;
            this.sdRedB2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdRedB2.Location = new System.Drawing.Point(12, 147);
            this.sdRedB2.Name = "sdRedB2";
            this.sdRedB2.Size = new System.Drawing.Size(40, 42);
            this.sdRedB2.SymbolHandle = ((long)(703557272));
            this.sdRedB2.TabIndex = 18;
            // 
            // sdYellowB2
            // 
            this.sdYellowB2.AnalogIntValue1 = ((short)(0));
            this.sdYellowB2.AnalogValue1 = 0D;
            this.sdYellowB2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdYellowB2.BackColor = System.Drawing.SystemColors.Control;
            this.sdYellowB2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdYellowB2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band1"));
            this.sdYellowB2.BlinkColor = System.Drawing.Color.Red;
            this.sdYellowB2.Category = "1Btn.cat2";
            this.sdYellowB2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdYellowB2.DebugData"));
            this.sdYellowB2.FillColor = System.Drawing.Color.White;
            this.sdYellowB2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdYellowB2.Location = new System.Drawing.Point(12, 98);
            this.sdYellowB2.Name = "sdYellowB2";
            this.sdYellowB2.Size = new System.Drawing.Size(40, 42);
            this.sdYellowB2.SymbolHandle = ((long)(703557272));
            this.sdYellowB2.TabIndex = 17;
            // 
            // sdGreenB2
            // 
            this.sdGreenB2.AnalogIntValue1 = ((short)(0));
            this.sdGreenB2.AnalogValue1 = 0D;
            this.sdGreenB2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdGreenB2.BackColor = System.Drawing.SystemColors.Control;
            this.sdGreenB2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdGreenB2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))), "Band1"));
            this.sdGreenB2.BlinkColor = System.Drawing.Color.Red;
            this.sdGreenB2.Category = "1Btn.cat2";
            this.sdGreenB2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdGreenB2.DebugData"));
            this.sdGreenB2.FillColor = System.Drawing.Color.White;
            this.sdGreenB2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdGreenB2.Location = new System.Drawing.Point(12, 50);
            this.sdGreenB2.Name = "sdGreenB2";
            this.sdGreenB2.Size = new System.Drawing.Size(40, 42);
            this.sdGreenB2.SymbolHandle = ((long)(703557272));
            this.sdGreenB2.TabIndex = 16;
            // 
            // sdRedA1
            // 
            this.sdRedA1.AnalogIntValue1 = ((short)(0));
            this.sdRedA1.AnalogValue1 = 0D;
            this.sdRedA1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdRedA1.BackColor = System.Drawing.SystemColors.Control;
            this.sdRedA1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdRedA1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Red, "Band1"));
            this.sdRedA1.BlinkColor = System.Drawing.Color.Red;
            this.sdRedA1.Category = "1Btn.cat2";
            this.sdRedA1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdRedA1.DebugData"));
            this.sdRedA1.FillColor = System.Drawing.Color.White;
            this.sdRedA1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdRedA1.Location = new System.Drawing.Point(12, 11);
            this.sdRedA1.Name = "sdRedA1";
            this.sdRedA1.Size = new System.Drawing.Size(40, 42);
            this.sdRedA1.SymbolHandle = ((long)(703557272));
            this.sdRedA1.TabIndex = 21;
            // 
            // sdYellowA1
            // 
            this.sdYellowA1.AnalogIntValue1 = ((short)(0));
            this.sdYellowA1.AnalogValue1 = 0D;
            this.sdYellowA1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdYellowA1.BackColor = System.Drawing.SystemColors.Control;
            this.sdYellowA1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdYellowA1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band1"));
            this.sdYellowA1.BlinkColor = System.Drawing.Color.Red;
            this.sdYellowA1.Category = "1Btn.cat2";
            this.sdYellowA1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdYellowA1.DebugData"));
            this.sdYellowA1.FillColor = System.Drawing.Color.White;
            this.sdYellowA1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdYellowA1.Location = new System.Drawing.Point(63, 11);
            this.sdYellowA1.Name = "sdYellowA1";
            this.sdYellowA1.Size = new System.Drawing.Size(40, 42);
            this.sdYellowA1.SymbolHandle = ((long)(703557272));
            this.sdYellowA1.TabIndex = 20;
            // 
            // sdGreenA1
            // 
            this.sdGreenA1.AnalogIntValue1 = ((short)(0));
            this.sdGreenA1.AnalogValue1 = 0D;
            this.sdGreenA1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdGreenA1.BackColor = System.Drawing.SystemColors.Control;
            this.sdGreenA1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdGreenA1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))), "Band1"));
            this.sdGreenA1.BlinkColor = System.Drawing.Color.Red;
            this.sdGreenA1.Category = "1Btn.cat2";
            this.sdGreenA1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdGreenA1.DebugData"));
            this.sdGreenA1.FillColor = System.Drawing.Color.White;
            this.sdGreenA1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdGreenA1.Location = new System.Drawing.Point(118, 11);
            this.sdGreenA1.Name = "sdGreenA1";
            this.sdGreenA1.Size = new System.Drawing.Size(40, 42);
            this.sdGreenA1.SymbolHandle = ((long)(703557272));
            this.sdGreenA1.TabIndex = 19;
            // 
            // sdRedA2
            // 
            this.sdRedA2.AnalogIntValue1 = ((short)(0));
            this.sdRedA2.AnalogValue1 = 0D;
            this.sdRedA2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdRedA2.BackColor = System.Drawing.SystemColors.Control;
            this.sdRedA2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdRedA2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Red, "Band1"));
            this.sdRedA2.BlinkColor = System.Drawing.Color.Red;
            this.sdRedA2.Category = "1Btn.cat2";
            this.sdRedA2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdRedA2.DebugData"));
            this.sdRedA2.FillColor = System.Drawing.Color.White;
            this.sdRedA2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdRedA2.Location = new System.Drawing.Point(167, 12);
            this.sdRedA2.Name = "sdRedA2";
            this.sdRedA2.Size = new System.Drawing.Size(40, 42);
            this.sdRedA2.SymbolHandle = ((long)(703557272));
            this.sdRedA2.TabIndex = 24;
            // 
            // sdYellowA2
            // 
            this.sdYellowA2.AnalogIntValue1 = ((short)(0));
            this.sdYellowA2.AnalogValue1 = 0D;
            this.sdYellowA2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdYellowA2.BackColor = System.Drawing.SystemColors.Control;
            this.sdYellowA2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdYellowA2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.Yellow, "Band1"));
            this.sdYellowA2.BlinkColor = System.Drawing.Color.Red;
            this.sdYellowA2.Category = "1Btn.cat2";
            this.sdYellowA2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdYellowA2.DebugData"));
            this.sdYellowA2.FillColor = System.Drawing.Color.White;
            this.sdYellowA2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdYellowA2.Location = new System.Drawing.Point(113, 12);
            this.sdYellowA2.Name = "sdYellowA2";
            this.sdYellowA2.Size = new System.Drawing.Size(40, 42);
            this.sdYellowA2.SymbolHandle = ((long)(703557272));
            this.sdYellowA2.TabIndex = 23;
            // 
            // sdGreenA2
            // 
            this.sdGreenA2.AnalogIntValue1 = ((short)(0));
            this.sdGreenA2.AnalogValue1 = 0D;
            this.sdGreenA2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdGreenA2.BackColor = System.Drawing.SystemColors.Control;
            this.sdGreenA2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdGreenA2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))), "Band1"));
            this.sdGreenA2.BlinkColor = System.Drawing.Color.Red;
            this.sdGreenA2.Category = "1Btn.cat2";
            this.sdGreenA2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdGreenA2.DebugData"));
            this.sdGreenA2.FillColor = System.Drawing.Color.White;
            this.sdGreenA2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
            this.sdGreenA2.Location = new System.Drawing.Point(62, 12);
            this.sdGreenA2.Name = "sdGreenA2";
            this.sdGreenA2.Size = new System.Drawing.Size(40, 42);
            this.sdGreenA2.SymbolHandle = ((long)(703557272));
            this.sdGreenA2.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.lblTimeB1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.sdRedB1);
            this.groupBox2.Controls.Add(this.sdYellowB1);
            this.groupBox2.Controls.Add(this.sdGreenB1);
            this.groupBox2.Location = new System.Drawing.Point(620, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(62, 195);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // lblTimeB1
            // 
            this.lblTimeB1.AutoSize = true;
            this.lblTimeB1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeB1.Location = new System.Drawing.Point(18, 169);
            this.lblTimeB1.Name = "lblTimeB1";
            this.lblTimeB1.Size = new System.Drawing.Size(28, 21);
            this.lblTimeB1.TabIndex = 35;
            this.lblTimeB1.Text = "00";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(65, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(2, 206);
            this.label16.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.lblTimeA1);
            this.groupBox3.Controls.Add(this.sdGreenA1);
            this.groupBox3.Controls.Add(this.sdYellowA1);
            this.groupBox3.Controls.Add(this.sdRedA1);
            this.groupBox3.Location = new System.Drawing.Point(300, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 65);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // lblTimeA1
            // 
            this.lblTimeA1.AutoSize = true;
            this.lblTimeA1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeA1.Location = new System.Drawing.Point(174, 24);
            this.lblTimeA1.Name = "lblTimeA1";
            this.lblTimeA1.Size = new System.Drawing.Size(28, 21);
            this.lblTimeA1.TabIndex = 36;
            this.lblTimeA1.Text = "00";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.lblTimeB2);
            this.groupBox4.Controls.Add(this.sdGreenB2);
            this.groupBox4.Controls.Add(this.sdYellowB2);
            this.groupBox4.Controls.Add(this.sdRedB2);
            this.groupBox4.Location = new System.Drawing.Point(452, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(61, 199);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // lblTimeB2
            // 
            this.lblTimeB2.AutoSize = true;
            this.lblTimeB2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeB2.Location = new System.Drawing.Point(18, 16);
            this.lblTimeB2.Name = "lblTimeB2";
            this.lblTimeB2.Size = new System.Drawing.Size(28, 21);
            this.lblTimeB2.TabIndex = 38;
            this.lblTimeB2.Text = "00";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGray;
            this.groupBox5.Controls.Add(this.lblTimeA2);
            this.groupBox5.Controls.Add(this.sdRedA2);
            this.groupBox5.Controls.Add(this.sdYellowA2);
            this.groupBox5.Controls.Add(this.sdGreenA2);
            this.groupBox5.Location = new System.Drawing.Point(620, 279);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 60);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            // 
            // lblTimeA2
            // 
            this.lblTimeA2.AutoSize = true;
            this.lblTimeA2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeA2.Location = new System.Drawing.Point(20, 23);
            this.lblTimeA2.Name = "lblTimeA2";
            this.lblTimeA2.Size = new System.Drawing.Size(28, 21);
            this.lblTimeA2.TabIndex = 37;
            this.lblTimeA2.Text = "00";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(300, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 2);
            this.label12.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(617, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 2);
            this.label13.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(300, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 2);
            this.label14.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(617, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(216, 2);
            this.label15.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(516, -2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(2, 214);
            this.label17.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(617, -2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(2, 214);
            this.label18.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(516, 274);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(2, 214);
            this.label19.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(617, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(2, 214);
            this.label20.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(350, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 17);
            this.label25.TabIndex = 39;
            this.label25.Text = "Chọn chế độ:";
            // 
            // myPorts
            // 
            this.myPorts.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.myPorts_DataReceived);
            // 
            // rdBMode1
            // 
            this.rdBMode1.AutoSize = true;
            this.rdBMode1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBMode1.Location = new System.Drawing.Point(353, 45);
            this.rdBMode1.Name = "rdBMode1";
            this.rdBMode1.Size = new System.Drawing.Size(85, 19);
            this.rdBMode1.TabIndex = 41;
            this.rdBMode1.TabStop = true;
            this.rdBMode1.Text = "1 (6h - 23h)";
            this.rdBMode1.UseVisualStyleBackColor = true;
            this.rdBMode1.CheckedChanged += new System.EventHandler(this.rdBMode1_CheckedChanged);
            // 
            // rdBMode2
            // 
            this.rdBMode2.AutoSize = true;
            this.rdBMode2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBMode2.Location = new System.Drawing.Point(353, 75);
            this.rdBMode2.Name = "rdBMode2";
            this.rdBMode2.Size = new System.Drawing.Size(85, 19);
            this.rdBMode2.TabIndex = 42;
            this.rdBMode2.TabStop = true;
            this.rdBMode2.Text = "2 (23h - 6h)";
            this.rdBMode2.UseVisualStyleBackColor = true;
            this.rdBMode2.CheckedChanged += new System.EventHandler(this.rdBMode2_CheckedChanged);
            // 
            // rdBOffSystem
            // 
            this.rdBOffSystem.AutoSize = true;
            this.rdBOffSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBOffSystem.Location = new System.Drawing.Point(353, 104);
            this.rdBOffSystem.Name = "rdBOffSystem";
            this.rdBOffSystem.Size = new System.Drawing.Size(92, 19);
            this.rdBOffSystem.TabIndex = 43;
            this.rdBOffSystem.TabStop = true;
            this.rdBOffSystem.Text = "Tắt hệ thống";
            this.rdBOffSystem.UseVisualStyleBackColor = true;
            this.rdBOffSystem.CheckedChanged += new System.EventHandler(this.rdBOffSystem_CheckedChanged);
            // 
            // timerPorts
            // 
            this.timerPorts.Tick += new System.EventHandler(this.timerPorts_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 483);
            this.Controls.Add(this.rdBOffSystem);
            this.Controls.Add(this.rdBMode2);
            this.Controls.Add(this.rdBMode1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.cbxStopBit);
            this.Controls.Add(this.cbxParity);
            this.Controls.Add(this.cbxDataSize);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxSelectCOM);
            this.Name = "Form1";
            this.Text = "Traffic Light";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdRedA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdYellowA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdGreenA2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSelectCOM;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxDataSize;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxStopBit;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYellowB;
        private System.Windows.Forms.TextBox txtGreenB;
        private System.Windows.Forms.TextBox txtYellowA;
        private System.Windows.Forms.TextBox txtGreenA;
        private System.Windows.Forms.Button BtnSendtoAVR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private SymbolFactoryDotNet.StandardControl sdGreenB1;
        private SymbolFactoryDotNet.StandardControl sdYellowB1;
        private SymbolFactoryDotNet.StandardControl sdRedB1;
        private SymbolFactoryDotNet.StandardControl sdRedB2;
        private SymbolFactoryDotNet.StandardControl sdYellowB2;
        private SymbolFactoryDotNet.StandardControl sdGreenB2;
        private SymbolFactoryDotNet.StandardControl sdRedA1;
        private SymbolFactoryDotNet.StandardControl sdYellowA1;
        private SymbolFactoryDotNet.StandardControl sdGreenA1;
        private SymbolFactoryDotNet.StandardControl sdRedA2;
        private SymbolFactoryDotNet.StandardControl sdYellowA2;
        private SymbolFactoryDotNet.StandardControl sdGreenA2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTimeB1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTimeA1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTimeB2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTimeA2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.IO.Ports.SerialPort myPorts;
        private System.Windows.Forms.RadioButton rdBMode1;
        private System.Windows.Forms.RadioButton rdBMode2;
        private System.Windows.Forms.RadioButton rdBOffSystem;
        private System.Windows.Forms.Timer timerPorts;
        private System.Windows.Forms.Label label16;
    }
}

