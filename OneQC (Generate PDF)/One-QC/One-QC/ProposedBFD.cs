using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class ProposedBFD
    {
        string strBRID;
        string strBRDesc;
        string strResponsibleBU;
        string strVersion;
        
        public ProposedBFD() { }

        public ProposedBFD(string strBRID, string strBRDesc, string strResponsibleBU, string strVersion)
        {
            this.StrBRID = strBRID;
            this.StrBRDesc = strBRDesc;
            this.StrResponsibleBU = strResponsibleBU;
            this.StrVersion = strVersion;
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

        public string StrBRDesc
        {
            get
            {
                return strBRDesc;
            }

            set
            {
                strBRDesc = value;
            }
        }

        public string StrResponsibleBU
        {
            get
            {
                return strResponsibleBU;
            }

            set
            {
                strResponsibleBU = value;
            }
        }

        public string StrVersion
        {
            get
            {
                return strVersion;
            }

            set
            {
                strVersion = value;
            }
        }
    }
}
