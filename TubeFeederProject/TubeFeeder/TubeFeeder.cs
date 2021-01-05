using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TubeFeeder
{
    public delegate void SetCallback();
    public delegate void SetTextCallback(string Text);
    public delegate void SetBoolCallback(bool boolean);
    public delegate void SetColorCallback(Color Color);

    public delegate void ReciveMsgCallback(MessageProtocol.ReciveMessage message);

    public partial class Form1 : Form
    {
        [DllImport("CoreDll.dll")]
        public static extern void MessageBeep(int code);

        ScanLogFileManager m_ScanLogFileManager = new ScanLogFileManager();
        ControlBoard m_ControlBoard = null;

        private string m_inputBuffer = "";
        private string m_insertedItem = "";

        private DateTime m_runTime = DateTime.Now;
        private UInt32 m_scanCount = 0;

        private bool m_debugMode = false;   // 디버그모드

        private bool m_isRecivedFromCom = false;
        private bool m_isOnError = false;
        private bool m_isBarcodeReadMode_On = true; // 바코드 읽기모드 On
        private bool m_isAutoStopMode_On = true; // AutoStopMode On

        private SettingValues m_settingValues;

        private Queue<byte> reciveQueue = new Queue<byte>();

        public Form1()
        {
            InitializeComponent();

            SetTextCallback logCallback = new SetTextCallback(AddLog_d);
            ReciveMsgCallback msgRecivCallback = new ReciveMsgCallback(msgRecive);
            m_ControlBoard = new ControlBoard(serialPort1, logCallback, msgRecivCallback);

            label_curTime.Text = DateTime.Now.ToLongTimeString();
            label_runTime.Text = m_runTime.ToLongTimeString();

            // ModeInit();
            ModeInit();

            //SettingInit();
            SettingInit();


            smartTimer1.Interval = 1000;    // 1000msec
            smartTimer1.Start();
            smartTimer2.Interval = 1000;    // 1000msec
            smartTimer2.Start();
        }

        private void ModeInit()
        {
            m_isBarcodeReadMode_On = IniFileManager.GetMode_BarcodeRead();
            m_isAutoStopMode_On = IniFileManager.GetMode_AutoStop();

            if(m_isBarcodeReadMode_On==true)
                btn_BarcodeReadOn.ButtonDown();
            else
                btn_BarcodeReadOff.ButtonDown();

            if(m_isAutoStopMode_On==true)
                btn_AutoStopModeOn.ButtonDown();
            else
                btn_AutoStopModeOff.ButtonDown();
        }

        private void SettingInit()
        {
            m_settingValues = new SettingValues();
            m_settingValues.value_conveyorSpeed = IniFileManager.GetSetting_ConveyerSpeed();
            m_settingValues.value_XAxisDistance = IniFileManager.GetSetting_XXaisDistance();
            m_settingValues.value_ConvererRollerSpeed = IniFileManager.GetSetting_ConverterRollerSpeed();

            // set for machine
            //SendSettingValues(settingValues);
        }

        private void SendSettingValues(SettingValues valueData)
        {
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_BELTSPEED, (short)valueData.value_conveyorSpeed));
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_XXAISDISTANCE, (short)valueData.value_XAxisDistance));
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Write(MessageProtocol.CMD_WRITE_ROLLERSPEED, (short)valueData.value_ConvererRollerSpeed));
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
            if (m_inputBuffer.Equals(m_insertedItem) == true)
            {
                // AddLog("(duplicated) " + m_insertedItem);   
                return; //  Do not action, When Duplicated before Input value.
            }
            else
            {
                m_insertedItem = m_inputBuffer;
            }

            AddLog(m_insertedItem);   

            if (m_ScanLogFileManager.WriteValue(m_insertedItem) == false)
                ErrorInfo("로그파일 쓰기 error");
            
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

                if (smartListBox_log.Items.Count() > 29)  // 리스트박스 아이탬 개수에 따라 다르게 설정해야함
                    smartListBox_log.RemoveItem(0);
            }
        }

        private void AddLog_d(string value)
        {
            if (m_debugMode != true)
                return;
                
            if (this.smartListBox_log.InvokeRequired)
            {
                SetTextCallback dp = new SetTextCallback(AddLog_d);
                this.Invoke(dp, new object[] { value });
            }
            else
            {
                AddLog(value);
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

                if(recSize != 0)
                {
                    m_isRecivedFromCom = true;
                    recString = "[RX] ";
                    byte[] buff = new byte[recSize];

                    serialPort1.Read(buff, 0, recSize);
                    for (int i = 0; i < recSize; i++)
                    {
                        recString += buff[i].ToString("X2") + " ";

                        reciveQueue.Enqueue(buff[i]);
                    }
                    AddLog_d(recString);

                    // 큐의 첫번째것이 HEADER일때까지 버림
                    while (reciveQueue.Count != 0)
                    {
                        if (reciveQueue.Peek() == MessageProtocol.HEADER)
                            break;
                        else
                            reciveQueue.Dequeue();
                    }

                    // 큐의 아이템이 7이상이어야 함
                    while(reciveQueue.Count >= MessageProtocol.PROTOCOL_MESSAGE_SIZE)
                    {
                        List<byte> message = new List<byte>();
                        for (int i = 0; i < MessageProtocol.PROTOCOL_MESSAGE_SIZE; i++)
                        {
                            if (i != 0 && reciveQueue.Peek() == MessageProtocol.HEADER) // 인덱스0이 헤더가 아니면 거기서부터 다시
                            {
                                // Console.Write("broken Message!");
                                break;
                            }
                            if (i==6 && reciveQueue.Peek() != MessageProtocol.TAIL) // 테일에러
                            {
                                // Console.Write("broken Message!");
                                break;
                            }
                            else
                                message.Add(reciveQueue.Dequeue());
                        }

                        if (message.Count == MessageProtocol.PROTOCOL_MESSAGE_SIZE)
                        {
                            if (message[6] != MessageProtocol.TAIL) // 테일에러
                            {
                                Console.Write("broken Message! - tail");
                                continue;
                            }
                            
                            byte[] myArryByte = message.ToArray();
                            m_ControlBoard.ProcessMessage(myArryByte);
                        }
                    }
                }
            }
        }

        private void SendPing()
        {
            m_ControlBoard.SendMessage( MessageGenerator.Meesage_Ping() );
        }

        private void buttonTest1_Click(object sender, EventArgs e)
        {
            AddLog_d("send");
            SendPing();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {

            PasswordForm pwFrom = new PasswordForm();
            DialogResult pwResult = pwFrom.ShowDialog();
            if (pwResult == DialogResult.OK)
            {
                OptionSettingRuttin();
                // 저장 메시지 전송함
            }
            else if (pwResult == DialogResult.No)
            {
                MessageBox.Show("password fail");
            }
            else if (pwResult == DialogResult.Cancel)
            {
                ;   // nothing do 
            }
        }

        private void OptionSettingRuttin()
        {
            DialogForm dialog = new DialogForm(m_ControlBoard ,m_settingValues);
            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //MessageBox.Show(settingData.value_conveyorSpeed + " "
                //    + settingData.value_XAxisDistance
                //    + settingData.value_ConvererRollerSpeed);

                // initFile에 저장
                IniFileManager.SetSetting_ConveyerSpeed(m_settingValues.value_conveyorSpeed);
                IniFileManager.SetSetting_XXaisDistance(m_settingValues.value_XAxisDistance);
                IniFileManager.SetSetting_ConverterRollerSpeed(m_settingValues.value_ConvererRollerSpeed);

                // 저장메시지 전송
                // SendSettingValues(settingData);
                
            }
            else if (dr == DialogResult.Cancel)
            {
                ;
            }
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_Infom(MessageProtocol.CMD_INFORM_SETTING_CLOSE));
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            SendSettingValues(m_settingValues);     // setting값 보냄

            m_ControlBoard.SendMessage(MessageGenerator.Meesage_DeviceStart(m_isBarcodeReadMode_On, m_isAutoStopMode_On));
            setIndicatorColor(Color.Green);
            btn_barcodeOnEnable(false);
            btn_barcodeOffEnable(false);
            btn_autoStopModeOnEnable(false);
            btn_autoStopModeOffEnable(false);
            btn_SettingsEnable(false);
            m_isOnError = false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            m_ControlBoard.SendMessage(MessageGenerator.Meesage_DeviceStop());
            btn_barcodeOnEnable(true);
            btn_barcodeOffEnable(true);
            btn_autoStopModeOnEnable(true);
            btn_autoStopModeOffEnable(true);
            btn_SettingsEnable(true);
            
            m_isOnError = false;
            doStop();
        }
        private void doStop()
        {
            setIndicatorColor(Color.Gray);
        }

        public void btn_autoStopModeOnEnable(bool enable)
        {
            if (this.btn_AutoStopModeOn.InvokeRequired)
            {
                SetBoolCallback dp = new SetBoolCallback(btn_autoStopModeOnEnable);
                this.Invoke(dp, new object[] { enable });
            }
            else
            {
                btn_AutoStopModeOn.Enabled = enable;
            }
        }
        public void btn_autoStopModeOffEnable(bool enable)
        {
            if (this.btn_AutoStopModeOff.InvokeRequired)
            {
                SetBoolCallback dp = new SetBoolCallback(btn_autoStopModeOffEnable);
                this.Invoke(dp, new object[] { enable });
            }
            else
            {
                btn_AutoStopModeOff.Enabled = enable;
            }
        }
        public void btn_SettingsEnable(bool enable)
        {
            if (this.btn_setting.InvokeRequired)
            {
                SetBoolCallback dp = new SetBoolCallback(btn_SettingsEnable);
                this.Invoke(dp, new object[] { enable });
            }
            else
            {
                btn_setting.Enabled = enable;
            }
        }



        public void btn_barcodeOnEnable(bool enable)
        {
            if (this.btn_BarcodeReadOn.InvokeRequired)
            {
                SetBoolCallback dp = new SetBoolCallback(btn_barcodeOnEnable);
                this.Invoke(dp, new object[] { enable });
            }
            else
            {
                btn_BarcodeReadOn.Enabled = enable;
            }
        }

        public void btn_barcodeOffEnable(bool enable)
        {
            if (this.btn_BarcodeReadOff.InvokeRequired)
            {
                SetBoolCallback dp = new SetBoolCallback(btn_barcodeOffEnable);
                this.Invoke(dp, new object[] { enable });
            }
            else
            {
                btn_BarcodeReadOff.Enabled = enable;
            }
        }

        private void setIndicatorColor(Color color)
        {
            if (this.label_indicator.InvokeRequired)
            {
                SetColorCallback dp = new SetColorCallback(setIndicatorColor);
                this.Invoke(dp, new object[] { color });
            }
            else
            {
                label_indicator.BackColor = color;
            }
        }
        
        private void setRuntimeLabelText(string value)
        {
            if (this.label_runTime.InvokeRequired)
            {
                SetTextCallback dp = new SetTextCallback(setRuntimeLabelText);
                this.Invoke(dp, new object[] { value });
            }
            else
            {
                label_runTime.Text = value;
            }
        }

        private void setCurtimeLabelText(string value)
        {
            if (this.label_curTime.InvokeRequired)
            {
                SetTextCallback dp = new SetTextCallback(setCurtimeLabelText);
                this.Invoke(dp, new object[] { value });
            }
            else
            {
                label_curTime.Text = value;
            }
        }

        private void setScanCountLabelText(string value)
        {
            if (this.label_scanCount.InvokeRequired)
            {
                SetTextCallback dp = new SetTextCallback(setScanCountLabelText);
                this.Invoke(dp, new object[] { value });
            }
            else
            {
                label_scanCount.Text = value;
            }
        }

        public void msgRecive(MessageProtocol.ReciveMessage reciveMsg)
        {
            switch (reciveMsg)
            {
                case MessageProtocol.ReciveMessage.unknown:
                    break;
                case MessageProtocol.ReciveMessage.inform_Error:
                    m_isOnError = true;
                    break;
                case MessageProtocol.ReciveMessage.order_Start:
                    break;
                case MessageProtocol.ReciveMessage.order_Stop:
                    btnStop_buttonDown();
                    btnStart_buttonUp();
                    doStop();
                    break;
                default:
                    break;

            }
        }

        public void btnStart_buttonUp()
        {
            if (this.btn_start.InvokeRequired)
            {
                SetCallback dp = new SetCallback(btnStart_buttonUp);
                this.Invoke(dp, new object[] { });
            }
            else
            {
                btn_start.ButtonUp();
            }

        }
        public void btnStop_buttonDown()
        {
            if (this.btn_stop.InvokeRequired)
            {
                SetCallback dp = new SetCallback(btnStop_buttonDown);
                this.Invoke(dp, new object[] { });
            }
            else
            {
                btn_stop.ButtonDown();
            }
        }

        private void radioButton_BarcodeReadOn_Click(object sender, EventArgs e)
        {
            m_isBarcodeReadMode_On = true;
            IniFileManager.SetMode_BarcodeRead(m_isBarcodeReadMode_On);
        }

        private void radioButton_BarcodeReadOff_Click(object sender, EventArgs e)
        {
            m_isBarcodeReadMode_On = false;
            IniFileManager.SetMode_BarcodeRead(m_isBarcodeReadMode_On);
        }

        private void btn_AutoStopModeOn_Click(object sender, EventArgs e)
        {
            m_isAutoStopMode_On = true;
            IniFileManager.SetMode_AutoStop(m_isAutoStopMode_On);
        }

        private void btn_AutoStopModeOff_Click(object sender, EventArgs e)
        {
            m_isAutoStopMode_On = false;
            IniFileManager.SetMode_AutoStop(m_isAutoStopMode_On);
        }

        private void setComponentToStartedState(bool isStarted)    // start 도중 건들면 안되는 컴포넌트들 disable 용도
        {

            if (isStarted)  // 시작상태일때
            {
                // start버튼 disable
                // stop버튼 enable
                // 라디오버튼 disable
            }
            else
            {
                // start버튼 enable
                // stop버튼 disable
                // 라디오버튼 enable
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void smartTimer1_Tick(object sender, EventArgs e)
        {
            TimeSpan runTime = DateTime.Now.Subtract(m_runTime);
            string strRunTime = runTime.Days + "일 " + runTime.Hours + "시간 " + runTime.Minutes + "분 " + runTime.Seconds + "초";
            string strCurTime = DateTime.Now.ToLongTimeString();
            setRuntimeLabelText(strRunTime);
            setCurtimeLabelText(strCurTime);
            setScanCountLabelText(m_scanCount + "개");

            if(m_isOnError==true)
            {
                MessageBeep(64);
                if (label_indicator.BackColor == Color.Red) // 1초간격 점멸 
                {
                    setIndicatorColor(Color.Black);
                }
                else
                {
                    setIndicatorColor(Color.Red);

                }
            }
            if (btn_start.ButtonStatus == SmartX.SmartButton.BUTSTATUS.DOWN)
            {
                if (m_isRecivedFromCom == true)
                {
                    setIndicatorColor(Color.Lime);
                    m_isRecivedFromCom = false;
                }
                else
                {
                    setIndicatorColor(Color.Green);
                }
            }
        }

        private void smartTimer2_Tick(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////
            //                                                            //
            // SmartUpdate 관련 설정 사항은 폼디자인 모드에서 SmartUpdate //
            // 의 속성 값을 확인 하시기 바라며 또한 속성값 변경을 속성창  //
            // 에서 직접 하셔도 됩니다. 본 예제에서는 속성 값을 따로 코드 //
            // 로 정의 하지 않고 속성창 에서 설정 하였습니다.             //
            //                                                            //
            ////////////////////////////////////////////////////////////////


            // 현재 응용프로그램이 종료된후 업데이트 모듈이 업데이트를 시작하기까지의 지연 시간을 설정 함
            // 응용프로그램의 용량등(프로그램 복잡도)에 따라서 종료되는 지연시간을 감안 하여 시간을
            // 충분한 값으로 설정 하시기 바랍니다. 단위 ms
            smartUpdate1.SetStartInterval = 3000;  // 3초

            // Update File을 확인 하며 업데이트 할 파일이 있을경우 업데이트 시작
            // 리턴값 : 업데이트 할 파일이 있는경우 True, 업데이트 할 파일이 없는경우 False
            if (smartUpdate1.Start() == true)
            {
                // ※※※[중요] 업데이트 할 파일이 있을경우 반드시 현재 응용프로그램을 종료 해야 합니다.!!! [중요]※※※
                Application.Exit();
            }
        }
        // Ping
        // Value Write
        // Value Read
        // Start
        // Sttop
        
    }
}
