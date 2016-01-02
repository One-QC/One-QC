using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Scenario
    {
        string strScenario;
        string strBRID;
        string strExpectedResult;
        string strDescription;
        bool isOK;
        
        public Scenario() { }

        public Scenario(string strScenario, string strBRID, string strExpectedResult, string strDescription, bool isOK)
        {
            this.StrScenario = strScenario;
            this.StrBRID = strBRID;
            this.StrExpectedResult = strExpectedResult;
            this.StrDescription = strDescription;
            this.IsOK = isOK;
        }

        public string StrScenario
        {
            get
            {
                return strScenario;
            }

            set
            {
                strScenario = value;
            }
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

        public string StrExpectedResult
        {
            get
            {
                return strExpectedResult;
            }

            set
            {
                strExpectedResult = value;
            }
        }

        public string StrDescription
        {
            get
            {
                return strDescription;
            }

            set
            {
                strDescription = value;
            }
        }

        public bool IsOK
        {
            get
            {
                return isOK;
            }

            set
            {
                isOK = value;
            }
        }
    }
}
