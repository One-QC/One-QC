using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Appendix
    {
        string strText;
        string strPicturePath;
        
        public Appendix() { }

        public Appendix(string strText, string strPicturePath)
        {
            this.StrText = strText;
            this.StrPicturePath = strPicturePath;
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
