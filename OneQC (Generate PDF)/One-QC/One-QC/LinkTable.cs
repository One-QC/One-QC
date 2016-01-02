using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    class LinkTable
    {
        CurrentBFD currentBFD;
        Solution solution;

        public LinkTable() { }

        public LinkTable(CurrentBFD currentBFD, Solution solution)
        {
            this.CurrentBFD = currentBFD;
            this.Solution = solution;
        }

        public LinkTable(string strTitle, string strContent, string strPicturePath, string strBRID, string strHandleBRID, string strFlowPicturePath, string strFlowText, string strClient, string[] strArrayTableReference, string[] strArrayStoreProcedureReference, Simulation simulation)
        {
            this.CurrentBFD = new CurrentBFD(strTitle, strContent, strPicturePath);
            this.Solution = new Solution(strBRID, strHandleBRID, strFlowPicturePath, strFlowText, strClient, strArrayTableReference, strArrayStoreProcedureReference, simulation);
        }

        internal CurrentBFD CurrentBFD
        {
            get
            {
                return currentBFD;
            }

            set
            {
                currentBFD = value;
            }
        }

        internal Solution Solution
        {
            get
            {
                return solution;
            }

            set
            {
                solution = value;
            }
        }
    }
}
