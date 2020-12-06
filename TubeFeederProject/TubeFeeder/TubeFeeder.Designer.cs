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
            this.label1 = new System.Windows.Forms.Label();
            this.smartButton1 = new System.Windows.Forms.Button();
            this.comboPortNo = new SmartX.SmartComboBox();
            this.comboBaud = new SmartX.SmartComboBox();
            this.smartSerialPort1 = new SmartX.SmartSerialPort();
            this.buttonOPEN = new SmartX.SmartButton();
            this.buttonCLOSE = new SmartX.SmartButton();
            this.label_keybuffer = new System.Windows.Forms.Label();
            this.smartListBox_log = new SmartX.SmartListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(322, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 100);
            this.label1.Text = "label1";
            // 
            // smartButton1
            // 
            this.smartButton1.Location = new System.Drawing.Point(118, 17);
            this.smartButton1.Name = "smartButton1";
            this.smartButton1.Size = new System.Drawing.Size(171, 31);
            this.smartButton1.TabIndex = 1;
            this.smartButton1.Text = "hello";
            this.smartButton1.Click += new System.EventHandler(this.smartButton1_Click_1);
            // 
            // comboPortNo
            // 
            this.comboPortNo.AutoResize = false;
            this.comboPortNo.BackColor = System.Drawing.Color.White;
            this.comboPortNo.BackPictureBox = null;
            this.comboPortNo.BackPictureBox1 = null;
            this.comboPortNo.BackPictureBox2 = null;
            this.comboPortNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboPortNo.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle2;
            this.comboPortNo.DropDownButtonDownImage = null;
            this.comboPortNo.DropDownButtonLocation = new System.Drawing.Point(103, 2);
            this.comboPortNo.DropDownButtonSize = new System.Drawing.Size(32, 24);
            this.comboPortNo.DropDownButtonText = "▼";
            this.comboPortNo.DropDownButtonUpImage = null;
            this.comboPortNo.DropDownHeight = 115;
            this.comboPortNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboPortNo.ForeColor = System.Drawing.Color.Black;
            this.comboPortNo.InitVisible = true;
            this.comboPortNo.ItemListBackImage = null;
            this.comboPortNo.ItemListBackPictureBoxApply = false;
            this.comboPortNo.ItemListFontColor = System.Drawing.Color.Black;
            this.comboPortNo.ItemListItemOffsetGap = 10;
            this.comboPortNo.ItemListItemOffsetX = 3;
            this.comboPortNo.ItemListItemOffsetY = 0;
            this.comboPortNo.ItemListLocation = new System.Drawing.Point(2, 27);
            this.comboPortNo.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboPortNo.ItemListSelectFilled = true;
            this.comboPortNo.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboPortNo.ItemListSelectItemIndex = -1;
            this.comboPortNo.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboPortNo.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboPortNo.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboPortNo.ItemListSeparationlineVisibleBottom = true;
            this.comboPortNo.ItemListSeparationlineVisibleTop = true;
            this.comboPortNo.ItemListSize = new System.Drawing.Size(103, 110);
            this.comboPortNo.ItemListviewDesigntime = false;
            this.comboPortNo.Location = new System.Drawing.Point(9, 159);
            this.comboPortNo.Name = "comboPortNo";
            this.comboPortNo.ScrollDownButtonDownImage = null;
            this.comboPortNo.ScrollDownButtonLocation = new System.Drawing.Point(103, 85);
            this.comboPortNo.ScrollDownButtonSize = new System.Drawing.Size(32, 55);
            this.comboPortNo.ScrollDownButtonText = "▼";
            this.comboPortNo.ScrollDownButtonUpImage = null;
            this.comboPortNo.ScrollUpButtonDownImage = null;
            this.comboPortNo.ScrollUpButtonLocation = new System.Drawing.Point(103, 28);
            this.comboPortNo.ScrollUpButtonSize = new System.Drawing.Size(32, 55);
            this.comboPortNo.ScrollUpButtonText = "▲";
            this.comboPortNo.ScrollUpButtonUpImage = null;
            this.comboPortNo.Size = new System.Drawing.Size(137, 29);
            this.comboPortNo.TabIndex = 37;
            this.comboPortNo.TextLeftOffset = 3;
            // 
            // comboBaud
            // 
            this.comboBaud.AutoResize = false;
            this.comboBaud.BackColor = System.Drawing.Color.White;
            this.comboBaud.BackPictureBox = null;
            this.comboBaud.BackPictureBox1 = null;
            this.comboBaud.BackPictureBox2 = null;
            this.comboBaud.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.comboBaud.BorderStyle = SmartX.SmartComboBox.BORDERSTYLES.FixedSingle2;
            this.comboBaud.DropDownButtonDownImage = null;
            this.comboBaud.DropDownButtonLocation = new System.Drawing.Point(103, 2);
            this.comboBaud.DropDownButtonSize = new System.Drawing.Size(32, 25);
            this.comboBaud.DropDownButtonText = "▼";
            this.comboBaud.DropDownButtonUpImage = null;
            this.comboBaud.DropDownHeight = 265;
            this.comboBaud.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.comboBaud.ForeColor = System.Drawing.Color.Black;
            this.comboBaud.InitVisible = true;
            this.comboBaud.ItemListBackImage = null;
            this.comboBaud.ItemListBackPictureBoxApply = false;
            this.comboBaud.ItemListFontColor = System.Drawing.Color.Black;
            this.comboBaud.ItemListItemOffsetGap = 10;
            this.comboBaud.ItemListItemOffsetX = 3;
            this.comboBaud.ItemListItemOffsetY = 0;
            this.comboBaud.ItemListLocation = new System.Drawing.Point(2, 28);
            this.comboBaud.ItemListSelectColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBaud.ItemListSelectFilled = true;
            this.comboBaud.ItemListSelectFontColor = System.Drawing.Color.White;
            this.comboBaud.ItemListSelectItemIndex = -1;
            this.comboBaud.ItemListSeparationlineColor1 = System.Drawing.Color.Gray;
            this.comboBaud.ItemListSeparationlineColor2 = System.Drawing.Color.LightGray;
            this.comboBaud.ItemListSeparationLineStyle = SmartX.SmartListBox.SEPARATIONLINETYPES.FixedSingle;
            this.comboBaud.ItemListSeparationlineVisibleBottom = true;
            this.comboBaud.ItemListSeparationlineVisibleTop = true;
            this.comboBaud.ItemListSize = new System.Drawing.Size(103, 260);
            this.comboBaud.ItemListviewDesigntime = false;
            this.comboBaud.Location = new System.Drawing.Point(152, 159);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.ScrollDownButtonDownImage = null;
            this.comboBaud.ScrollDownButtonLocation = new System.Drawing.Point(103, 160);
            this.comboBaud.ScrollDownButtonSize = new System.Drawing.Size(32, 130);
            this.comboBaud.ScrollDownButtonText = "▼";
            this.comboBaud.ScrollDownButtonUpImage = null;
            this.comboBaud.ScrollUpButtonDownImage = null;
            this.comboBaud.ScrollUpButtonLocation = new System.Drawing.Point(103, 29);
            this.comboBaud.ScrollUpButtonSize = new System.Drawing.Size(32, 130);
            this.comboBaud.ScrollUpButtonText = "▲";
            this.comboBaud.ScrollUpButtonUpImage = null;
            this.comboBaud.Size = new System.Drawing.Size(137, 29);
            this.comboBaud.TabIndex = 38;
            this.comboBaud.TextLeftOffset = 3;
            // 
            // smartSerialPort1
            // 
            this.smartSerialPort1.Baud_Rate = SmartX.SmartSerialPort.BAUDRATE._9600bps;
            this.smartSerialPort1.ErrorCheckCodeType = SmartX.SmartSerialPort.ERRORCHECKCODETYPES.ASCIICODE;
            this.smartSerialPort1.ErrorCheckMode = SmartX.SmartSerialPort.ERRORCHECK.NONE;
            this.smartSerialPort1.ErrorCode_Location = SmartX.SmartSerialPort.ERRORCODELOCATION.HEADER;
            this.smartSerialPort1.ETXCode = ((byte)(3));
            this.smartSerialPort1.ETXCodes = null;
            this.smartSerialPort1.FrameBufferSize = ((uint)(1024u));
            this.smartSerialPort1.FrameSeparationType = SmartX.SmartSerialPort.FRAMESEPARATIONTYPES.STXANDETX;
            this.smartSerialPort1.HeadErrorCodeOffset = 0;
            this.smartSerialPort1.PortNo = SmartX.SmartSerialPort.COMPORTNO.COM1;
            this.smartSerialPort1.ReadTimeout = -1;
            this.smartSerialPort1.ReceiveDetect = SmartX.SmartSerialPort.RECEIVEDETECTTYPE.EVENT_QUEUE;
            this.smartSerialPort1.ReceiveFrameDebugMode = false;
            this.smartSerialPort1.RS485SoftwareDetection = false;
            this.smartSerialPort1.STXCode = ((byte)(2));
            this.smartSerialPort1.STXCodes = null;
            this.smartSerialPort1.TailErrorCodeOffset = 0;
            // 
            // buttonOPEN
            // 
            this.buttonOPEN.BackPictureBox = null;
            this.buttonOPEN.BackPictureBox1 = null;
            this.buttonOPEN.BackPictureBox2 = null;
            this.buttonOPEN.ButtonColor = System.Drawing.Color.Gray;
            this.buttonOPEN.ButtonImageAutoSize = true;
            this.buttonOPEN.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonOPEN.DisableImage = null;
            this.buttonOPEN.DownImage = null;
            this.buttonOPEN.GroupID = 0;
            this.buttonOPEN.InitVisible = true;
            this.buttonOPEN.Location = new System.Drawing.Point(128, 54);
            this.buttonOPEN.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonOPEN.Name = "buttonOPEN";
            this.buttonOPEN.NestedClickEventPrevent = false;
            this.buttonOPEN.OutlinePixel = 1;
            this.buttonOPEN.RepeatInterval = 200;
            this.buttonOPEN.RepeatIntervalAccelerate = null;
            this.buttonOPEN.SafeInterval = 200;
            this.buttonOPEN.Size = new System.Drawing.Size(81, 63);
            this.buttonOPEN.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonOPEN.TabIndex = 46;
            this.buttonOPEN.Text = "OPEN";
            this.buttonOPEN.TextColor = System.Drawing.Color.Black;
            this.buttonOPEN.TextDownColor = System.Drawing.Color.White;
            this.buttonOPEN.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonOPEN.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonOPEN.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonOPEN.UpImage = null;
            this.buttonOPEN.Click += new System.EventHandler(this.buttonOPEN_Click);
            // 
            // buttonCLOSE
            // 
            this.buttonCLOSE.BackPictureBox = null;
            this.buttonCLOSE.BackPictureBox1 = null;
            this.buttonCLOSE.BackPictureBox2 = null;
            this.buttonCLOSE.ButtonColor = System.Drawing.Color.Gray;
            this.buttonCLOSE.ButtonImageAutoSize = true;
            this.buttonCLOSE.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.buttonCLOSE.DisableImage = null;
            this.buttonCLOSE.DownImage = null;
            this.buttonCLOSE.GroupID = 0;
            this.buttonCLOSE.InitVisible = true;
            this.buttonCLOSE.Location = new System.Drawing.Point(209, 54);
            this.buttonCLOSE.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.buttonCLOSE.Name = "buttonCLOSE";
            this.buttonCLOSE.NestedClickEventPrevent = false;
            this.buttonCLOSE.OutlinePixel = 1;
            this.buttonCLOSE.RepeatInterval = 200;
            this.buttonCLOSE.RepeatIntervalAccelerate = null;
            this.buttonCLOSE.SafeInterval = 200;
            this.buttonCLOSE.Size = new System.Drawing.Size(80, 63);
            this.buttonCLOSE.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.buttonCLOSE.TabIndex = 47;
            this.buttonCLOSE.Text = "CLOSE";
            this.buttonCLOSE.TextColor = System.Drawing.Color.Black;
            this.buttonCLOSE.TextDownColor = System.Drawing.Color.White;
            this.buttonCLOSE.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.buttonCLOSE.TextLocation = new System.Drawing.Point(0, 0);
            this.buttonCLOSE.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.buttonCLOSE.UpImage = null;
            // 
            // label_keybuffer
            // 
            this.label_keybuffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_keybuffer.Location = new System.Drawing.Point(24, 402);
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
            this.smartListBox_log.Location = new System.Drawing.Point(23, 237);
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
            this.smartListBox_log.Size = new System.Drawing.Size(266, 162);
            this.smartListBox_log.TabIndex = 51;
            this.smartListBox_log.Text = "LogListBox";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.Text = "       DateTime                       Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smartListBox_log);
            this.Controls.Add(this.label_keybuffer);
            this.Controls.Add(this.buttonCLOSE);
            this.Controls.Add(this.buttonOPEN);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.comboPortNo);
            this.Controls.Add(this.smartButton1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button smartButton1;
        private SmartX.SmartComboBox comboPortNo;
        private SmartX.SmartComboBox comboBaud;
        private SmartX.SmartSerialPort smartSerialPort1;
        private SmartX.SmartButton buttonOPEN;
        private SmartX.SmartButton buttonCLOSE;
        private System.Windows.Forms.Label label_keybuffer;
        private SmartX.SmartListBox smartListBox_log;
        private System.Windows.Forms.Label label2;
    }
}

