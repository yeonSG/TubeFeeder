using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TubeFeeder
{
    public partial class DialogForm : Form
    {
        SettingValues m_values;

        public DialogForm(SettingValues values)
        {
            m_values = values;
            InitializeComponent();

            SettingValuesToUI();
        }

        private void SettingValuesToUI()
        {
            if (comboBox_conveyorSpeed.Items.Count > m_values.value_conveyorSpeed - 1)      
                comboBox_conveyorSpeed.SelectedIndex = m_values.value_conveyorSpeed - 1;    
            else
                comboBox_conveyorSpeed.SelectedIndex = 0;

            if (comboBox_xXaisDistance.Items.Count > m_values.value_XAxisDistance - 1)
                comboBox_xXaisDistance.SelectedIndex = m_values.value_XAxisDistance - 1;
            else
                comboBox_conveyorSpeed.SelectedIndex = 0;

            if (comboBox_converterRollerSpeed.Items.Count > m_values.value_ConvererRollerSpeed - 1)   
                comboBox_converterRollerSpeed.SelectedIndex = m_values.value_ConvererRollerSpeed - 1;
            else
                comboBox_converterRollerSpeed.SelectedIndex = 0;

            //if (trackBar_conveyorSpeed.Minimum <= m_values.value_ConvererRollerSpeed 
            //    && trackBar_conveyorSpeed.Maximum>=m_values.value_ConvererRollerSpeed)
            //    trackBar_conveyorSpeed.Value = m_values.value_ConvererRollerSpeed;

            //if (trackBar_xXaisDistance.Minimum <= m_values.value_XAxisDistance
            //    && trackBar_xXaisDistance.Maximum >= m_values.value_XAxisDistance)
            //    trackBar_xXaisDistance.Value = m_values.value_XAxisDistance;

            //if (trackBar_converterRollerSpeed.Minimum <= m_values.value_ConvererRollerSpeed
            //    && trackBar_converterRollerSpeed.Maximum >= m_values.value_ConvererRollerSpeed)
            //    trackBar_converterRollerSpeed.Value = m_values.value_ConvererRollerSpeed;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            m_values.value_conveyorSpeed = int.Parse(comboBox_conveyorSpeed.SelectedItem.ToString());
            m_values.value_XAxisDistance = int.Parse(comboBox_xXaisDistance.SelectedItem.ToString());
            m_values.value_ConvererRollerSpeed = int.Parse(comboBox_converterRollerSpeed.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox_conveyorSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}