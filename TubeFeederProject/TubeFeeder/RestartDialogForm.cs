using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TubeFeeder
{
    public partial class RestartDialogForm : Form
    {
        public RestartDialogForm()
        {
            InitializeComponent();
            SettingValuesToUI();            
            InitialDialog();
        }

        private void SettingValuesToUI()
        {
        }

        private void InitialDialog() 
        {
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}