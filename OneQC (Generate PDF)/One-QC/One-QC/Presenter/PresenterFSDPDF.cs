using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Presenter
{
    class PresenterFSDPDF
    {
        private Model.ModelFSDPDF modelFSD = null;
        private Interface.iFSDPDF iFSD = null;

        public PresenterFSDPDF(Interface.iFSDPDF iFSD)
        {
            modelFSD = new Model.ModelFSDPDF();
            this.iFSD = iFSD;
        }

        public void GenerateFSD()
        {
            modelFSD.GenerateFSD(iFSD.strProID, iFSD.strProTitle, iFSD.strProType, iFSD.listRevisionHistory, iFSD.strProObjective, iFSD.strProAppName, iFSD.strArrayProDatabase, iFSD.strArrayProMiddleware, iFSD.strArrayProPicturePathTopology, iFSD.strArrayProPicturePathMenuRelation, iFSD.strArrayProPicturePathDatabaseDiagram, iFSD.listSolution, iFSD.strArrayProJobBatch, iFSD.strArrayProParam, iFSD.listAttachment, iFSD.strProTestScenario, iFSD.strProOtherInfo, iFSD.listApproval);
        }
    }
}
