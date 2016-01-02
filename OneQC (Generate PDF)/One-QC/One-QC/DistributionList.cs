using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class DistributionList
    {
        string strName;
        string strTitle;
        string strBusinessUnit;
        
        public DistributionList() { }

        public DistributionList(string strName, string strTitle, string strBusinessUnit)
        {
            this.StrName = strName;
            this.StrTitle = strTitle;
            this.StrBusinessUnit = strBusinessUnit;
        }

        public string StrName
        {
            get
            {
                return strName;
            }

            set
            {
                strName = value;
            }
        }

        public string StrTitle
        {
            get
            {
                return strTitle;
            }

            set
            {
                strTitle = value;
            }
        }

        public string StrBusinessUnit
        {
            get
            {
                return strBusinessUnit;
            }

            set
            {
                strBusinessUnit = value;
            }
        }
    }
}
