using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Simulation
    {
        string strInput;
        string strProcess;
        string strOutput;
        
        public Simulation() { }

        public Simulation(string strInput, string strProcess, string strOutput)
        {
            this.StrInput = strInput;
            this.StrProcess = strProcess;
            this.StrOutput = strOutput;
        }

        public string StrInput
        {
            get
            {
                return strInput;
            }

            set
            {
                strInput = value;
            }
        }

        public string StrProcess
        {
            get
            {
                return strProcess;
            }

            set
            {
                strProcess = value;
            }
        }

        public string StrOutput
        {
            get
            {
                return strOutput;
            }

            set
            {
                strOutput = value;
            }
        }
    }
}
