namespace TubeFeeder
{
    partial class RestartDialogForm
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
            this.btn_OK.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Regular);
            this.btn_OK.GroupID = 0;
            this.btn_OK.InitVisible = true;
            this.btn_OK.Location = new System.Drawing.Point(50, 25);
            this.btn_OK.Mode = SmartX.SmartButton.BUTTONMODE.NORMAL;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.NestedClickEventPrevent = false;
            this.btn_OK.OutlinePixel = 1;
            this.btn_OK.RepeatInterval = 200;
            this.btn_OK.RepeatIntervalAccelerate = null;
            this.btn_OK.SafeInterval = 200;
            this.btn_OK.Size = new System.Drawing.Size(500, 450);
            this.btn_OK.SpecialFunction = SmartX.SmartButton.SPECIALFUNC.NONE;
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "RESTART";
            this.btn_OK.TextColor = System.Drawing.Color.Black;
            this.btn_OK.TextDownColor = System.Drawing.Color.White;
            this.btn_OK.TextHAlign = SmartX.SmartButton.TextHorAlign.Middle;
            this.btn_OK.TextLocation = new System.Drawing.Point(0, 0);
            this.btn_OK.TextVAlign = SmartX.SmartButton.TextVerAlign.Middle;
            this.btn_OK.UpImage = null;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // RestartDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(598, 475);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 50);
            this.Name = "RestartDialogForm";
            this.Text = "dialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SmartX.SmartButton btn_OK;
    }
}