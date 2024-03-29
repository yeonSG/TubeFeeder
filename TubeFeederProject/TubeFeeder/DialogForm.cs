﻿using System;
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
    public partial class DialogForm : Form
    {
        ControlBoard m_ControlBoard;
        SettingValues m_values;
        MemoryManager m_memoryManger;
        
        string[] m_logFilePath;

        public DialogForm(ControlBoard controlBoard, SettingValues values, MemoryManager memoryManger)
        {
            m_ControlBoard = controlBoard;
            m_values = values;
            m_memoryManger = memoryManger;
            InitializeComponent();
            SettingValuesToUI();            
            InitialDialog();
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

        private void InitialDialog() {
            try
            {
                // 참고 : https://docs.microsoft.com/ko-kr/dotnet/api/system.io.directory.getfiles?view=net-6.0
                String path = IniFileManager.SECTION_LOGFILE_DIR_DEFAULT;
                m_logFilePath = Directory.GetFiles(path);

                label_memory.Text = m_memoryManger.getUsageString();
            }
            catch (Exception e)
            {
                MessageBox.Show("파일 읽어오기 실패");
            }
            label_logFile_count.Text = m_logFilePath.Length.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            // OK 눌럿을 때만 m_value 값을 실재로 변경함.
            m_values.value_conveyorSpeed = comboBox_conveyorSpeed.SelectedIndex + 1;
            m_values.value_XAxisDistance = comboBox_xXaisDistance.SelectedIndex + 1;
            m_values.value_ConvererRollerSpeed = comboBox_converterRollerSpeed.SelectedIndex + 1;
            
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
            // m_values.value_conveyorSpeed = comboBox_conveyorSpeed.SelectedIndex + 1;
            int selectValue = comboBox_conveyorSpeed.SelectedIndex + 1;
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_BELTSPEED, (short)selectValue));
        }

        private void comboBox_xXaisDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            // m_values.value_XAxisDistance = comboBox_xXaisDistance.SelectedIndex + 1;
            int selectValue = comboBox_xXaisDistance.SelectedIndex + 1;
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_XXAISDISTANCE, (short)selectValue));
        }

        private void comboBox_converterRollerSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            // m_values.value_ConvererRollerSpeed = comboBox_converterRollerSpeed.SelectedIndex + 1;
            int selectValue = comboBox_converterRollerSpeed.SelectedIndex + 1;
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_ROLLERSPEED, (short)selectValue));
        }

        private void smartButton_removeLogFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("정말 로그파일을 삭제할까요?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult != DialogResult.OK) {
                return;
            }

            bool result;
            for (int i = 0; i < m_logFilePath.Length; i++)
            {
                result = File.Exists(m_logFilePath[i]);
                if (result == true)
                {
                    File.Delete(m_logFilePath[i]);
                }
                else
                {
                    MessageBox.Show("파일" + m_logFilePath[i] + " 을 찾을 수 없어 삭제를 중단합니다.");
                    break;
                }
            }
            InitialDialog();    // label 업데이트
        }

        private void smartButton_sendUSB_Click(object sender, EventArgs e)
        {
            bool result;
            List<string> logFilePath_usb = new List<string>();
            int successCount = 0;
            
            string filename = "";

            try
            {
                for (int i = 0; i < m_logFilePath.Length; i++)
                {
                    filename = Path.GetFileName(m_logFilePath[i]);
                    filename = "\\하드 디스크\\" + filename;
                    logFilePath_usb.Add(filename);
                }

                for (int i = 0; i < logFilePath_usb.Count; i++)
                {
                    System.IO.File.Copy(m_logFilePath[i], logFilePath_usb[i], true);
                }

                for (int i = 0; i < m_logFilePath.Length; i++)
                {
                    result = File.Exists(logFilePath_usb[i]);
                    if (result == true)
                    {
                        successCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패 : " + ex.ToString());
            }

            MessageBox.Show("성공 : " + successCount.ToString() + "/" + m_logFilePath.Length.ToString());
            label_upload_result.Text = successCount.ToString() + "/" + m_logFilePath.Length.ToString();
        }
    }
}