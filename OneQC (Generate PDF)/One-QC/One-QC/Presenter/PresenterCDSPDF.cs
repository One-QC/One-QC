using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Presenter
{
    class PresenterCDSPDF
    {
        private Model.ModelCDSPDF modelCDS = null;
        private Interface.iCDSPDF iCDS = null;

        public PresenterCDSPDF(Interface.iCDSPDF iCDS)
        {
            modelCDS = new Model.ModelCDSPDF();
            this.iCDS = iCDS;
        }

        public void GenerateCDS()
        {
            modelCDS.GenerateCDS(iCDS.strProID, iCDS.strProTitle, iCDS.strProCDS, iCDS.strProType, iCDS.strProModule, iCDS.datetimeProDate, iCDS.listRevisionHistory, iCDS.strProObjective, iCDS.strProAppName, iCDS.strArrayProDatabase, iCDS.strArrayProMiddleware, iCDS.listLinkTable, iCDS.strArrayProPicturePathDatabaseDiagram, iCDS.strArrayProPicturePathTopology, iCDS.listPositiveScenario, iCDS.listNegativeScenario, iCDS.strProOtherInfo, iCDS.listApproval);
        }
    }
}
