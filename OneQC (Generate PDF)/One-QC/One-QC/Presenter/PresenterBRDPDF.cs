using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Presenter
{
    class PresenterBRDPDF
    {
        private Model.ModelBRDPDF modelBRD = null;
        private Interface.iBRDPDF iBRD = null;

        public PresenterBRDPDF(Interface.iBRDPDF iBRD)
        {
            modelBRD = new Model.ModelBRDPDF();
            this.iBRD = iBRD;
        }

        public void GenerateBRD()
        {
            modelBRD.GenerateBRD(iBRD.strProID, iBRD.strProTitle, iBRD.strProBRD, iBRD.strProSFAT, iBRD.strProITRoadMap, iBRD.datetimeProDate, iBRD.strProBAName, iBRD.strProBUName, iBRD.strProBUEmail, iBRD.strProBUDivision, iBRD.strProBUOfficeID, iBRD.strProBUCostCenter, iBRD.listRevisionHistory, iBRD.listApproval, iBRD.listDistributionList, iBRD.listGlossary, iBRD.strProOverview, iBRD.strProDependencies, iBRD.listStakeholder, iBRD.listCurrentBFD, iBRD.listProposedBFD, iBRD.listProposedReportAvailable, iBRD.listSecurityRequirement, iBRD.listBackupRequirement, iBRD.strArrayProUMMenu, iBRD.strArrayProUMDiv, iBRD.boolMatrixProUM, iBRD.listAssumption, iBRD.listAppendix);
        }
    }
}
