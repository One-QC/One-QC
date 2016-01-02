using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class SecurityRequirement
    {
        string strBRID;
        string strSecurityRequirement;
        string strApplyBRID;
        
        public SecurityRequirement() { }

        public SecurityRequirement(string strBRID, string strSecurityRequirement, string strApplyBRID)
        {
            this.StrBRID = strBRID;
            this.StrSecurityRequirement = strSecurityRequirement;
            this.StrApplyBRID = strApplyBRID;
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

        public string StrSecurityRequirement
        {
            get
            {
                return strSecurityRequirement;
            }

            set
            {
                strSecurityRequirement = value;
            }
        }

        public string StrApplyBRID
        {
            get
            {
                return strApplyBRID;
            }

            set
            {
                strApplyBRID = value;
            }
        }
    }
}
