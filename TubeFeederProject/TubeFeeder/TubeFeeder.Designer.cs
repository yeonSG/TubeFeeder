namespace TubeFeeder
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.buttonTest1 = new SmartX.SmartButton();
            this.buttonTest2 = new SmartX.SmartButton();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).BeginInit();
            this.SuspendLayout();
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
            // buttonTest2
            // 
            this.buttonTest2.BackPictureBox = null;
            this.buttonTest2.BackPictureBox1 = null;
            this.buttonTest2.BackPictureBox2 = null;
            this.buttonTest2.ButtonColor = System.Drawing.Color.Gray;
            this.buttonTest2.ButtonImageAutoSize = true;
            this.buttonTest2.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonTest2.DisableImage = null;
            this.buttonTest2.DownImage = null;
            this.buttonTest2.GroupID = 0;
            this.buttonTest2.InitVisible = true;
            this.buttonTest2.Location = new System.Drawing.Point(504, 30);
            this.buttonTest2.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.NestedClickEventPrevent = false;
            this.buttonTest2.OutlinePixel = 1;
            this.buttonTest2.RepeatInterval = 200;
            this.buttonTest2.RepeatIntervalAccelerate = null;
            this.buttonTest2.SafeInterval = 200;
            this.buttonTest2.Size = new System.Drawing.Size(80, 63);
            this.buttonTest2.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonTest2.TabIndex = 47;
            this.buttonTest2.Text = "test2";
            this.buttonTest2.TextColor = System.Drawing.Color.Black;
            this.buttonTest2.TextDownColor = System.Drawing.Color.White;
            this.buttonTest2.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonTest2.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonTest2.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonTest2.UpImage = null;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
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
            this.smartListBox_log.Location = new System.Drawing.Point(0, 96);
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
            this.smartListBox_log.Size = new System.Drawing.Size(400, 465);
            this.smartListBox_log.TabIndex = 51;
            this.smartListBox_log.Text = "LogListBox";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.Text = "       DateTime                                Log";
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
            this.smartForm1.Mode = SmartX.SmartForm.RUNMODE.DEVELOPER;
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
            this.btn_start.ButtonImageAutoSize = true;
            this.btn_start.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_start.DisableImage = null;
            this.btn_start.DownImage = null;
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
            this.btn_start.Size = new System.Drawing.Size(300, 300);
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
            this.btn_stop.GroupID = 1;
            this.btn_stop.InitVisible = true;
            this.btn_stop.Location = new System.Drawing.Point(400, 300);
            this.btn_stop.Mode = SmartX.SmartButton.BUTTONMODE.RADIO;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.NestedClickEventPrevent = false;
            this.btn_stop.OutlinePixel = 1;
            this.btn_stop.RepeatInterval = 200;
            this.btn_stop.RepeatIntervalAccelerate = null;
            this.btn_stop.SafeInterval = 200;
            this.btn_stop.Size = new System.Drawing.Size(300, 300);
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
            this.label_indicator.Size = new System.Drawing.Size(100, 600);
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
            this.smartLabel2.InitVisible = true;
            this.smartLabel2.LineSpacing = 0F;
            this.smartLabel2.Location = new System.Drawing.Point(3, 564);
            this.smartLabel2.Name = "smartLabel2";
            this.smartLabel2.Size = new System.Drawing.Size(100, 33);
            this.smartLabel2.TabIndex = 62;
            this.smartLabel2.Text = "Scan count :";
            this.smartLabel2.TextHAlign = SmartX.SmartLabel.TextHorAlign.Middle;
            this.smartLabel2.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
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
            this.label_scanCount.InitVisible = true;
            this.label_scanCount.LineSpacing = 0F;
            this.label_scanCount.Location = new System.Drawing.Point(109, 564);
            this.label_scanCount.Name = "label_scanCount";
            this.label_scanCount.Size = new System.Drawing.Size(65, 33);
            this.label_scanCount.TabIndex = 63;
            this.label_scanCount.Text = "0개";
            this.label_scanCount.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
            this.label_scanCount.TextVAlign = SmartX.SmartLabel.TextVerAlign.Middle;
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
            this.label_curTime.InitVisible = true;
            this.label_curTime.LineSpacing = 0F;
            this.label_curTime.Location = new System.Drawing.Point(115, 12);
            this.label_curTime.Name = "label_curTime";
            this.label_curTime.Size = new System.Drawing.Size(125, 21);
            this.label_curTime.TabIndex = 65;
            this.label_curTime.Text = "0";
            this.label_curTime.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
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
            this.label_runTime.InitVisible = true;
            this.label_runTime.LineSpacing = 0F;
            this.label_runTime.Location = new System.Drawing.Point(115, 35);
            this.label_runTime.Name = "label_runTime";
            this.label_runTime.Size = new System.Drawing.Size(125, 21);
            this.label_runTime.TabIndex = 67;
            this.label_runTime.Text = "0";
            this.label_runTime.TextHAlign = SmartX.SmartLabel.TextHorAlign.Left;
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
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
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
            this.Controls.Add(this.buttonTest2);
            this.Controls.Add(this.buttonTest1);
            this.Controls.Add(this.smartForm1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "ver0.1_20201208";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.smartForm1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartButton buttonTest1;
        private SmartX.SmartButton buttonTest2;
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
        private System.Windows.Forms.Label label1;
    }
}

