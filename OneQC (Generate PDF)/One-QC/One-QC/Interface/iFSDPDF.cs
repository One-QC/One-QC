using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Interface
{
    interface iFSDPDF
    {
        string strProID { get; set; }
        string strProTitle { get; set; }
        string strProType { get; set; }
        
        string strProObjective { get; set; }
        string strProAppName { get; set; }

        string strProTestScenario { get; set; }
        string strProOtherInfo { get; set; }

        string[] strArrayProDatabase { get; set; }
        string[] strArrayProMiddleware { get; set; }
        string[] strArrayProJobBatch { get; set; }
        string[] strArrayProParam { get; set; }

        string[] strArrayProPicturePathTopology { get; set; }
        string[] strArrayProPicturePathMenuRelation { get; set; }
        string[] strArrayProPicturePathDatabaseDiagram { get; set; }
        
        List<RevisionHistory> listRevisionHistory { get; set; }
        List<Solution> listSolution { get; set; }
        List<Attachment> listAttachment { get; set; }
        List<Approval> listApproval { get; set; }
    }
}
