using System;
using System.IO.Ports;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TubeFeeder
{
    /* FTP Control
     */
    
    public class FTPControl
    {
        /* 설정 */ 
        public string m_FTPServerAddr;
        public string m_FTPServerUserID;
        public string m_FTPServerPassword;
        
            // m_smartFTP.ServerFTPAddress = textBox_IP.Text;
            // m_smartFTP.PortNo = 21;
            // m_smartFTP.PassiveMode = true;
            // m_smartFTP.UserID = textBox_ftp_id.Text;
            // m_smartFTP.Password = textBox_ftp_pw.Text;

        private SmartX.SmartFTP m_smartFTP = null;

        public bool m_FTPServerConnected = false;

        public static ControlBoardState m_state = ControlBoardState.UNKNOWN;

        public bool isConnected() {
            return m_FTPServerConnected;
        }

        public FTPControl(SmartX.SmartFTP smartFTP)
        {
            this.m_smartFTP = smartFTP;
            Init();            
        }

        public SmartX.SmartFTP getSmartFTP() {
            return m_smartFTP;
        }

        private void Init()
        {
            m_FTPServerAddr = "192.168.0.15";
            m_FTPServerUserID = "admin";
            m_FTPServerPassword = "admin";
        }

        public bool connect()
        {            
            m_smartFTP.ServerFTPAddress = m_FTPServerAddr;
            m_smartFTP.PortNo = 21;
            m_smartFTP.PassiveMode = true;
            m_smartFTP.UserID = m_FTPServerUserID;
            m_smartFTP.Password = m_FTPServerPassword;

            // FTP 연결 요청
            if (m_smartFTP.Connect() == true)
            {
                m_FTPServerConnected = true;
            }
            else
            {
                m_FTPServerConnected = false;
            }
            return m_FTPServerConnected;
        }

        public bool uploadFile(string filePath)
        {
            string filename = Path.GetFileName(filePath);

            if (m_smartFTP.DeleteFiles(filename) != true)
            {
                return false;
            }
            if (m_smartFTP.FileUpload(filePath, filename) != true)
            {
                return false;
            }            
            return true;
        }
    }
}
