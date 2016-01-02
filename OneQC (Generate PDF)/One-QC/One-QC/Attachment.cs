using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Attachment
    {
        string strTitle;
        string strText;
        string strPicturePath;
        
        public Attachment() { }

        public Attachment(string strTitle, string strText, string strPicturePath)
        {
            this.StrTitle = strTitle;
            this.StrText = strText;
            this.StrPicturePath = strPicturePath;
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

        public string StrText
        {
            get
            {
                return strText;
            }

            set
            {
                strText = value;
            }
        }

        public string StrPicturePath
        {
            get
            {
                return strPicturePath;
            }

            set
            {
                strPicturePath = value;
            }
        }
    }
}
