using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_QC.Interface
{
    interface iNewProject
    {
        int projectID { get; set; }
        string projectName { get; set; }
        string projectType { get; set; }
        string LOB { get; set; }
        string division { get; set; }
        DateTime projectStartDate { get; set; }
        DataSet dsMemberProject { get; set; }
        Boolean BRD { get; set; }
        Boolean FSD { get; set; }
        Boolean CDS { get; set; }
        DateTime tglBRD { get; set; }
        DateTime tglFSD { get; set; }
        DateTime tglCDS { get; set; }
    }
}
