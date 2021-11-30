﻿namespace TubeFeeder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.smartLabel3 = new SmartX.SmartLabel();
            this.buttonTest1 = new SmartX.SmartButton();
            this.btn_setting = new SmartX.SmartButton();
            this.label_keybuffer = new System.Windows.Forms.Label();
            this.smartListBox_log = new SmartX.SmartListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.smartForm1 = new SmartX.SmartForm();
            this.btn_start = new SmartX.SmartButton();
            this.btn_stop = new SmartX.SmartButton();
            this.label_indicator = new SmartX.SmartLabel();
            this.smartLabel2 = new SmartX.SmartLabel();
            this.label_scanCount = new SmartX.SmartLabel();
            this.label_curTime = new SmartX.SmartLabel();
            this.smartLabel4 = new SmartX.SmartLabel();
            this.label_runTime = new SmartX.SmartLabel();
            this.smartLabel6 = new SmartX.SmartLabel();
            this.smartTimer1 = new SmartX.SmartTimer(this.components);
            this.smartMemory1 = new SmartX.SmartMemory(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new SmartX.SmartButton();
            this.btn_BarcodeReadOn = new SmartX.SmartButton();
            this.btn_BarcodeReadOff = new SmartX.SmartButton();
            this.smartLabel1 = new SmartX.SmartLabel();
            this.smartLabel5 = new SmartX.SmartLabel();
            this.btn_AutoStopModeOff = new SmartX.SmartButton();
            this.btn_AutoStopModeOn = new SmartX.SmartButton();
            this.smartLabel7 = new SmartX.SmartLabel();
            this.btn_logo_BIONIT = new SmartX.SmartButton();
            this.btn_logo_AutoFeeder = new SmartX.SmartButton();
            this.smartUpdate1 = new SmartX.SmartUpdate(this.components);
            this.smartTimer2 = new SmartX.SmartTimer(this.components);
            this.smartLabel_VERSION = new SmartX.SmartLabel();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).BeginInit();
            this.SuspendLayout();
            // 
            // smartLabel3
            // 
            this.smartLabel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smartLabel3.BackPictureBox = null;
            this.smartLabel3.BackPictureBox1 = null;
            this.smartLabel3.BackPictureBox2 = null;
            this.smartLabel3.BorderColor = System.Drawing.Color.Black;
            this.smartLabel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel3.InitVisible = true;
            this.smartLabel3.LineSpacing = 0F;
            this.smartLabel3.Location = new System.Drawing.Point(46, 68);
            this.smartLabel3.Name = "smartLabel3";
            this.smartLabel3.Size = new System.Drawing.Size(139, 81);
            this.smartLabel3.TabIndex = 1;
            this.smartLabel3.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.smartLabel3.TextVAlign = SmartX.SmartLabel.TextVerAlign.Top;
            this.smartLabel3.Visible = false;
            this.smartLabel3.Wordwrap = false;
            // 
            // buttonTest1
            // 
            this.buttonTest1.BackPictureBox = null;
            this.buttonTest1.BackPictureBox1 = null;
            this.buttonTest1.BackPictureBox2 = null;
            this.buttonTest1.ButtonColor = System.Drawing.Color.Gray;
            this.buttonTest1.ButtonImageAutoSize = true;
            this.buttonTest1.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonTest1.DisableImage = null;
            this.buttonTest1.DownImage = null;
            this.buttonTest1.GroupID = 0;
            this.buttonTest1.InitVisible = true;
            this.buttonTest1.Location = new System.Drawing.Point(417, 12);
            this.buttonTest1.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.NestedClickEventPrevent = false;
            this.buttonTest1.OutlinePixel = 1;
            this.buttonTest1.RepeatInterval = 200;
            this.buttonTest1.RepeatIntervalAccelerate = null;
            this.buttonTest1.SafeInterval = 200;
            this.buttonTest1.Size = new System.Drawing.Size(81, 63);
            this.buttonTest1.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonTest1.TabIndex = 46;
            this.buttonTest1.Text = "test1";
            this.buttonTest1.TextColor = System.Drawing.Color.Black;
            this.buttonTest1.TextDownColor = System.Drawing.Color.White;
            this.buttonTest1.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonTest1.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonTest1.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonTest1.UpImage = null;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackPictureBox = null;
            this.btn_setting.BackPictureBox1 = null;
            this.btn_setting.BackPictureBox2 = null;
            this.btn_setting.ButtonColor = System.Drawing.Color.Gray;
            this.btn_setting.ButtonImageAutoSize = true;
            this.btn_setting.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_setting.DisableImage = null;
            this.btn_setting.DownImage = null;
            this.btn_setting.GroupID = 0;
            this.btn_setting.InitVisible = true;
            this.btn_setting.Location = new System.Drawing.Point(284, 12);
            this.btn_setting.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.NestedClickEventPrevent = false;
            this.btn_setting.OutlinePixel = 1;
            this.btn_setting.RepeatInterval = 200;
            this.btn_setting.RepeatIntervalAccelerate = null;
            this.btn_setting.SafeInterval = 200;
            this.btn_setting.Size = new System.Drawing.Size(82, 29);
            this.btn_setting.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_setting.TabIndex = 47;
            this.btn_setting.Text = "Setting";
            this.btn_setting.TextColor = System.Drawing.Color.Black;
            this.btn_setting.TextDownColor = System.Drawing.Color.White;
            this.btn_setting.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_setting.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_setting.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_setting.UpImage = null;
            this.btn_setting.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // label_keybuffer
            // 
            this.label_keybuffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_keybuffer.Location = new System.Drawing.Point(429, 137);
            this.label_keybuffer.Name = "label_keybuffer";
            this.label_keybuffer.Size = new System.Drawing.Size(265, 25);
            this.label_keybuffer.Text = "label_keybuffer";
            // 
            // smartListBox_log
            // 
            this.smartListBox_log.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.smartListBox_log.BackPictureBox = null;
            this.smartListBox_log.BackPictureBox1 = null;
            this.smartListBox_log.BackPictureBox2 = null;
            this.smartListBox_log.ColumnAlign = SmartX.SmartListBox.COLUMNALIGNS.CENTER;
            this.smartListBox_log.ColumnDelimiter = '\0';
            this.smartListBox_log.ColumnOffsets = null;
            this.smartListBox_log.FontColor = System.Drawing.Color.Black;
            this.smartListBox_log.InitVisible = true;
            this.smartListBox_log.ItemAddOrder = SmartX.SmartListBox.ITEMADDORDERS.BOTTOMADD;
            this.smartListBox_log.ItemOffsetGap = 0;
            this.smartListBox_log.ItemOffsetX = 0;
            this.smartListBox_log.ItemOffsetY = 0;
            this.smartListBox_log.Location = new System.Drawing.Point(9, 91);
            this.smartListBox_log.MouseMoveEventSpace = 3;
            this.smartListBox_log.MouseMoveSpace = 10;
            this.smartListBox_log.Name = "smartListBox_log";
            this.smartListBox_log.OutLineColor = System.Drawing.SystemColors.ControlText;
            this.smartListBox_log.SelectColor = System.Drawing.Color.Blue;
            this.smartListBox_log.SelectFilled = true;
            this.smartListBox_log.SelectFontColor = System.Drawing.Color.DarkBlue;
            this.smartListBox_log.SelectItemIndex = -1;
            this.smartListBox_log.SeparationlineColor1 = System.Drawing.Color.Gray;
            this.smartListBox_log.SeparationlineColor2 = System.Drawing.Color.LightGray;
            this.smartListBox_log.SeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.smartListBox_log.SeparationlineVisibleBottom = true;
            this.smartListBox_log.SeparationlineVisibleTop = true;
            this.smartListBox_log.Size = new System.Drawing.Size(382, 469);
            this.smartListBox_log.TabIndex = 51;
            this.smartListBox_log.Text = "LogListBox";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.Text = "DateTime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // smartForm1
            // 
            this.smartForm1.CenterLocation = false;
            this.smartForm1.LCDDirection = SmartX.SmartForm.LCDDIRECTIONS.HORIZONTAL;
            this.smartForm1.LCDSize = SmartX.SmartForm.LCDRESOLUTION.LCD800X600;
            this.smartForm1.Location = new System.Drawing.Point(0, 0);
            this.smartForm1.MainForm = null;
            this.smartForm1.Mode = SmartX.SmartForm.RUNMODE.RUNTIME;
            this.smartForm1.MouseCursor = SmartX.SmartForm.OnOff.OFF;
            this.smartForm1.Name = "smartForm1";
            this.smartForm1.Size = new System.Drawing.Size(800, 600);
            this.smartForm1.SpecialFunctionClickPointSize = 100;
            this.smartForm1.SuspendLayoutInterval = 1;
            // 
            // btn_start
            // 
            this.btn_start.BackPictureBox = null;
            this.btn_start.BackPictureBox1 = null;
            this.btn_start.BackPictureBox2 = null;
            this.btn_start.ButtonColor = System.Drawing.Color.DimGray;
            this.btn_start.ButtonImageAutoSize = false;
            this.btn_start.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_start.DisableImage = null;
            this.btn_start.DownImage = null;
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.btn_start.GroupID = 1;
            this.btn_start.InitVisible = true;
            this.btn_start.Location = new System.Drawing.Point(400, 0);
            this.btn_start.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_start.Name = "btn_start";
            this.btn_start.NestedClickEventPrevent = false;
            this.btn_start.OutlinePixel = 1;
            this.btn_start.RepeatInterval = 200;
            this.btn_start.RepeatIntervalAccelerate = null;
            this.btn_start.SafeInterval = 200;
            this.btn_start.Size = new System.Drawing.Size(300, 280);
            this.btn_start.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_start.TabIndex = 59;
            this.btn_start.Text = "START";
            this.btn_start.TextColor = System.Drawing.Color.Black;
            this.btn_start.TextDownColor = System.Drawing.Color.White;
            this.btn_start.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_start.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_start.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_start.UpImage = null;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackPictureBox = null;
            this.btn_stop.BackPictureBox1 = null;
            this.btn_stop.BackPictureBox2 = null;
            this.btn_stop.ButtonColor = System.Drawing.Color.DimGray;
            this.btn_stop.ButtonImageAutoSize = true;
            this.btn_stop.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_stop.DisableImage = null;
            this.btn_stop.DownImage = null;
            this.btn_stop.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Bold);
            this.btn_stop.GroupID = 1;
            this.btn_stop.InitVisible = true;
            this.btn_stop.Location = new System.Drawing.Point(400, 280);
            this.btn_stop.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.NestedClickEventPrevent = false;
            this.btn_stop.OutlinePixel = 1;
            this.btn_stop.RepeatInterval = 200;
            this.btn_stop.RepeatIntervalAccelerate = null;
            this.btn_stop.SafeInterval = 200;
            this.btn_stop.Size = new System.Drawing.Size(300, 280);
            this.btn_stop.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_stop.TabIndex = 60;
            this.btn_stop.Text = "STOP";
            this.btn_stop.TextColor = System.Drawing.Color.Black;
            this.btn_stop.TextDownColor = System.Drawing.Color.White;
            this.btn_stop.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_stop.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_stop.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_stop.UpImage = null;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label_indicator
            // 
            this.label_indicator.BackColor = System.Drawing.Color.Gray;
            this.label_indicator.BackPictureBox = null;
            this.label_indicator.BackPictureBox1 = null;
            this.label_indicator.BackPictureBox2 = null;
            this.label_indicator.BorderColor = System.Drawing.Color.Black;
            this.label_indicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_indicator.InitVisible = true;
            this.label_indicator.LineSpacing = 0F;
            this.label_indicator.Location = new System.Drawing.Point(700, 0);
            this.label_indicator.Name = "label_indicator";
            this.label_indicator.Size = new System.Drawing.Size(100, 560);
            this.label_indicator.TabIndex = 61;
            this.label_indicator.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.label_indicator.TextVAlign = SmartX.SmartLabel.TextVerAlign.Top;
            this.label_indicator.Wordwrap = false;
            // 
            // smartLabel2
            // 
            this.smartLabel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smartLabel2.BackPictureBox = null;
            this.smartLabel2.BackPictureBox1 = null;
            this.smartLabel2.BackPictureBox2 = null;
            this.smartLabel2.BorderColor = System.Drawing.Color.Black;
            this.smartLabel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel2.InitVisible = true;
            this.smartLabel2.LineSpacing = 0F;
            this.smartLabel2.Location = new System.Drawing.Point(9, 527);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(100, 29);
            this.smartLabel2.TabIndex = 62;
            this.smartLabel2.Text = "Scan count :";
            this.smartLabel2.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel2.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel2.Visible = false;
            this.smartLabel2.Wordwrap = false;
            // 
            // label_scanCount
            // 
            this.label_scanCount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_scanCount.BackPictureBox = null;
            this.label_scanCount.BackPictureBox1 = null;
            this.label_scanCount.BackPictureBox2 = null;
            this.label_scanCount.BorderColor = System.Drawing.Color.Black;
            this.label_scanCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_scanCount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label_scanCount.InitVisible = true;
            this.label_scanCount.LineSpacing = 0F;
            this.label_scanCount.Location = new System.Drawing.Point(115, 527);
            this.label_scanCount.Name = "label_scanCount";
            this.label_scanCount.Size = new System.Drawing.Size(65, 29);
            this.label_scanCount.TabIndex = 63;
            this.label_scanCount.Text = "0개";
            this.label_scanCount.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.label_scanCount.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.label_scanCount.Visible = false;
            this.label_scanCount.Wordwrap = false;
            // 
            // label_curTime
            // 
            this.label_curTime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_curTime.BackPictureBox = null;
            this.label_curTime.BackPictureBox1 = null;
            this.label_curTime.BackPictureBox2 = null;
            this.label_curTime.BorderColor = System.Drawing.Color.Black;
            this.label_curTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_curTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label_curTime.InitVisible = true;
            this.label_curTime.LineSpacing = 0F;
            this.label_curTime.Location = new System.Drawing.Point(115, 12);
            this.label_curTime.Name = "label_curTime";
            this.label_curTime.Size = new System.Drawing.Size(125, 21);
            this.label_curTime.TabIndex = 65;
            this.label_curTime.Text = "0";
            this.label_curTime.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.label_curTime.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.label_curTime.Wordwrap = false;
            // 
            // smartLabel4
            // 
            this.smartLabel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smartLabel4.BackPictureBox = null;
            this.smartLabel4.BackPictureBox1 = null;
            this.smartLabel4.BackPictureBox2 = null;
            this.smartLabel4.BorderColor = System.Drawing.Color.Black;
            this.smartLabel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel4.InitVisible = true;
            this.smartLabel4.LineSpacing = 0F;
            this.smartLabel4.Location = new System.Drawing.Point(9, 12);
            this.smartLabel4.Name = "smartLabel4";
            this.smartLabel4.Size = new System.Drawing.Size(100, 21);
            this.smartLabel4.TabIndex = 64;
            this.smartLabel4.Text = "Current time :";
            this.smartLabel4.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel4.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel4.Wordwrap = false;
            // 
            // label_runTime
            // 
            this.label_runTime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_runTime.BackPictureBox = null;
            this.label_runTime.BackPictureBox1 = null;
            this.label_runTime.BackPictureBox2 = null;
            this.label_runTime.BorderColor = System.Drawing.Color.Black;
            this.label_runTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_runTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_runTime.InitVisible = true;
            this.label_runTime.LineSpacing = 0F;
            this.label_runTime.Location = new System.Drawing.Point(115, 35);
            this.label_runTime.Name = "label_runTime";
            this.label_runTime.Size = new System.Drawing.Size(125, 21);
            this.label_runTime.TabIndex = 67;
            this.label_runTime.Text = "0";
            this.label_runTime.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.label_runTime.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.label_runTime.Wordwrap = false;
            // 
            // smartLabel6
            // 
            this.smartLabel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smartLabel6.BackPictureBox = null;
            this.smartLabel6.BackPictureBox1 = null;
            this.smartLabel6.BackPictureBox2 = null;
            this.smartLabel6.BorderColor = System.Drawing.Color.Black;
            this.smartLabel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel6.InitVisible = true;
            this.smartLabel6.LineSpacing = 0F;
            this.smartLabel6.Location = new System.Drawing.Point(9, 35);
            this.smartLabel6.Name = "smartLabel6";
            this.smartLabel6.Size = new System.Drawing.Size(100, 21);
            this.smartLabel6.TabIndex = 66;
            this.smartLabel6.Text = "Run time :";
            this.smartLabel6.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel6.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel6.Wordwrap = false;
            // 
            // smartTimer1
            // 
            this.smartTimer1.EndTime = ((long)(100000000000));
            this.smartTimer1.Interval = 100;
            this.smartTimer1.IntervalSeries = null;
            this.smartTimer1.NowMillisecond = ((long)(0));
            this.smartTimer1.StartTime = ((long)(0));
            this.smartTimer1.Tick += new System.EventHandler(this.smartTimer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(109, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.Text = "Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackPictureBox = null;
            this.btn_Exit.BackPictureBox1 = null;
            this.btn_Exit.BackPictureBox2 = null;
            this.btn_Exit.ButtonColor = System.Drawing.Color.Gray;
            this.btn_Exit.ButtonImageAutoSize = true;
            this.btn_Exit.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_Exit.DisableImage = null;
            this.btn_Exit.DownImage = null;
            this.btn_Exit.GroupID = 0;
            this.btn_Exit.InitVisible = true;
            this.btn_Exit.Location = new System.Drawing.Point(306, 527);
            this.btn_Exit.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.NestedClickEventPrevent = false;
            this.btn_Exit.OutlinePixel = 1;
            this.btn_Exit.RepeatInterval = 200;
            this.btn_Exit.RepeatIntervalAccelerate = null;
            this.btn_Exit.SafeInterval = 200;
            this.btn_Exit.Size = new System.Drawing.Size(85, 29);
            this.btn_Exit.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_Exit.TabIndex = 73;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.TextColor = System.Drawing.Color.Black;
            this.btn_Exit.TextDownColor = System.Drawing.Color.White;
            this.btn_Exit.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_Exit.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_Exit.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_Exit.UpImage = null;
            this.btn_Exit.Visible = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_BarcodeReadOn
            // 
            this.btn_BarcodeReadOn.BackPictureBox = null;
            this.btn_BarcodeReadOn.BackPictureBox1 = null;
            this.btn_BarcodeReadOn.BackPictureBox2 = null;
            this.btn_BarcodeReadOn.ButtonColor = System.Drawing.Color.Gray;
            this.btn_BarcodeReadOn.ButtonImageAutoSize = true;
            this.btn_BarcodeReadOn.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_BarcodeReadOn.DisableImage = null;
            this.btn_BarcodeReadOn.DownImage = null;
            this.btn_BarcodeReadOn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_BarcodeReadOn.GroupID = 3;
            this.btn_BarcodeReadOn.InitVisible = true;
            this.btn_BarcodeReadOn.Location = new System.Drawing.Point(59, 91);
            this.btn_BarcodeReadOn.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_BarcodeReadOn.Name = "btn_BarcodeReadOn";
            this.btn_BarcodeReadOn.NestedClickEventPrevent = false;
            this.btn_BarcodeReadOn.OutlinePixel = 1;
            this.btn_BarcodeReadOn.RepeatInterval = 200;
            this.btn_BarcodeReadOn.RepeatIntervalAccelerate = null;
            this.btn_BarcodeReadOn.SafeInterval = 200;
            this.btn_BarcodeReadOn.Size = new System.Drawing.Size(56, 55);
            this.btn_BarcodeReadOn.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_BarcodeReadOn.TabIndex = 74;
            this.btn_BarcodeReadOn.Text = "ON";
            this.btn_BarcodeReadOn.TextColor = System.Drawing.Color.Black;
            this.btn_BarcodeReadOn.TextDownColor = System.Drawing.Color.White;
            this.btn_BarcodeReadOn.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_BarcodeReadOn.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_BarcodeReadOn.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_BarcodeReadOn.UpImage = null;
            this.btn_BarcodeReadOn.Visible = false;
            this.btn_BarcodeReadOn.Click += new System.EventHandler(this.radioButton_BarcodeReadOn_Click);
            // 
            // btn_BarcodeReadOff
            // 
            this.btn_BarcodeReadOff.BackPictureBox = null;
            this.btn_BarcodeReadOff.BackPictureBox1 = null;
            this.btn_BarcodeReadOff.BackPictureBox2 = null;
            this.btn_BarcodeReadOff.ButtonColor = System.Drawing.Color.Gray;
            this.btn_BarcodeReadOff.ButtonImageAutoSize = true;
            this.btn_BarcodeReadOff.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_BarcodeReadOff.DisableImage = null;
            this.btn_BarcodeReadOff.DownImage = null;
            this.btn_BarcodeReadOff.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_BarcodeReadOff.GroupID = 3;
            this.btn_BarcodeReadOff.InitVisible = true;
            this.btn_BarcodeReadOff.Location = new System.Drawing.Point(115, 91);
            this.btn_BarcodeReadOff.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_BarcodeReadOff.Name = "btn_BarcodeReadOff";
            this.btn_BarcodeReadOff.NestedClickEventPrevent = false;
            this.btn_BarcodeReadOff.OutlinePixel = 1;
            this.btn_BarcodeReadOff.RepeatInterval = 200;
            this.btn_BarcodeReadOff.RepeatIntervalAccelerate = null;
            this.btn_BarcodeReadOff.SafeInterval = 200;
            this.btn_BarcodeReadOff.Size = new System.Drawing.Size(56, 55);
            this.btn_BarcodeReadOff.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_BarcodeReadOff.TabIndex = 75;
            this.btn_BarcodeReadOff.Text = "OFF";
            this.btn_BarcodeReadOff.TextColor = System.Drawing.Color.Black;
            this.btn_BarcodeReadOff.TextDownColor = System.Drawing.Color.White;
            this.btn_BarcodeReadOff.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_BarcodeReadOff.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_BarcodeReadOff.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_BarcodeReadOff.UpImage = null;
            this.btn_BarcodeReadOff.Visible = false;
            this.btn_BarcodeReadOff.Click += new System.EventHandler(this.radioButton_BarcodeReadOff_Click);
            // 
            // smartLabel1
            // 
            this.smartLabel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smartLabel1.BackPictureBox = null;
            this.smartLabel1.BackPictureBox1 = null;
            this.smartLabel1.BackPictureBox2 = null;
            this.smartLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.smartLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel1.InitVisible = true;
            this.smartLabel1.LineSpacing = 0F;
            this.smartLabel1.Location = new System.Drawing.Point(50, 72);
            this.smartLabel1.Name = "smartLabel1";
            this.smartLabel1.Size = new System.Drawing.Size(132, 18);
            this.smartLabel1.TabIndex = 76;
            this.smartLabel1.Text = "Barcode Mode";
            this.smartLabel1.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel1.TextVAlign = SmartX.SmartLabel.TextVerAlign.Top;
            this.smartLabel1.Visible = false;
            this.smartLabel1.Wordwrap = false;
            // 
            // smartLabel5
            // 
            this.smartLabel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smartLabel5.BackPictureBox = null;
            this.smartLabel5.BackPictureBox1 = null;
            this.smartLabel5.BackPictureBox2 = null;
            this.smartLabel5.BorderColor = System.Drawing.Color.Transparent;
            this.smartLabel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel5.InitVisible = true;
            this.smartLabel5.LineSpacing = 0F;
            this.smartLabel5.Location = new System.Drawing.Point(219, 72);
            this.smartLabel5.Name = "smartLabel5";
            this.smartLabel5.Size = new System.Drawing.Size(132, 18);
            this.smartLabel5.TabIndex = 84;
            this.smartLabel5.Text = "Auto Stop Mode";
            this.smartLabel5.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel5.TextVAlign = SmartX.SmartLabel.TextVerAlign.Top;
            this.smartLabel5.Visible = false;
            this.smartLabel5.Wordwrap = false;
            // 
            // btn_AutoStopModeOff
            // 
            this.btn_AutoStopModeOff.BackPictureBox = null;
            this.btn_AutoStopModeOff.BackPictureBox1 = null;
            this.btn_AutoStopModeOff.BackPictureBox2 = null;
            this.btn_AutoStopModeOff.ButtonColor = System.Drawing.Color.Gray;
            this.btn_AutoStopModeOff.ButtonImageAutoSize = true;
            this.btn_AutoStopModeOff.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_AutoStopModeOff.DisableImage = null;
            this.btn_AutoStopModeOff.DownImage = null;
            this.btn_AutoStopModeOff.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_AutoStopModeOff.GroupID = 4;
            this.btn_AutoStopModeOff.InitVisible = true;
            this.btn_AutoStopModeOff.Location = new System.Drawing.Point(284, 91);
            this.btn_AutoStopModeOff.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_AutoStopModeOff.Name = "btn_AutoStopModeOff";
            this.btn_AutoStopModeOff.NestedClickEventPrevent = false;
            this.btn_AutoStopModeOff.OutlinePixel = 1;
            this.btn_AutoStopModeOff.RepeatInterval = 200;
            this.btn_AutoStopModeOff.RepeatIntervalAccelerate = null;
            this.btn_AutoStopModeOff.SafeInterval = 200;
            this.btn_AutoStopModeOff.Size = new System.Drawing.Size(56, 55);
            this.btn_AutoStopModeOff.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_AutoStopModeOff.TabIndex = 83;
            this.btn_AutoStopModeOff.Text = "OFF";
            this.btn_AutoStopModeOff.TextColor = System.Drawing.Color.Black;
            this.btn_AutoStopModeOff.TextDownColor = System.Drawing.Color.White;
            this.btn_AutoStopModeOff.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_AutoStopModeOff.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_AutoStopModeOff.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_AutoStopModeOff.UpImage = null;
            this.btn_AutoStopModeOff.Visible = false;
            this.btn_AutoStopModeOff.Click += new System.EventHandler(this.btn_AutoStopModeOff_Click);
            // 
            // btn_AutoStopModeOn
            // 
            this.btn_AutoStopModeOn.BackPictureBox = null;
            this.btn_AutoStopModeOn.BackPictureBox1 = null;
            this.btn_AutoStopModeOn.BackPictureBox2 = null;
            this.btn_AutoStopModeOn.ButtonColor = System.Drawing.Color.Gray;
            this.btn_AutoStopModeOn.ButtonImageAutoSize = true;
            this.btn_AutoStopModeOn.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_AutoStopModeOn.DisableImage = null;
            this.btn_AutoStopModeOn.DownImage = null;
            this.btn_AutoStopModeOn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_AutoStopModeOn.GroupID = 4;
            this.btn_AutoStopModeOn.InitVisible = true;
            this.btn_AutoStopModeOn.Location = new System.Drawing.Point(228, 91);
            this.btn_AutoStopModeOn.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_AutoStopModeOn.Name = "btn_AutoStopModeOn";
            this.btn_AutoStopModeOn.NestedClickEventPrevent = false;
            this.btn_AutoStopModeOn.OutlinePixel = 1;
            this.btn_AutoStopModeOn.RepeatInterval = 200;
            this.btn_AutoStopModeOn.RepeatIntervalAccelerate = null;
            this.btn_AutoStopModeOn.SafeInterval = 200;
            this.btn_AutoStopModeOn.Size = new System.Drawing.Size(56, 55);
            this.btn_AutoStopModeOn.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_AutoStopModeOn.TabIndex = 82;
            this.btn_AutoStopModeOn.Text = "ON";
            this.btn_AutoStopModeOn.TextColor = System.Drawing.Color.Black;
            this.btn_AutoStopModeOn.TextDownColor = System.Drawing.Color.White;
            this.btn_AutoStopModeOn.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_AutoStopModeOn.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_AutoStopModeOn.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_AutoStopModeOn.UpImage = null;
            this.btn_AutoStopModeOn.Visible = false;
            this.btn_AutoStopModeOn.Click += new System.EventHandler(this.btn_AutoStopModeOn_Click);
            // 
            // smartLabel7
            // 
            this.smartLabel7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smartLabel7.BackPictureBox = null;
            this.smartLabel7.BackPictureBox1 = null;
            this.smartLabel7.BackPictureBox2 = null;
            this.smartLabel7.BorderColor = System.Drawing.Color.Black;
            this.smartLabel7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel7.InitVisible = true;
            this.smartLabel7.LineSpacing = 0F;
            this.smartLabel7.Location = new System.Drawing.Point(215, 68);
            this.smartLabel7.Name = "smartLabel7";
            this.smartLabel7.Size = new System.Drawing.Size(139, 81);
            this.smartLabel7.TabIndex = 81;
            this.smartLabel7.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.smartLabel7.TextVAlign = SmartX.SmartLabel.TextVerAlign.Top;
            this.smartLabel7.Visible = false;
            this.smartLabel7.Wordwrap = false;
            // 
            // btn_logo_BIONIT
            // 
            this.btn_logo_BIONIT.BackPictureBox = null;
            this.btn_logo_BIONIT.BackPictureBox1 = null;
            this.btn_logo_BIONIT.BackPictureBox2 = null;
            this.btn_logo_BIONIT.ButtonColor = System.Drawing.Color.Gray;
            this.btn_logo_BIONIT.ButtonImageAutoSize = true;
            this.btn_logo_BIONIT.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_logo_BIONIT.DisableImage = ((System.Drawing.Image)(resources.GetObject("btn_logo_BIONIT.DisableImage")));
            this.btn_logo_BIONIT.DownImage = null;
            this.btn_logo_BIONIT.Enabled = false;
            this.btn_logo_BIONIT.GroupID = 0;
            this.btn_logo_BIONIT.InitVisible = true;
            this.btn_logo_BIONIT.Location = new System.Drawing.Point(700, 562);
            this.btn_logo_BIONIT.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_logo_BIONIT.Name = "btn_logo_BIONIT";
            this.btn_logo_BIONIT.NestedClickEventPrevent = false;
            this.btn_logo_BIONIT.OutlinePixel = 1;
            this.btn_logo_BIONIT.RepeatInterval = 200;
            this.btn_logo_BIONIT.RepeatIntervalAccelerate = null;
            this.btn_logo_BIONIT.SafeInterval = 200;
            this.btn_logo_BIONIT.Size = new System.Drawing.Size(95, 32);
            this.btn_logo_BIONIT.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_logo_BIONIT.TabIndex = 89;
            this.btn_logo_BIONIT.TextColor = System.Drawing.Color.Black;
            this.btn_logo_BIONIT.TextDownColor = System.Drawing.Color.White;
            this.btn_logo_BIONIT.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_logo_BIONIT.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_logo_BIONIT.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_logo_BIONIT.UpImage = ((System.Drawing.Image)(resources.GetObject("btn_logo_BIONIT.UpImage")));
            // 
            // btn_logo_AutoFeeder
            // 
            this.btn_logo_AutoFeeder.BackPictureBox = null;
            this.btn_logo_AutoFeeder.BackPictureBox1 = null;
            this.btn_logo_AutoFeeder.BackPictureBox2 = null;
            this.btn_logo_AutoFeeder.ButtonColor = System.Drawing.Color.Gray;
            this.btn_logo_AutoFeeder.ButtonImageAutoSize = true;
            this.btn_logo_AutoFeeder.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_logo_AutoFeeder.DisableImage = ((System.Drawing.Image)(resources.GetObject("btn_logo_AutoFeeder.DisableImage")));
            this.btn_logo_AutoFeeder.DownImage = null;
            this.btn_logo_AutoFeeder.Enabled = false;
            this.btn_logo_AutoFeeder.GroupID = 0;
            this.btn_logo_AutoFeeder.InitVisible = true;
            this.btn_logo_AutoFeeder.Location = new System.Drawing.Point(9, 562);
            this.btn_logo_AutoFeeder.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_logo_AutoFeeder.Name = "btn_logo_AutoFeeder";
            this.btn_logo_AutoFeeder.NestedClickEventPrevent = false;
            this.btn_logo_AutoFeeder.OutlinePixel = 1;
            this.btn_logo_AutoFeeder.RepeatInterval = 200;
            this.btn_logo_AutoFeeder.RepeatIntervalAccelerate = null;
            this.btn_logo_AutoFeeder.SafeInterval = 200;
            this.btn_logo_AutoFeeder.Size = new System.Drawing.Size(219, 35);
            this.btn_logo_AutoFeeder.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_logo_AutoFeeder.TabIndex = 89;
            this.btn_logo_AutoFeeder.TextColor = System.Drawing.Color.Black;
            this.btn_logo_AutoFeeder.TextDownColor = System.Drawing.Color.White;
            this.btn_logo_AutoFeeder.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_logo_AutoFeeder.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_logo_AutoFeeder.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_logo_AutoFeeder.UpImage = ((System.Drawing.Image)(resources.GetObject("btn_logo_AutoFeeder.UpImage")));
            // 
            // smartUpdate1
            // 
            this.smartUpdate1.BackImageFilePathName = null;
            this.smartUpdate1.CompanyText = "BIONIT Co.";
            this.smartUpdate1.CompanyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.smartUpdate1.FromFilePath = "하드 디스크\\UpdateFiles";
            this.smartUpdate1.MessageText = "응용프로그램을 업데이트 하고 있습니다. 잠시만 기다려 주시기 바랍니다....!!!";
            this.smartUpdate1.MessageTextColor = System.Drawing.Color.Blue;
            this.smartUpdate1.Restart = SmartX.SmartUpdate.RESTARTFLAG.REBOOTING;
            this.smartUpdate1.SetStartInterval = ((uint)(3000u));
            this.smartUpdate1.TitleText = "[[[ AutoFeeder Update ]]]";
            this.smartUpdate1.TitleTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.smartUpdate1.ToFilePath = "Flash Disk\\Run";
            // 
            // smartTimer2
            // 
            this.smartTimer2.EndTime = ((long)(100000000000));
            this.smartTimer2.Interval = 100;
            this.smartTimer2.IntervalSeries = null;
            this.smartTimer2.NowMillisecond = ((long)(0));
            this.smartTimer2.StartTime = ((long)(0));
            this.smartTimer2.Tick += new System.EventHandler(this.smartTimer2_Tick);
            // 
            // smartLabel_VERSION
            // 
            this.smartLabel_VERSION.BackColor = System.Drawing.Color.Silver;
            this.smartLabel_VERSION.BackPictureBox = null;
            this.smartLabel_VERSION.BackPictureBox1 = null;
            this.smartLabel_VERSION.BackPictureBox2 = null;
            this.smartLabel_VERSION.BorderColor = System.Drawing.Color.Transparent;
            this.smartLabel_VERSION.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smartLabel_VERSION.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.smartLabel_VERSION.InitVisible = true;
            this.smartLabel_VERSION.LineSpacing = 0F;
            this.smartLabel_VERSION.Location = new System.Drawing.Point(215, 579);
            this.smartLabel_VERSION.Name = "smartLabel_VERSION";
            this.smartLabel_VERSION.Size = new System.Drawing.Size(132, 18);
            this.smartLabel_VERSION.TabIndex = 90;
            this.smartLabel_VERSION.Text = "ver 1.3";
            this.smartLabel_VERSION.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.smartLabel_VERSION.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
            this.smartLabel_VERSION.Wordwrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.smartLabel_VERSION);
            this.Controls.Add(this.btn_logo_AutoFeeder);
            this.Controls.Add(this.btn_logo_BIONIT);
            this.Controls.Add(this.smartLabel5);
            this.Controls.Add(this.btn_AutoStopModeOff);
            this.Controls.Add(this.btn_AutoStopModeOn);
            this.Controls.Add(this.smartLabel7);
            this.Controls.Add(this.smartLabel1);
            this.Controls.Add(this.btn_BarcodeReadOff);
            this.Controls.Add(this.btn_BarcodeReadOn);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_runTime);
            this.Controls.Add(this.smartLabel6);
            this.Controls.Add(this.label_curTime);
            this.Controls.Add(this.smartLabel4);
            this.Controls.Add(this.label_scanCount);
            this.Controls.Add(this.smartLabel2);
            this.Controls.Add(this.label_indicator);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smartListBox_log);
            this.Controls.Add(this.label_keybuffer);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.buttonTest1);
            this.Controls.Add(this.smartLabel3);
            this.Controls.Add(this.smartForm1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "ver1.3_20201010";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartLabel smartLabel3;
        private SmartX.SmartButton buttonTest1;
        private SmartX.SmartButton btn_setting;
        private System.Windows.Forms.Label label_keybuffer;
        private SmartX.SmartListBox smartListBox_log;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private SmartX.SmartForm smartForm1;
        private SmartX.SmartButton btn_start;
        private SmartX.SmartButton btn_stop;
        private SmartX.SmartLabel label_indicator;
        private SmartX.SmartLabel smartLabel2;
        private SmartX.SmartLabel label_scanCount;
        private SmartX.SmartLabel label_curTime;
        private SmartX.SmartLabel smartLabel4;
        private SmartX.SmartLabel label_runTime;
        private SmartX.SmartLabel smartLabel6;
        private SmartX.SmartTimer smartTimer1;
        private SmartX.SmartMemory smartMemory1;
        private System.Windows.Forms.Label label1;
        private SmartX.SmartButton btn_Exit;
        private SmartX.SmartButton btn_BarcodeReadOn;
        private SmartX.SmartButton btn_BarcodeReadOff;
        private SmartX.SmartLabel smartLabel1;
        private SmartX.SmartLabel smartLabel5;
        private SmartX.SmartButton btn_AutoStopModeOff;
        private SmartX.SmartButton btn_AutoStopModeOn;
        private SmartX.SmartLabel smartLabel7;
        private SmartX.SmartButton btn_logo_BIONIT;
        private SmartX.SmartButton btn_logo_AutoFeeder;
        private SmartX.SmartUpdate smartUpdate1;
        private SmartX.SmartTimer smartTimer2;
        private SmartX.SmartLabel smartLabel_VERSION;
        private System.IO.Ports.SerialPort serialPort2;
    }
}

