using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class RevisionHistory
    {
        string strVersion;
        string strAuthor;
        string strChanges;
        DateTime datetimeIssueDate;
        
        public RevisionHistory() { }

        public RevisionHistory(string strVersion, string strAuthor, string strChanges, DateTime datetimeIssueDate)
        {
            this.StrVersion = strVersion;
            this.StrAuthor = strAuthor;
            this.StrChanges = strChanges;
            this.DatetimeIssueDate = datetimeIssueDate;
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

        public string StrAuthor
        {
            get
            {
                return strAuthor;
            }

            set
            {
                strAuthor = value;
            }
        }

        public string StrChanges
        {
            get
            {
                return strChanges;
            }

            set
            {
                strChanges = value;
            }
        }

        public DateTime DatetimeIssueDate
        {
            get
            {
                return datetimeIssueDate;
            }

            set
            {
                datetimeIssueDate = value;
            }
        }
    }
}
