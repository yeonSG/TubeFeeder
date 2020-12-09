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
    delegate void SetTextCallback(string Text);

    public partial class Form1 : Form
    {
        ScanLogFileManager m_ScanLogFileManager = new ScanLogFileManager();
        ControlBoard m_ControlBoard = null;

        private string m_inputBuffer = "";
        private string m_insertedItem = "";

        private DateTime m_runTime = DateTime.Now;
        private UInt32 m_scanCount = 0;

        public Form1()
        {
            InitializeComponent();

            SetTextCallback logCallback = new SetTextCallback(AddLog);
            m_ControlBoard = new ControlBoard(serialPort1, logCallback);

            label_curTime.Text = DateTime.Now.ToLongTimeString();
            label_runTime.Text = m_runTime.ToLongTimeString();


            smartTimer1.Interval = 1000;    // 1000msec
            smartTimer1.Start();
        }

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
            if (this.smartListBox_log.InvokeRequired)
            {
                SetTextCallback dp = new SetTextCallback(AddLog);
                this.Invoke(dp, new object[] { value });
            }
            else
            {
                smartListBox_log.AddItem("[" + DateTime.Now.ToLongTimeString() + "] " + value);

                if (smartListBox_log.Items.Count() > 35)  // 리스트박스 아이탬 개수에 따라 다르게 설정해야함
                    smartListBox_log.RemoveItem(0);
            }
        }

        private string getBaudrateString(System.IO.Ports.SerialPort serialPort) 
        {
            return Convert.ToString(serialPort.BaudRate);
        }
        private string getDatabitsString(System.IO.Ports.SerialPort serialPort)
        {
            return Convert.ToString(serialPort.DataBits);
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

                // Check(); 버퍼내용이 바코드 형식에 부합하는지 검사
                if (m_inputBuffer == "")
                    return;

                m_scanCount++;
                InsertBufferStr();
                m_ControlBoard.SendMessage( MessageGenerator.Meesage_Infom(MessageProtocol.CMD_INFORM_SCANNED) );
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
                    case Keys.Q:
                        AppendInputBuffer("Q");
                        break;
                    case Keys.W:
                        AppendInputBuffer("W");
                        break;
                    case Keys.E:
                        AppendInputBuffer("E");
                        break;
                    case Keys.R:
                        AppendInputBuffer("R");
                        break;
                    case Keys.T:
                        AppendInputBuffer("T");
                        break;
                    case Keys.Y:
                        AppendInputBuffer("Y");
                        break;
                    case Keys.U:
                        AppendInputBuffer("U");
                        break;
                    case Keys.I:
                        AppendInputBuffer("I");
                        break;
                    case Keys.O:
                        AppendInputBuffer("O");
                        break;
                    case Keys.P:
                        AppendInputBuffer("P");
                        break;
                    case Keys.A:
                        AppendInputBuffer("A");
                        break;
                    case Keys.S:
                        AppendInputBuffer("S");
                        break;
                    case Keys.D:
                        AppendInputBuffer("D");
                        break;
                    case Keys.F:
                        AppendInputBuffer("F");
                        break;
                    case Keys.G:
                        AppendInputBuffer("G");
                        break;
                    case Keys.H:
                        AppendInputBuffer("H");
                        break;
                    case Keys.J:
                        AppendInputBuffer("J");
                        break;
                    case Keys.K:
                        AppendInputBuffer("K");
                        break;
                    case Keys.L:
                        AppendInputBuffer("L");
                        break;
                    case Keys.Z:
                        AppendInputBuffer("Z");
                        break;
                    case Keys.X:
                        AppendInputBuffer("X");
                        break;
                    case Keys.C:
                        AppendInputBuffer("C");
                        break;
                    case Keys.V:
                        AppendInputBuffer("V");
                        break;
                    case Keys.B:
                        AppendInputBuffer("B");
                        break;
                    case Keys.N:
                        AppendInputBuffer("N");
                        break;
                    case Keys.M:
                        AppendInputBuffer("M");
                        break;
                
                    default:
                        // ErrorInfo("Input is not number");
                        ClearInputBuffer();
                        break;                        
                }
            }
        }

        private void ErrorInfo(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        // comport로 메시지 수신함
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (m_ControlBoard.isOpen())
            {
                int recSize = serialPort1.BytesToRead;
                string recString;

                // AddLog("reciveed " + recSize);

                //LogProcessing("Rec Called_" + recSize +"\r\n");
                //if (recSize >= 7)//
                if(recSize != 0)
                {
                    recString = "[RX] ";
                    byte[] buff = new byte[recSize];

                    serialPort1.Read(buff, 0, recSize);
                    for (int i = 0; i < recSize; i++)
                    {
                        recString += buff[i].ToString("X2") + " ";
                    }
                    AddLog(recString);
                    
                    m_ControlBoard.ProcessMessage(buff);
                }
            }
        }

        private void SendDeviceStart(byte[] value)
        {
            m_ControlBoard.SendMessage( MessageGenerator.Meesage_DeviceStart(true) );
        }
        private void SendPing()
        {
            m_ControlBoard.SendMessage( MessageGenerator.Meesage_Ping() );
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            AddLog("send");
            SendPing();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {

        }

        private void smartButton_StartReqest_Click(object sender, EventArgs e)
        {
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_DeviceStart(true));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            bool isBarcodeReadMode = true;
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_DeviceStart(isBarcodeReadMode));
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_DeviceStop());
        }

        private void smartTimer1_Tick(object sender, EventArgs e)
        {
            TimeSpan runTime = DateTime.Now.Subtract(m_runTime);
            label_runTime.Text = runTime.Days + "일 " + runTime.Hours + "시간 " + runTime.Minutes + "분 " + runTime.Seconds + "초";
            label_curTime.Text = DateTime.Now.ToLongTimeString();

            label_scanCount.Text = m_scanCount + "개";
        }
        // Ping
        // Value Write
        // Value Read
        // Start
        // Sttop
        
    }
}
