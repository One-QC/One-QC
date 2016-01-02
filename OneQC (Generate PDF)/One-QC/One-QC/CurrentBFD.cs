using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class CurrentBFD
    {
        string strTitle;
        string strContent;
        string strPicturePath;
        
        public CurrentBFD() { }

        public CurrentBFD(string strTitle, string strContent, string strPicturePath)
        {
            this.StrTitle = strTitle;
            this.StrContent = strContent;
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

        public string StrContent
        {
            get
            {
                return strContent;
            }

            set
            {
                strContent = value;
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
