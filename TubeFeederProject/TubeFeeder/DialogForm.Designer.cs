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
            this.label10 = new System.Windows.Forms.Label();
            this.label_logFile_count = new System.Windows.Forms.Label();
            this.smartButton_removeLogFile = new SmartX.SmartButton();
            this.label_upload_result = new System.Windows.Forms.Label();
            this.smartButton_sendUSB = new SmartX.SmartButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_memory = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(430, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.Text = "Log Files";
            // 
            // label_logFile_count
            // 
            this.label_logFile_count.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_logFile_count.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_logFile_count.Location = new System.Drawing.Point(576, 32);
            this.label_logFile_count.Name = "label_logFile_count";
            this.label_logFile_count.Size = new System.Drawing.Size(82, 20);
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
            this.smartButton_removeLogFile.Location = new System.Drawing.Point(430, 100);
            this.smartButton_removeLogFile.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.smartButton_removeLogFile.Name = "smartButton_removeLogFile";
            this.smartButton_removeLogFile.NestedClickEventPrevent = false;
            this.smartButton_removeLogFile.OutlinePixel = 1;
            this.smartButton_removeLogFile.RepeatInterval = 200;
            this.smartButton_removeLogFile.RepeatIntervalAccelerate = null;
            this.smartButton_removeLogFile.SafeInterval = 200;
            this.smartButton_removeLogFile.Size = new System.Drawing.Size(217, 34);
            this.smartButton_removeLogFile.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.smartButton_removeLogFile.TabIndex = 0;
            this.smartButton_removeLogFile.Text = "Remove LogFiles";
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
            this.label_upload_result.Location = new System.Drawing.Point(539, 202);
            this.label_upload_result.Name = "label_upload_result";
            this.label_upload_result.Size = new System.Drawing.Size(61, 20);
            this.label_upload_result.Text = "0/0";
            // 
            // smartButton_sendUSB
            // 
            this.smartButton_sendUSB.BackPictureBox = null;
            this.smartButton_sendUSB.BackPictureBox1 = null;
            this.smartButton_sendUSB.BackPictureBox2 = null;
            this.smartButton_sendUSB.ButtonColor = System.Drawing.Color.Gray;
            this.smartButton_sendUSB.ButtonImageAutoSize = true;
            this.smartButton_sendUSB.ColorKeySamplePosition = new System.Drawing.Point(0, 0);
            this.smartButton_sendUSB.DisableImage = null;
            this.smartButton_sendUSB.DownImage = null;
            this.smartButton_sendUSB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.smartButton_sendUSB.GroupID = 0;
            this.smartButton_sendUSB.InitVisible = true;
            this.smartButton_sendUSB.Location = new System.Drawing.Point(430, 153);
            this.smartButton_sendUSB.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.smartButton_sendUSB.Name = "smartButton_sendUSB";
            this.smartButton_sendUSB.NestedClickEventPrevent = false;
            this.smartButton_sendUSB.OutlinePixel = 1;
            this.smartButton_sendUSB.RepeatInterval = 200;
            this.smartButton_sendUSB.RepeatIntervalAccelerate = null;
            this.smartButton_sendUSB.SafeInterval = 200;
            this.smartButton_sendUSB.Size = new System.Drawing.Size(217, 33);
            this.smartButton_sendUSB.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.smartButton_sendUSB.TabIndex = 29;
            this.smartButton_sendUSB.Text = "Send LogFile to USB";
            this.smartButton_sendUSB.TextColor = System.Drawing.Color.Black;
            this.smartButton_sendUSB.TextDownColor = System.Drawing.Color.White;
            this.smartButton_sendUSB.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.smartButton_sendUSB.TextLocation = new System.Drawing.Point(0, 0);
            this.smartButton_sendUSB.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.smartButton_sendUSB.UpImage = null;
            this.smartButton_sendUSB.Click += new System.EventHandler(this.smartButton_sendUSB_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(439, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.Text = "Success :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(430, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.Text = "Disk Memory";
            // 
            // label_memory
            // 
            this.label_memory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_memory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_memory.Location = new System.Drawing.Point(576, 62);
            this.label_memory.Name = "label_memory";
            this.label_memory.Size = new System.Drawing.Size(82, 20);
            this.label_memory.Text = "0";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(549, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.Text = ":";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(549, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 20);
            this.label12.Text = ":";
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(698, 291);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.smartButton_sendUSB);
            this.Controls.Add(this.label_upload_result);
            this.Controls.Add(this.comboBox_converterRollerSpeed);
            this.Controls.Add(this.comboBox_xXaisDistance);
            this.Controls.Add(this.comboBox_conveyorSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_memory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_logFile_count);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.smartButton_removeLogFile);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_logFile_count;
        private SmartX.SmartButton smartButton_removeLogFile;
        private System.Windows.Forms.Label label_upload_result;
        private SmartX.SmartButton smartButton_sendUSB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_memory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}