using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Solution
    {
        string strBRID;
        string strHandleBRID;
        string strFlowPicturePath;
        string strFlowText;
        string strClient;
        string[] strArrayTableReference;
        string[] strArrayStoreProcedureReference;
        Simulation simulation;
        
        public Solution() { }

        public Solution(string strBRID, string strHandleBRID, string strFlowPicturePath, string strFlowText, string strClient, string[] strArrayTableReference, string[] strArrayStoreProcedureReference, Simulation simulation)
        {
            this.StrBRID = strBRID;
            this.StrHandleBRID = strHandleBRID;
            this.StrFlowPicturePath = strFlowPicturePath;
            this.StrFlowText = strFlowText;
            this.StrClient = strClient;
            this.StrArrayTableReference = strArrayTableReference;
            this.StrArrayStoreProcedureReference = strArrayStoreProcedureReference;
            this.Simulation = simulation;
        }

        public string StrBRID
        {
            get
            {
                return strBRID;
            }

            set
            {
                strBRID = value;
            }
        }

        public string StrHandleBRID
        {
            get
            {
                return strHandleBRID;
            }

            set
            {
                strHandleBRID = value;
            }
        }

        public string StrFlowPicturePath
        {
            get
            {
                return strFlowPicturePath;
            }

            set
            {
                strFlowPicturePath = value;
            }
        }

        public string StrFlowText
        {
            get
            {
                return strFlowText;
            }

            set
            {
                strFlowText = value;
            }
        }

        public string StrClient
        {
            get
            {
                return strClient;
            }

            set
            {
                strClient = value;
            }
        }

        public string[] StrArrayTableReference
        {
            get
            {
                return strArrayTableReference;
            }

            set
            {
                strArrayTableReference = value;
            }
        }

        public string[] StrArrayStoreProcedureReference
        {
            get
            {
                return strArrayStoreProcedureReference;
            }

            set
            {
                strArrayStoreProcedureReference = value;
            }
        }

        internal Simulation Simulation
        {
            get
            {
                return simulation;
            }

            set
            {
                simulation = value;
            }
        }
    }
}
