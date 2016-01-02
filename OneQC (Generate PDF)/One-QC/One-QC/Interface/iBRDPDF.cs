using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Interface
{
    interface iBRDPDF
    {
        string strProID { get; set; }
        string strProTitle { get; set; }
        string strProBRD { get; set; }
        string strProSFAT { get; set; }
        string strProITRoadMap { get; set; }
        DateTime datetimeProDate { get; set; }
        
        string strProBAName { get; set; }
        string strProBUName { get; set; }
        string strProBUEmail { get; set; }
        string strProBUDivision { get; set; }
        string strProBUOfficeID { get; set; }
        string strProBUCostCenter { get; set; }

        string strProOverview { get; set; }
        string strProDependencies { get; set; }

        string[] strArrayProUMMenu { get; set; }
        string[] strArrayProUMDiv { get; set; }
        bool[][] boolMatrixProUM { get; set; }

        List<RevisionHistory> listRevisionHistory { get; set; }
        List<Approval> listApproval { get; set; }
        List<DistributionList> listDistributionList { get; set; }
        List<Glossary> listGlossary { get; set; }
        List<Stakeholder> listStakeholder { get; set; }
        List<CurrentBFD> listCurrentBFD { get; set; }
        List<ProposedBFD> listProposedBFD { get; set; }
        List<ProposedReportAvailable> listProposedReportAvailable { get; set; }
        List<SecurityRequirement> listSecurityRequirement { get; set; }
        List<BackupRequirement> listBackupRequirement { get; set; }
        List<Assumption> listAssumption { get; set; }
        List<Appendix> listAppendix { get; set; }
    }
}
