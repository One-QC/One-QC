using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class BackupRequirement
    {
        int no;
        string strData;
        string strFrequency;
        string strBackupType;
        string strStorage;
        
        public BackupRequirement() { }

        public BackupRequirement(int no, string strData, string strFrequency, string strBackupType, string strStorage)
        {
            this.No = no;
            this.StrData = strData;
            this.StrFrequency = strFrequency;
            this.StrBackupType = strBackupType;
            this.StrStorage = strStorage;
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

        public string StrData
        {
            get
            {
                return strData;
            }

            set
            {
                strData = value;
            }
        }

        public string StrFrequency
        {
            get
            {
                return strFrequency;
            }

            set
            {
                strFrequency = value;
            }
        }

        public string StrBackupType
        {
            get
            {
                return strBackupType;
            }

            set
            {
                strBackupType = value;
            }
        }

        public string StrStorage
        {
            get
            {
                return strStorage;
            }

            set
            {
                strStorage = value;
            }
        }
    }
}
