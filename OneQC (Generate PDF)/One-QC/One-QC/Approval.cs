using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Approval
    {
        string strRole;
        string strName;
        string strTitle;
        string strPlace;
        DateTime datetimeApprove;
        
        public Approval() { }

        public Approval(string strRole, string strName, string strTitle, DateTime datetimeApprove)
        {
            this.StrRole = strRole;
            this.StrName = strName;
            this.StrTitle = strTitle;
            this.DatetimeApprove = datetimeApprove;
        }

        public Approval(string strRole, string strName, string strTitle, string strPlace, DateTime datetimeApprove) : this(strRole, strName, strTitle, datetimeApprove)
        {
            this.StrPlace = strPlace;
        }

        public string StrRole
        {
            get
            {
                return strRole;
            }

            set
            {
                strRole = value;
            }
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

        public string StrPlace
        {
            get
            {
                return strPlace;
            }

            set
            {
                strPlace = value;
            }
        }

        public DateTime DatetimeApprove
        {
            get
            {
                return datetimeApprove;
            }

            set
            {
                datetimeApprove = value;
            }
        }
    }
}
