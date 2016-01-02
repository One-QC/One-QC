using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Assumption
    {
        int no;
        string strAssumption;

        public Assumption() { }

        public Assumption(int no, string strAssumption)
        {
            this.No = no;
            this.StrAssumption = strAssumption;
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

        public string StrAssumption
        {
            get
            {
                return strAssumption;
            }

            set
            {
                strAssumption = value;
            }
        }
    }
}
