using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TubeFeeder
{
    /* Scan한 내용을 파일에 저장하고 관리하는 클래스 */
    class ScanLogFileManager 
    {
        public const string DIR_DELIMITER = "\\";
        public const string LOGFILE_PATH = "\\Flash Disk\\ScanLog";     // ** 저장장소 이름 정확해야함

        SmartX.SmartFile m_smartFile;

        public ScanLogFileManager()
        {
            this.m_smartFile = new SmartX.SmartFile();
        }

        public bool WriteValue(string value)
        {
            CheckDirectoryAndCreate(GetLogFIlePath());
            m_smartFile.FilePathName = GetTargetFile();
            if (m_smartFile.Open() == true)
            {
                m_smartFile.WriteString( GetCurrentTime() +"\t"+ value ); 
                m_smartFile.Close();
                return true;
            }
            else
            {
                return false;
            }            
        }

        public void CheckDirectoryAndCreate(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists != true)
            {
                dir.Create();
            }
        }
        public string GetLogFIlePath()
        {
            return LOGFILE_PATH;
        }
        public string GetTargetFile()
        {
            return LOGFILE_PATH + DIR_DELIMITER + GetCurrentDate() + ".txt";
        }

        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyyMMdd");
        }

        public string GetCurrentTime()
        {
            return String.Format("{0,2:N0}:{1,2:N0}:{2,2:N0}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}
