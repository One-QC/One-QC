using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Stakeholder
    {
        int no;
        string strStakeholder;
        string strImplication;
        
        public Stakeholder() { }

        public Stakeholder(int no, string strStakeholder, string strImplication)
        {
            this.No = no;
            this.StrStakeholder = strStakeholder;
            this.StrImplication = strImplication;
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

        public string StrStakeholder
        {
            get
            {
                return strStakeholder;
            }

            set
            {
                strStakeholder = value;
            }
        }

        public string StrImplication
        {
            get
            {
                return strImplication;
            }

            set
            {
                strImplication = value;
            }
        }
    }
}
