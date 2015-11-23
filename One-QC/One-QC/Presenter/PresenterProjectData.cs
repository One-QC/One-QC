using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Presenter
{
    class PresenterProjectData
    {
        private Model.ModelProjectData modelProjectData = null;
        private Interface.iProjectData interfaceProjectData = null;

        public PresenterProjectData(Interface.iProjectData interfaceProjectData)
        {
            this.modelProjectData = new Model.ModelProjectData();
            this.interfaceProjectData = interfaceProjectData;
        }

        public void Commit()
        {
            modelProjectData.GenerateBRDCover(interfaceProjectData.strProID, interfaceProjectData.strProTitle, interfaceProjectData.datetimeProDate, interfaceProjectData.strProBRD, interfaceProjectData.strProSFAT, interfaceProjectData.strProITRoadMap, interfaceProjectData.strEmpIDBA, interfaceProjectData.strEmpIDBU);
        }
    }
}
