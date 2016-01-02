using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class ProposedReportAvailable
    {
        int no;
        string strReportTitle;
        string strReportType;
        string strFilterType;
        string strFieldRequired;
        string strFieldSource;
        string strRemarks;
        
        public ProposedReportAvailable() { }

        public ProposedReportAvailable(int no, string strReportTitle, string strReportType, string strFilterType, string strFieldRequired, string strFieldSource, string strRemarks)
        {
            this.No = no;
            this.StrReportTitle = strReportTitle;
            this.StrReportType = strReportType;
            this.StrFilterType = strFilterType;
            this.StrFieldRequired = strFieldRequired;
            this.StrFieldSource = strFieldSource;
            this.StrRemarks = strRemarks;
        }

        public int No
        {
            get
            {
                return no;
            }

            set
            {
                no = value;
            }
        }

        public string StrReportTitle
        {
            get
            {
                return strReportTitle;
            }

            set
            {
                strReportTitle = value;
            }
        }

        public string StrReportType
        {
            get
            {
                return strReportType;
            }

            set
            {
                strReportType = value;
            }
        }

        public string StrFilterType
        {
            get
            {
                return strFilterType;
            }

            set
            {
                strFilterType = value;
            }
        }

        public string StrFieldRequired
        {
            get
            {
                return strFieldRequired;
            }

            set
            {
                strFieldRequired = value;
            }
        }

        public string StrFieldSource
        {
            get
            {
                return strFieldSource;
            }

            set
            {
                strFieldSource = value;
            }
        }

        public string StrRemarks
        {
            get
            {
                return strRemarks;
            }

            set
            {
                strRemarks = value;
            }
        }
    }
}
