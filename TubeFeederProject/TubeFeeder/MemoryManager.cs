using System;
using System.IO.Ports;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    
    public class MemoryManager
    {
        private SmartX.SmartMemory m_smartMemory = null;


        public MemoryManager(SmartX.SmartMemory smartMemory)
        {
            this.m_smartMemory = smartMemory;
            Init();
        }

        private void Init()
        {
            ;
        }

        // return : " xx.x/xx.xMB (xx.x%)"
        public string getUsageString()
        {
            ulong ulFDtotal, ulFDUse;
            ulFDUse = m_smartMemory.FD_Drive_UseBytes;
            ulFDtotal = m_smartMemory.FD_Drive_FreeBytes + ulFDUse;
            int use_Kb = Convert.ToInt32(ulFDUse / 1024);
            int totla_Kb = Convert.ToInt32(ulFDtotal / 1024);

            double use_Mb = System.Math.Round(use_Kb / 1024.0, 1);
            double total_Mb = System.Math.Round(totla_Kb / 1024.0, 1);
            double percent = System.Math.Round(use_Kb * 100.0 / totla_Kb, 1);

            return use_Mb.ToString() + "/" + total_Mb.ToString()
                + "Mb (" + percent.ToString() + ")";
        }
    }
}
