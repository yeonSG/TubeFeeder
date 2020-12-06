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
    public partial class Form1 : Form
    {
        SmartX.SmartUART smartUART1 = new SmartX.SmartUART();
        ScanLogFileManager m_ScanLogFileManager = new ScanLogFileManager();

        public Form1()
        {
            InitializeComponent();
        }

        private string m_inputBuffer = "";
        private string m_insertedItem = "";
        private void AppendInputBuffer(string key)
        {
            m_inputBuffer += key;
            label_keybuffer.Text = m_inputBuffer;
        }
        private void ClearInputBuffer()
        {
            m_inputBuffer = "";
            label_keybuffer.Text = m_inputBuffer;
        }
        private void InsertBufferStr()
        {
            m_insertedItem = m_inputBuffer;
            AddLog(m_insertedItem);

            if (m_ScanLogFileManager.WriteValue(m_insertedItem) == false)
                ErrorInfo("Scan Logger error");
            
            ClearInputBuffer();
        }

        private void AddLog(string value)
        {
            smartListBox_log.AddItem(DateTime.Now.ToLongTimeString() + value);

            if (smartListBox_log.Items.Count() > 10)  // 리스트박스 아이탬 개수에 따라 다르게 설정해야함
                smartListBox_log.RemoveItem(0);
        }

        private void smartButton1_Click(object sender, EventArgs e)
        {
            smartSerialPort1.Baud_Rate = SmartX.SmartSerialPort.BAUDRATE._115200bps;

            // SmartX.SmartMessageBox.Show("test");
            string serialInfo = "serial info";
            string strBaudrate = smartSerialPort1.RawSerialPort.ToString(); // getBaudrateString(smartSerialPort1.RawSerialPort);
            string strDatabits = getDatabitsString(smartSerialPort1.RawSerialPort);
            string strParity = getParityString(smartSerialPort1.RawSerialPort);
            string strStopbits = getStopbitsString(smartSerialPort1.RawSerialPort);

            smartSerialPort1.PortNo = SmartX.SmartSerialPort.COMPORTNO.COM3;

            serialInfo += "\r\n" + smartSerialPort1.RawSerialPort.PortName;
            serialInfo += "\r\n" + strBaudrate;
            serialInfo += "\r\n" + strDatabits;
            serialInfo += "\r\n" + strParity;
            serialInfo += "\r\n" + strStopbits;
            label1.Text = serialInfo;

            /*
            switch (smartSerialPort1.Baud_Rate)
            {
                case SmartX.SmartSerialPort.BAUDRATE._110bps:
                    baudrate = "_110bps";
                    break;
            }*/

            // smartSerialPort1.Open();

            MessageBox.Show("test");
        }

        private void buttonOPEN_Click(object sender, EventArgs e)
        {
            label1.Text = "asdasd";
        }

        private string getBaudrateString(System.IO.Ports.SerialPort serialPort) 
        {
            return Convert.ToString(serialPort.BaudRate);
        }
        private string getDatabitsString(System.IO.Ports.SerialPort serialPort)
        {
            return Convert.ToString(serialPort.DataBits);
        }
        private string getParityString(System.IO.Ports.SerialPort serialPort)
        {
            switch(serialPort.Parity)
            {
                case System.IO.Ports.Parity.Even:
                    return "Even";
                case System.IO.Ports.Parity.Mark:
                    return "Mark";
                case System.IO.Ports.Parity.None:
                    return "None";
                case System.IO.Ports.Parity.Odd:
                    return "Odd";
                case System.IO.Ports.Parity.Space:
                    return "Space";
                default: 
                    return "Error";
            }
        }
        private string getStopbitsString(System.IO.Ports.SerialPort serialPort)
        {
            switch (serialPort.StopBits)
            {
                case System.IO.Ports.StopBits.None:
                    return "None";
                case System.IO.Ports.StopBits.One:
                    return "One";
                case System.IO.Ports.StopBits.OnePointFive:
                    return "OnePointFive";
                case System.IO.Ports.StopBits.Two:
                    return "Two";
                default:
                    return "Error";
            }
        }

        private string openSerial(SmartX.SmartSerialPort smartSerialport)
        {
            if (smartSerialport.IsOpen == true)
                return "port already opend";
            else
            {                
                //COM7의 경우 USB Serial 통신을 위해 사용합니다. FTDI VCP드라이버가 없는 경우 COM7을 선택 후 Open()하면 에러가 발생합니다.
                try { smartSerialPort1.Open(); }
                catch (System.IO.IOException)
                {
                    string ret = smartSerialPort1.PortNo.ToString() + " 포트가 존재하지 않습니다.";
                    smartSerialPort1.Close();
                    return ret;
                }
                return "open Success";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Return))
            //{
            //    MessageBox.Show("Key pressed");
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //SmartX.SmartMessageBox.Show(e.ToString());
            //MessageBox.Show(e.KeyChar.ToString());
            //** 엔터를 여기서 받으려면 포커스가 엔터이벤트를 받지 않는 포커스에 있어야 함(추측임)(버튼같은?)

            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("enter");// Enter key pressed
                InsertBufferStr();
            }
            else
            {
                switch(e.KeyCode)
                {
                    case Keys.D1:
                    case Keys.NumPad1:
                        AppendInputBuffer("1");
                        break;
                    case Keys.D2:
                    case Keys.NumPad2:
                        AppendInputBuffer("2");
                        break;
                    case Keys.D3:
                    case Keys.NumPad3:
                        AppendInputBuffer("3");
                        break;
                    case Keys.D4:
                    case Keys.NumPad4:
                        AppendInputBuffer("4");
                        break;
                    case Keys.D5:
                    case Keys.NumPad5:
                        AppendInputBuffer("5");
                        break;
                    case Keys.D6:
                    case Keys.NumPad6:
                        AppendInputBuffer("6");
                        break;
                    case Keys.D7:
                    case Keys.NumPad7:
                        AppendInputBuffer("7");
                        break;
                    case Keys.D8:
                    case Keys.NumPad8:
                        AppendInputBuffer("8");
                        break;
                    case Keys.D9:
                    case Keys.NumPad9:
                        AppendInputBuffer("9");
                        break;
                    case Keys.D0:
                    case Keys.NumPad0:
                        AppendInputBuffer("0");
                        break;                        
                    default:
                        ErrorInfo("Input is not number");
                        ClearInputBuffer();
                        break;                        
                }
            }
        }

        private void ErrorInfo(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private void smartButton1_Click_1(object sender, EventArgs e)
        {

        }

    }
}