using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class Glossary
    {
        string strTerm;
        string strDefinition;

        public Glossary() { }

        public Glossary(string strTerm, string strDefinition)
        {
            this.StrTerm = strTerm;
            this.StrDefinition = strDefinition;
        }

        public string StrTerm
        {
            get
            {
                return strTerm;
            }

            set
            {
                strTerm = value;
            }
        }

        public string StrDefinition
        {
            get
            {
                return strDefinition;
            }

            set
            {
                strDefinition = value;
            }
        }
    }
}
