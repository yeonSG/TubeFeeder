using System;
using System.IO.Ports;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    
    public class BarcodeSender
    {
        /* 컴포트 설정 */
        public String CONTROLBOARD_COMPORT = "COM3";
        public int COM_BAUDRATE = 9600;
        public const int COM_DATABITS = 8;
        public const Parity COM_PARITY = Parity.None;
        public const StopBits COM_STOPBITS = StopBits.One;

        private SerialPort m_serialPort = null;


        public BarcodeSender(SerialPort serialPort)
        {
            this.m_serialPort = serialPort;
            Init();
            
        }

        private void Init()
        {
            m_serialPort.PortName = CONTROLBOARD_COMPORT;
            m_serialPort.BaudRate = COM_BAUDRATE;
            m_serialPort.DataBits = COM_DATABITS;
            m_serialPort.Parity = COM_PARITY;
            m_serialPort.StopBits = COM_STOPBITS;

            Open();
        }

        public bool Open()
        {
            try
            {
                m_serialPort.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool isOpen()
        {
            return m_serialPort.IsOpen;
        }

        public bool SendMessage(byte[] msg)
        {
            if (isOpen() == false)
                return false;

            try
            {
                //m_serialPort.Write(msg, 0, msg.Length);
                
                //if(doDelay==true)
                //    Thread.Sleep(100);
                byte[] START = new byte[1]{0x02};
                byte[] END = new byte[1]{0x03};
                m_serialPort.Write(START, 0, 1);

                int sendSize = msg.Length;
                //serialPort1.Write(data, 0, sendSize);
                for (int i = 0; i < sendSize; i++ )
                {
                    Wait.Start(10);      // MicroSec Sleep
                    m_serialPort.Write(msg, i, 1);
                }
                Wait.Start(10);      
                m_serialPort.Write(END, 0, 1);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
