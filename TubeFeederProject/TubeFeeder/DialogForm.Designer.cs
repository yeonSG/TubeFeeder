namespace TubeFeeder
{
    partial class DialogForm
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btn_OK = new SmartX.SmartButton();
            this.btn_cancel = new SmartX.SmartButton();
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
            this.btn_OK.GroupID = 0;
            this.btn_OK.InitVisible = true;
            this.btn_OK.Location = new System.Drawing.Point(75, 132);
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
            this.btn_OK.Text = "OK";
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
            this.btn_cancel.GroupID = 0;
            this.btn_cancel.InitVisible = true;
            this.btn_cancel.Location = new System.Drawing.Point(231, 132);
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
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Menu = this.mainMenu1;
            this.Name = "DialogForm";
            this.Text = "dialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartButton btn_OK;
        private SmartX.SmartButton btn_cancel;
    }
}