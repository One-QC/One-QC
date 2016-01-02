using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Interface
{
    interface iCDSPDF
    {
        string strProID { get; set; }
        string strProTitle { get; set; }
        string strProCDS { get; set; }
        string strProType { get; set; }
        string strProModule { get; set; }
        DateTime datetimeProDate { get; set; }

        string strProObjective { get; set; }
        string strProAppName { get; set; }
        string strProOtherInfo { get; set; }

        string[] strArrayProDatabase { get; set; }
        string[] strArrayProMiddleware { get; set; }

        string[] strArrayProPicturePathTopology { get; set; }
        string[] strArrayProPicturePathDatabaseDiagram { get; set; }

        List<RevisionHistory> listRevisionHistory { get; set; }
        List<LinkTable> listLinkTable { get; set; }
        List<Scenario> listPositiveScenario { get; set; }
        List<Scenario> listNegativeScenario { get; set; }
        List<Approval> listApproval { get; set; }
    }
}
