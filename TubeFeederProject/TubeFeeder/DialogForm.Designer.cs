namespace TubeFeeder
{
    partial class DialogForm
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
            this.btn_OK = new SmartX.SmartButton();
            this.btn_cancel = new SmartX.SmartButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_conveyorSpeed = new System.Windows.Forms.ComboBox();
            this.comboBox_xXaisDistance = new System.Windows.Forms.ComboBox();
            this.comboBox_converterRollerSpeed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.smartButton_ftp_connect = new SmartX.SmartButton();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_ftp_id = new System.Windows.Forms.TextBox();
            this.textBox_ftp_pw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.smartButton_sendAll = new SmartX.SmartButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label_logFile_count = new System.Windows.Forms.Label();
            this.smartButton_removeLogFile = new SmartX.SmartButton();
            this.label_upload_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackPictureBox = null;
            this.btn_OK.BackPictureBox1 = null;
            this.btn_OK.BackPictureBox2 = null;
            this.btn_OK.ButtonColor = System.Drawing.Color.Gray;
            this.btn_OK.ButtonImageAutoSize = true;
            this.btn_OK.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_OK.DisableImage = null;
            this.btn_OK.DownImage = null;
            this.btn_OK.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btn_OK.GroupID = 0;
            this.btn_OK.InitVisible = true;
            this.btn_OK.Location = new System.Drawing.Point(145, 179);
            this.btn_OK.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.NestedClickEventPrevent = false;
            this.btn_OK.OutlinePixel = 1;
            this.btn_OK.RepeatInterval = 200;
            this.btn_OK.RepeatIntervalAccelerate = null;
            this.btn_OK.SafeInterval = 200;
            this.btn_OK.Size = new System.Drawing.Size(108, 43);
            this.btn_OK.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "SAVE";
            this.btn_OK.TextColor = System.Drawing.Color.Black;
            this.btn_OK.TextDownColor = System.Drawing.Color.White;
            this.btn_OK.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_OK.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_OK.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_OK.UpImage = null;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackPictureBox = null;
            this.btn_cancel.BackPictureBox1 = null;
            this.btn_cancel.BackPictureBox2 = null;
            this.btn_cancel.ButtonColor = System.Drawing.Color.Gray;
            this.btn_cancel.ButtonImageAutoSize = true;
            this.btn_cancel.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.btn_cancel.DisableImage = null;
            this.btn_cancel.DownImage = null;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.GroupID = 0;
            this.btn_cancel.InitVisible = true;
            this.btn_cancel.Location = new System.Drawing.Point(270, 179);
            this.btn_cancel.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NestedClickEventPrevent = false;
            this.btn_cancel.OutlinePixel = 1;
            this.btn_cancel.RepeatInterval = 200;
            this.btn_cancel.RepeatIntervalAccelerate = null;
            this.btn_cancel.SafeInterval = 200;
            this.btn_cancel.Size = new System.Drawing.Size(108, 43);
            this.btn_cancel.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextColor = System.Drawing.Color.Black;
            this.btn_cancel.TextDownColor = System.Drawing.Color.White;
            this.btn_cancel.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_cancel.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_cancel.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_cancel.UpImage = null;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.Text = "Conveyor belt speed";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.Text = "X axis distance";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.Text = "Converter roller speed";
            // 
            // comboBox_conveyorSpeed
            // 
            this.comboBox_conveyorSpeed.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.comboBox_conveyorSpeed.Items.Add("1");
            this.comboBox_conveyorSpeed.Items.Add("2");
            this.comboBox_conveyorSpeed.Items.Add("3");
            this.comboBox_conveyorSpeed.Location = new System.Drawing.Point(246, 28);
            this.comboBox_conveyorSpeed.Name = "comboBox_conveyorSpeed";
            this.comboBox_conveyorSpeed.Size = new System.Drawing.Size(132, 31);
            this.comboBox_conveyorSpeed.TabIndex = 8;
            this.comboBox_conveyorSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBox_conveyorSpeed_SelectedIndexChanged);
            // 
            // comboBox_xXaisDistance
            // 
            this.comboBox_xXaisDistance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.comboBox_xXaisDistance.Items.Add("1");
            this.comboBox_xXaisDistance.Items.Add("2");
            this.comboBox_xXaisDistance.Items.Add("3");
            this.comboBox_xXaisDistance.Items.Add("4");
            this.comboBox_xXaisDistance.Items.Add("5");
            this.comboBox_xXaisDistance.Items.Add("6");
            this.comboBox_xXaisDistance.Items.Add("7");
            this.comboBox_xXaisDistance.Items.Add("8");
            this.comboBox_xXaisDistance.Items.Add("9");
            this.comboBox_xXaisDistance.Items.Add("MAX");
            this.comboBox_xXaisDistance.Location = new System.Drawing.Point(246, 75);
            this.comboBox_xXaisDistance.Name = "comboBox_xXaisDistance";
            this.comboBox_xXaisDistance.Size = new System.Drawing.Size(132, 31);
            this.comboBox_xXaisDistance.TabIndex = 9;
            this.comboBox_xXaisDistance.SelectedIndexChanged += new System.EventHandler(this.comboBox_xXaisDistance_SelectedIndexChanged);
            // 
            // comboBox_converterRollerSpeed
            // 
            this.comboBox_converterRollerSpeed.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.comboBox_converterRollerSpeed.Items.Add("1");
            this.comboBox_converterRollerSpeed.Items.Add("2");
            this.comboBox_converterRollerSpeed.Location = new System.Drawing.Point(246, 121);
            this.comboBox_converterRollerSpeed.Name = "comboBox_converterRollerSpeed";
            this.comboBox_converterRollerSpeed.Size = new System.Drawing.Size(132, 31);
            this.comboBox_converterRollerSpeed.TabIndex = 10;
            this.comboBox_converterRollerSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBox_converterRollerSpeed_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(228, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(228, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(228, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.Text = ":";
            // 
            // smartButton_ftp_connect
            // 
            this.smartButton_ftp_connect.BackPictureBox = null;
            this.smartButton_ftp_connect.BackPictureBox1 = null;
            this.smartButton_ftp_connect.BackPictureBox2 = null;
            this.smartButton_ftp_connect.ButtonColor = System.Drawing.Color.Gray;
            this.smartButton_ftp_connect.ButtonImageAutoSize = true;
            this.smartButton_ftp_connect.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.smartButton_ftp_connect.DisableImage = null;
            this.smartButton_ftp_connect.DownImage = null;
            this.smartButton_ftp_connect.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.smartButton_ftp_connect.GroupID = 0;
            this.smartButton_ftp_connect.InitVisible = true;
            this.smartButton_ftp_connect.Location = new System.Drawing.Point(427, 121);
            this.smartButton_ftp_connect.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.smartButton_ftp_connect.Name = "smartButton_ftp_connect";
            this.smartButton_ftp_connect.NestedClickEventPrevent = false;
            this.smartButton_ftp_connect.OutlinePixel = 1;
            this.smartButton_ftp_connect.RepeatInterval = 200;
            this.smartButton_ftp_connect.RepeatIntervalAccelerate = null;
            this.smartButton_ftp_connect.SafeInterval = 200;
            this.smartButton_ftp_connect.Size = new System.Drawing.Size(216, 23);
            this.smartButton_ftp_connect.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.smartButton_ftp_connect.TabIndex = 0;
            this.smartButton_ftp_connect.Text = "Connect";
            this.smartButton_ftp_connect.TextColor = System.Drawing.Color.Black;
            this.smartButton_ftp_connect.TextDownColor = System.Drawing.Color.White;
            this.smartButton_ftp_connect.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.smartButton_ftp_connect.TextLocation = new System.Drawing.Point(0, 0);
            this.smartButton_ftp_connect.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.smartButton_ftp_connect.UpImage = null;
            this.smartButton_ftp_connect.Click += new System.EventHandler(this.smartButton_ftp_connect_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(572, 27);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(89, 23);
            this.textBox_IP.TabIndex = 17;
            this.textBox_IP.Text = "192.168.0.15";
            // 
            // textBox_ftp_id
            // 
            this.textBox_ftp_id.Location = new System.Drawing.Point(572, 56);
            this.textBox_ftp_id.Name = "textBox_ftp_id";
            this.textBox_ftp_id.Size = new System.Drawing.Size(89, 23);
            this.textBox_ftp_id.TabIndex = 17;
            this.textBox_ftp_id.Text = "admin";
            // 
            // textBox_ftp_pw
            // 
            this.textBox_ftp_pw.Location = new System.Drawing.Point(572, 85);
            this.textBox_ftp_pw.Name = "textBox_ftp_pw";
            this.textBox_ftp_pw.Size = new System.Drawing.Size(89, 23);
            this.textBox_ftp_pw.TabIndex = 17;
            this.textBox_ftp_pw.Text = "admin";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(409, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.Text = "FTP Server IP";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(409, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.Text = "FTP Server ID";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(409, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.Text = "FTP Server PW";
            // 
            // smartButton_sendAll
            // 
            this.smartButton_sendAll.BackPictureBox = null;
            this.smartButton_sendAll.BackPictureBox1 = null;
            this.smartButton_sendAll.BackPictureBox2 = null;
            this.smartButton_sendAll.ButtonColor = System.Drawing.Color.Gray;
            this.smartButton_sendAll.ButtonImageAutoSize = true;
            this.smartButton_sendAll.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.smartButton_sendAll.DisableImage = null;
            this.smartButton_sendAll.DownImage = null;
            this.smartButton_sendAll.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.smartButton_sendAll.GroupID = 0;
            this.smartButton_sendAll.InitVisible = true;
            this.smartButton_sendAll.Location = new System.Drawing.Point(572, 159);
            this.smartButton_sendAll.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.smartButton_sendAll.Name = "smartButton_sendAll";
            this.smartButton_sendAll.NestedClickEventPrevent = false;
            this.smartButton_sendAll.OutlinePixel = 1;
            this.smartButton_sendAll.RepeatInterval = 200;
            this.smartButton_sendAll.RepeatIntervalAccelerate = null;
            this.smartButton_sendAll.SafeInterval = 200;
            this.smartButton_sendAll.Size = new System.Drawing.Size(89, 23);
            this.smartButton_sendAll.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.smartButton_sendAll.TabIndex = 0;
            this.smartButton_sendAll.Text = "Send All";
            this.smartButton_sendAll.TextColor = System.Drawing.Color.Black;
            this.smartButton_sendAll.TextDownColor = System.Drawing.Color.White;
            this.smartButton_sendAll.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.smartButton_sendAll.TextLocation = new System.Drawing.Point(0, 0);
            this.smartButton_sendAll.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.smartButton_sendAll.UpImage = null;
            this.smartButton_sendAll.Click += new System.EventHandler(this.smartButton_sendAll_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(409, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.Text = "LogFiles :";
            // 
            // label_logFile_count
            // 
            this.label_logFile_count.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_logFile_count.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_logFile_count.Location = new System.Drawing.Point(509, 159);
            this.label_logFile_count.Name = "label_logFile_count";
            this.label_logFile_count.Size = new System.Drawing.Size(57, 20);
            this.label_logFile_count.Text = "0";
            // 
            // smartButton_removeLogFile
            // 
            this.smartButton_removeLogFile.BackPictureBox = null;
            this.smartButton_removeLogFile.BackPictureBox1 = null;
            this.smartButton_removeLogFile.BackPictureBox2 = null;
            this.smartButton_removeLogFile.ButtonColor = System.Drawing.Color.Gray;
            this.smartButton_removeLogFile.ButtonImageAutoSize = true;
            this.smartButton_removeLogFile.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.smartButton_removeLogFile.DisableImage = null;
            this.smartButton_removeLogFile.DownImage = null;
            this.smartButton_removeLogFile.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.smartButton_removeLogFile.GroupID = 0;
            this.smartButton_removeLogFile.InitVisible = true;
            this.smartButton_removeLogFile.Location = new System.Drawing.Point(409, 211);
            this.smartButton_removeLogFile.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.smartButton_removeLogFile.Name = "smartButton_removeLogFile";
            this.smartButton_removeLogFile.NestedClickEventPrevent = false;
            this.smartButton_removeLogFile.OutlinePixel = 1;
            this.smartButton_removeLogFile.RepeatInterval = 200;
            this.smartButton_removeLogFile.RepeatIntervalAccelerate = null;
            this.smartButton_removeLogFile.SafeInterval = 200;
            this.smartButton_removeLogFile.Size = new System.Drawing.Size(123, 23);
            this.smartButton_removeLogFile.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.smartButton_removeLogFile.TabIndex = 0;
            this.smartButton_removeLogFile.Text = "Remove All";
            this.smartButton_removeLogFile.TextColor = System.Drawing.Color.Black;
            this.smartButton_removeLogFile.TextDownColor = System.Drawing.Color.White;
            this.smartButton_removeLogFile.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.smartButton_removeLogFile.TextLocation = new System.Drawing.Point(0, 0);
            this.smartButton_removeLogFile.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.smartButton_removeLogFile.UpImage = null;
            this.smartButton_removeLogFile.Click += new System.EventHandler(this.smartButton_removeLogFile_Click);
            // 
            // label_upload_result
            // 
            this.label_upload_result.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_upload_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_upload_result.Location = new System.Drawing.Point(572, 185);
            this.label_upload_result.Name = "label_upload_result";
            this.label_upload_result.Size = new System.Drawing.Size(89, 20);
            this.label_upload_result.Text = "0/0";
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(698, 250);
            this.Controls.Add(this.label_upload_result);
            this.Controls.Add(this.textBox_ftp_pw);
            this.Controls.Add(this.textBox_ftp_id);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.comboBox_converterRollerSpeed);
            this.Controls.Add(this.comboBox_xXaisDistance);
            this.Controls.Add(this.comboBox_conveyorSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_logFile_count);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.smartButton_removeLogFile);
            this.Controls.Add(this.smartButton_sendAll);
            this.Controls.Add(this.smartButton_ftp_connect);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "DialogForm";
            this.Text = "dialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartButton btn_OK;
        private SmartX.SmartButton btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_conveyorSpeed;
        private System.Windows.Forms.ComboBox comboBox_xXaisDistance;
        private System.Windows.Forms.ComboBox comboBox_converterRollerSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private SmartX.SmartButton smartButton_ftp_connect;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_ftp_id;
        private System.Windows.Forms.TextBox textBox_ftp_pw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private SmartX.SmartButton smartButton_sendAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_logFile_count;
        private SmartX.SmartButton smartButton_removeLogFile;
        private System.Windows.Forms.Label label_upload_result;
    }
}