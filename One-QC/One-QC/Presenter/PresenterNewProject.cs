using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_QC.Presenter
{
    class PresenterNewProject
    {
        private Model.ModelNewProject mNewProject = null;
        private Interface.iNewProject iNProject = null;

        public PresenterNewProject(Interface.iNewProject intNProject)
        {
            this.mNewProject = new Model.ModelNewProject();
            this.iNProject = intNProject;
        }




    }


    
}
