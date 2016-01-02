using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using One_QC.Interface;

namespace One_QC
{
    public partial class FormGenerate : Form, Interface.iBRDPDF, Interface.iFSDPDF, Interface.iCDSPDF
    {
        #region DATA DUMMY
        string strProID = "TRBST14117";
        string strProTitle = "ProRPT Enhancement Phase 2";
        string strProBRD = "BRD/133/OPRISKDIV/5/2014/Victor Wijaya";
        string strProSFAT = "BST/133/OPRISKDIV/5/2014/Winarto Surjani";
        string strProITRoadMap = "125";
        DateTime datetimeProDate = DateTime.Now;
        string strProBAName = "Victor Wijaya";
        string strProBUName = "Winarto Surjani";
        string strProBUEmail = "winarto.surjani@ocbcnisp.com";
        string strProBUDivision = "Operation Risk Division";
        string strProBUOfficeID = "99781";
        string strProBUCostCenter = "232";
        string strProOverview = FillerText.MediumText;
        string strProDependencies = FillerText.Text;
        string[] strArrayProUMMenu = new string[3] { "A", "B", "C" };
        string[] strArrayProUMDiv = new string[3] { "1", "2", "3" };
        bool[][] boolMatrixProUM = new bool[3][];
        List<RevisionHistory> listRevisionHistory = new List<RevisionHistory>();
        List<Approval> listApproval = new List<Approval>();
        List<DistributionList> listDistributionList = new List<DistributionList>();
        List<Glossary> listGlossary = new List<Glossary>();
        List<Stakeholder> listStakeholder = new List<Stakeholder>();
        List<CurrentBFD> listCurrentBFD = new List<CurrentBFD>();
        List<ProposedBFD> listProposedBFD = new List<ProposedBFD>();
        List<ProposedReportAvailable> listProposedReportAvailable = new List<ProposedReportAvailable>();
        List<SecurityRequirement> listSecurityRequirement = new List<SecurityRequirement>();
        List<BackupRequirement> listBackupRequirement = new List<BackupRequirement>();
        List<Assumption> listAssumption = new List<Assumption>();
        List<Appendix> listAppendix = new List<Appendix>();

        string strProID2 = "TRBST15127";
        string strProTitle2 = "Menu Upload Treasury Product";
        string strProType = "Application";
        string strProObjective = FillerText.MediumText;
        string strProAppName = "MT103ToRTGSConverter";
        string strProTestScenario = FillerText.MediumText;
        string strProOtherInfo = FillerText.MediumText;
        string[] strArrayProDatabase = new string[3] { "DB1", "DB2", "DB3" };
        string[] strArrayProMiddleware = new string[3] { "MD1", "MD2", "MD3" };
        string[] strArrayProJobBatch = new string[3] { "Batch 1", "Batch 2", "Batch 3" };
        string[] strArrayProParam = new string[3] { "Param 1", "Param 2", "Param 3" };
        string[] strArrayProPicturePathTopology = new string[1] { "Tutut Ganteng.jpg" };
        string[] strArrayProPicturePathMenuRelation = new string[1] { "Tutut Ganteng.jpg" };
        string[] strArrayProPicturePathDatabaseDiagram = new string[3] { "Tutut Ganteng.jpg", "Tutut Ganteng.jpg", "Tutut Ganteng.jpg" };
        List<RevisionHistory> listRevisionHistory2 = new List<RevisionHistory>();
        List<Solution> listSolution = new List<Solution>();
        List<Attachment> listAttachment = new List<Attachment>();
        List<Approval> listApproval2 = new List<Approval>();

        string strProID3 = "TRBST15127";
        string strProTitle3 = "Menu Upload Treasury Product";
        string strProCDS = "TRBST15127/05DIY/2015";
        string strProType2 = "Application";
        string strProModule = "ProObligasi";
        DateTime datetimeProDate2 = DateTime.Now;
        string strProObjective2 = FillerText.MediumText;
        string strProAppName2 = "ProObligasi";
        string strProOtherInfo2 = FillerText.MediumText;
        string[] strArrayProDatabase2 = new string[3] { "DB1", "DB2", "DB3" };
        string[] strArrayProMiddleware2 = new string[3] { "MD1", "MD2", "MD3" };
        string[] strArrayProPicturePathTopology2 = new string[1] { "Tutut Ganteng.jpg" };
        string[] strArrayProPicturePathDatabaseDiagram2 = new string[3] { "Tutut Ganteng.jpg", "Tutut Ganteng.jpg", "Tutut Ganteng.jpg" };
        List<RevisionHistory> listRevisionHistory3 = new List<RevisionHistory>();
        List<LinkTable> listLinkTable = new List<LinkTable>();
        List<Scenario> listPositiveScenario = new List<Scenario>();
        List<Scenario> listNegativeScenario = new List<Scenario>();
        List<Approval> listApproval3 = new List<Approval>();
        #endregion

        #region DATA REAL
        private Presenter.PresenterBRDPDF presenterBRD = null;
        private Presenter.PresenterFSDPDF presenterFSD = null;
        private Presenter.PresenterCDSPDF presenterCDS = null;
        #endregion

        #region INTERFACE BRD
        string iBRDPDF.strProID
        {
            get
            {
                return strProID;
            }

            set
            {
                strProID = value;
            }
        }

        string iBRDPDF.strProTitle
        {
            get
            {
                return strProTitle;
            }

            set
            {
                strProTitle = value;
            }
        }

        string iBRDPDF.strProBRD
        {
            get
            {
                return strProBRD;
            }

            set
            {
                strProBRD = value;
            }
        }

        string iBRDPDF.strProSFAT
        {
            get
            {
                return strProSFAT;
            }

            set
            {
                strProSFAT = value;
            }
        }

        string iBRDPDF.strProITRoadMap
        {
            get
            {
                return strProITRoadMap;
            }

            set
            {
                strProITRoadMap = value;
            }
        }

        DateTime iBRDPDF.datetimeProDate
        {
            get
            {
                return datetimeProDate;
            }

            set
            {
                datetimeProDate = value;
            }
        }

        string iBRDPDF.strProBAName
        {
            get
            {
                return strProBAName;
            }

            set
            {
                strProBAName = value;
            }
        }

        string iBRDPDF.strProBUName
        {
            get
            {
                return strProBUName;
            }

            set
            {
                strProBUName = value;
            }
        }

        string iBRDPDF.strProBUEmail
        {
            get
            {
                return strProBUEmail;
            }

            set
            {
                strProBUEmail = value;
            }
        }

        string iBRDPDF.strProBUDivision
        {
            get
            {
                return strProBUDivision;
            }

            set
            {
                strProBUDivision = value;
            }
        }

        string iBRDPDF.strProBUOfficeID
        {
            get
            {
                return strProBUOfficeID;
            }

            set
            {
                strProBUOfficeID = value;
            }
        }

        string iBRDPDF.strProBUCostCenter
        {
            get
            {
                return strProBUCostCenter;
            }

            set
            {
                strProBUCostCenter = value;
            }
        }

        string iBRDPDF.strProOverview
        {
            get
            {
                return strProOverview;
            }

            set
            {
                strProOverview = value;
            }
        }

        string iBRDPDF.strProDependencies
        {
            get
            {
                return strProDependencies;
            }

            set
            {
                strProDependencies = value;
            }
        }

        string[] iBRDPDF.strArrayProUMMenu
        {
            get
            {
                return strArrayProUMMenu;
            }

            set
            {
                strArrayProUMMenu = value;
            }
        }

        string[] iBRDPDF.strArrayProUMDiv
        {
            get
            {
                return strArrayProUMDiv;
            }

            set
            {
                strArrayProUMDiv = value;
            }
        }

        bool[][] iBRDPDF.boolMatrixProUM
        {
            get
            {
                return boolMatrixProUM;
            }

            set
            {
                boolMatrixProUM = value;
            }
        }

        List<RevisionHistory> iBRDPDF.listRevisionHistory
        {
            get
            {
                return listRevisionHistory;
            }

            set
            {
                listRevisionHistory = value;
            }
        }

        List<Approval> iBRDPDF.listApproval
        {
            get
            {
                return listApproval;
            }

            set
            {
                listApproval = value;
            }
        }

        List<DistributionList> iBRDPDF.listDistributionList
        {
            get
            {
                return listDistributionList;
            }

            set
            {
                listDistributionList = value;
            }
        }

        List<Glossary> iBRDPDF.listGlossary
        {
            get
            {
                return listGlossary;
            }

            set
            {
                listGlossary = value;
            }
        }

        List<Stakeholder> iBRDPDF.listStakeholder
        {
            get
            {
                return listStakeholder;
            }

            set
            {
                listStakeholder = value;
            }
        }

        List<CurrentBFD> iBRDPDF.listCurrentBFD
        {
            get
            {
                return listCurrentBFD;
            }

            set
            {
                listCurrentBFD = value;
            }
        }

        List<ProposedBFD> iBRDPDF.listProposedBFD
        {
            get
            {
                return listProposedBFD;
            }

            set
            {
                listProposedBFD = value;
            }
        }

        List<ProposedReportAvailable> iBRDPDF.listProposedReportAvailable
        {
            get
            {
                return listProposedReportAvailable;
            }

            set
            {
                listProposedReportAvailable = value;
            }
        }

        List<SecurityRequirement> iBRDPDF.listSecurityRequirement
        {
            get
            {
                return listSecurityRequirement;
            }

            set
            {
                listSecurityRequirement = value;
            }
        }

        List<BackupRequirement> iBRDPDF.listBackupRequirement
        {
            get
            {
                return listBackupRequirement;
            }

            set
            {
                listBackupRequirement = value;
            }
        }

        List<Assumption> iBRDPDF.listAssumption
        {
            get
            {
                return listAssumption;
            }

            set
            {
                listAssumption = value;
            }
        }

        List<Appendix> iBRDPDF.listAppendix
        {
            get
            {
                return listAppendix;
            }

            set
            {
                listAppendix = value;
            }
        }
        #endregion

        #region INTERFACE FSD
        string iFSDPDF.strProID
        {
            get
            {
                return strProID2;
            }

            set
            {
                strProID2 = value;
            }
        }

        string iFSDPDF.strProTitle
        {
            get
            {
                return strProTitle2;
            }

            set
            {
                strProTitle2 = value;
            }
        }

        string iFSDPDF.strProType
        {
            get
            {
                return strProType;
            }

            set
            {
                strProType = value;
            }
        }

        string iFSDPDF.strProObjective
        {
            get
            {
                return strProObjective;
            }

            set
            {
                strProObjective = value;
            }
        }

        string iFSDPDF.strProAppName
        {
            get
            {
                return strProAppName;
            }

            set
            {
                strProAppName = value;
            }
        }

        string iFSDPDF.strProTestScenario
        {
            get
            {
                return strProTestScenario;
            }

            set
            {
                strProTestScenario = value;
            }
        }

        string iFSDPDF.strProOtherInfo
        {
            get
            {
                return strProOtherInfo;
            }

            set
            {
                strProOtherInfo = value;
            }
        }

        string[] iFSDPDF.strArrayProDatabase
        {
            get
            {
                return strArrayProDatabase;
            }

            set
            {
                strArrayProDatabase = value;
            }
        }

        string[] iFSDPDF.strArrayProMiddleware
        {
            get
            {
                return strArrayProMiddleware;
            }

            set
            {
                strArrayProMiddleware = value;
            }
        }

        string[] iFSDPDF.strArrayProJobBatch
        {
            get
            {
                return strArrayProJobBatch;
            }

            set
            {
                strArrayProJobBatch = value;
            }
        }

        string[] iFSDPDF.strArrayProParam
        {
            get
            {
                return strArrayProParam;
            }

            set
            {
                strArrayProParam = value;
            }
        }

        string[] iFSDPDF.strArrayProPicturePathTopology
        {
            get
            {
                return strArrayProPicturePathTopology;
            }

            set
            {
                strArrayProPicturePathTopology = value;
            }
        }

        string[] iFSDPDF.strArrayProPicturePathMenuRelation
        {
            get
            {
                return strArrayProPicturePathMenuRelation;
            }

            set
            {
                strArrayProPicturePathMenuRelation = value;
            }
        }

        string[] iFSDPDF.strArrayProPicturePathDatabaseDiagram
        {
            get
            {
                return strArrayProPicturePathDatabaseDiagram;
            }

            set
            {
                strArrayProPicturePathDatabaseDiagram = value;
            }
        }
        
        List<RevisionHistory> iFSDPDF.listRevisionHistory
        {
            get
            {
                return listRevisionHistory2;
            }

            set
            {
                listRevisionHistory2 = value;
            }
        }

        List<Solution> iFSDPDF.listSolution
        {
            get
            {
                return listSolution;
            }

            set
            {
                listSolution = value;
            }
        }

        List<Attachment> iFSDPDF.listAttachment
        {
            get
            {
                return listAttachment;
            }

            set
            {
                listAttachment = value;
            }
        }

        List<Approval> iFSDPDF.listApproval
        {
            get
            {
                return listApproval2;
            }

            set
            {
                listApproval2 = value;
            }
        }
        #endregion

        #region INTERFACE CDS
        string iCDSPDF.strProID
        {
            get
            {
                return strProID3;
            }

            set
            {
                strProID3 = value;
            }
        }

        string iCDSPDF.strProTitle
        {
            get
            {
                return strProTitle3;
            }

            set
            {
                strProTitle3 = value;
            }
        }

        string iCDSPDF.strProCDS
        {
            get
            {
                return strProCDS;
            }

            set
            {
                strProCDS = value;
            }
        }

        string iCDSPDF.strProType
        {
            get
            {
                return strProType2;
            }

            set
            {
                strProType2 = value;
            }
        }

        string iCDSPDF.strProModule
        {
            get
            {
                return strProModule;
            }

            set
            {
                strProModule = value;
            }
        }

        DateTime iCDSPDF.datetimeProDate
        {
            get
            {
                return datetimeProDate2;
            }

            set
            {
                datetimeProDate2 = value;
            }
        }

        string iCDSPDF.strProObjective
        {
            get
            {
                return strProObjective2;
            }

            set
            {
                strProObjective2 = value;
            }
        }

        string iCDSPDF.strProAppName
        {
            get
            {
                return strProAppName2;
            }

            set
            {
                strProAppName2 = value;
            }
        }

        string iCDSPDF.strProOtherInfo
        {
            get
            {
                return strProOtherInfo2;
            }

            set
            {
                strProOtherInfo2 = value;
            }
        }

        string[] iCDSPDF.strArrayProDatabase
        {
            get
            {
                return strArrayProDatabase2;
            }

            set
            {
                strArrayProDatabase2 = value;
            }
        }

        string[] iCDSPDF.strArrayProMiddleware
        {
            get
            {
                return strArrayProMiddleware2;
            }

            set
            {
                strArrayProMiddleware2 = value;
            }
        }

        string[] iCDSPDF.strArrayProPicturePathTopology
        {
            get
            {
                return strArrayProPicturePathTopology2;
            }

            set
            {
                strArrayProPicturePathTopology2 = value;
            }
        }

        string[] iCDSPDF.strArrayProPicturePathDatabaseDiagram
        {
            get
            {
                return strArrayProPicturePathDatabaseDiagram2;
            }

            set
            {
                strArrayProPicturePathDatabaseDiagram2 = value;
            }
        }

        List<RevisionHistory> iCDSPDF.listRevisionHistory
        {
            get
            {
                return listRevisionHistory3;
            }

            set
            {
                listRevisionHistory3 = value;
            }
        }

        List<LinkTable> iCDSPDF.listLinkTable
        {
            get
            {
                return listLinkTable;
            }

            set
            {
                listLinkTable = value;
            }
        }

        List<Scenario> iCDSPDF.listPositiveScenario
        {
            get
            {
                return listPositiveScenario;
            }

            set
            {
                listPositiveScenario = value;
            }
        }

        List<Scenario> iCDSPDF.listNegativeScenario
        {
            get
            {
                return listNegativeScenario;
            }

            set
            {
                listNegativeScenario = value;
            }
        }

        List<Approval> iCDSPDF.listApproval
        {
            get
            {
                return listApproval3;
            }

            set
            {
                listApproval3 = value;
            }
        }
        #endregion

        public FormGenerate()
        {
            #region DATA DUMMY REVISION HISTORY
            listRevisionHistory.Add(new RevisionHistory("1.0", "Victor Wijaya", "Initial Version", new DateTime(2015, 1, 1)));
            listRevisionHistory.Add(new RevisionHistory("1.2", "Sindi Amilia", "Tutut", new DateTime(2015, 2, 2)));
            listRevisionHistory.Add(new RevisionHistory("1.3", "An Nisa Sari Khoiriah", "Dudut", new DateTime(2015, 3, 3)));
            listRevisionHistory.Add(new RevisionHistory("1.4", "Wong Anthony Hermanto", "Ninda", new DateTime(2015, 4, 4)));
            listRevisionHistory.Add(new RevisionHistory("1.5", "Victor Wijaya", "Final Version", DateTime.Now));
            #endregion

            #region DATA DUMMY APPROVAL
            listApproval.Add(new Approval("BA", "Victor Wijaya", "Business Analyst", DateTime.Now));
            listApproval.Add(new Approval("PM", "Rachmantyo Saroso", "Project Manager", DateTime.Now));
            listApproval.Add(new Approval("LOBH", "Alvin Wibowo", "LOB Head", DateTime.Now));
            listApproval.Add(new Approval("BU", "Shanti Indriani", "Staff", DateTime.Now));
            listApproval.Add(new Approval("BU", "Harri Rachman", "Staff", DateTime.Now));
            listApproval.Add(new Approval("BUH", "Chandra Wulansari", "Head Staff", DateTime.Now));
            listApproval.Add(new Approval("BUH", "Winarto Surjadi", "Head Staff", DateTime.Now));
            listApproval.Add(new Approval("BUDH", "Vinodhan Jayasilan", "Head Division", DateTime.Now));
            listApproval.Add(new Approval("ITRM", "Wong Anthony", "Risk Management", DateTime.Now));
            listApproval.Add(new Approval("S", "Winarto Surjadi", "Head Staff", DateTime.Now));
            listApproval.Add(new Approval("S", "Vinodhan Jayasilan", "Head Division", DateTime.Now));
            listApproval.Add(new Approval("S", "David Formula", "Head Division", DateTime.Now));
            #endregion

            #region DATA DUMMY DISTRIBUTION LIST
            listDistributionList.Add(new DistributionList("Wong Anthony Hermanto", "Staff", "Banking Academy for IT"));
            listDistributionList.Add(new DistributionList("An Nisa Sari Khoiriah", "Staff", "Banking Academy for IT"));
            listDistributionList.Add(new DistributionList("Sindi Amilia", "Staff", "Banking Academy for IT"));
            #endregion

            #region DATA DUMMY GLOSSARY
            listGlossary.Add(new Glossary("ORMS", "Operational Risk Management System"));
            listGlossary.Add(new Glossary("BCM", "Business Continuity Management"));
            listGlossary.Add(new Glossary("BCP", "Business Continuity Plan"));
            listGlossary.Add(new Glossary("BIA", "Business Impact Analysis"));
            listGlossary.Add(new Glossary("ICA", "Internal Control Attestation"));
            #endregion

            #region DATA DUMMY STAKEHOLDER
            listStakeholder.Add(new Stakeholder(1, "Cabang dan Unit Kerja Kantor Pusat", "Screen RCSA Inputer / Approval / Reviewer"));
            listStakeholder.Add(new Stakeholder(2, "Operational Risk Management", "Screen Parameter Risk Event Type"));
            #endregion

            #region DATA DUMMY CURRENT BFD
            listCurrentBFD.Add(new CurrentBFD("Menu Param RCSA", FillerText.MediumText, "CBFD 1.png"));
            listCurrentBFD.Add(new CurrentBFD("Menu Param RCSA > Parameter Risk Event Type", FillerText.MediumText, "CBFD 2.png"));
            listCurrentBFD.Add(new CurrentBFD("Menu RLED Inputer / Approval / Reviewer", FillerText.MediumText, "CBFD 3.png"));
            listCurrentBFD.Add(new CurrentBFD("Menu RCSA Inputer / Approval / Reviewer > RCSA Transaction", FillerText.MediumText, "CBFD 4.png"));
            listCurrentBFD.Add(new CurrentBFD("Menu Otorisasi > Approval > Approval Transaksi RCSA", FillerText.MediumText, "CBFD 5.png"));
            listCurrentBFD.Add(new CurrentBFD("Menu Edit Hirarki", FillerText.MediumText, "CBFD 6.png"));
            listCurrentBFD.Add(new CurrentBFD("Menu Upload Parameter", FillerText.MediumText, "CBFD 7.png"));
            listCurrentBFD.Add(new CurrentBFD("Apa Aja Boleh", FillerText.Text, ""));
            #endregion

            #region DATA DUMMY PROPOSED BFD
            listProposedBFD.Add(new ProposedBFD("RCSA_001", FillerText.MediumText, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("RCSA_002", FillerText.Text, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("RCSA_003", FillerText.ShortText, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("RCSA_004", FillerText.Text, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("HIRA_001", FillerText.MediumText, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("PARA_001", FillerText.Text, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("RLED_001", FillerText.ShortText, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("REPO_001", FillerText.Text, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            listProposedBFD.Add(new ProposedBFD("REPO_002", FillerText.MediumText, "Developed by : System Analyst\nRequested by : ORM", "1.5"));
            #endregion

            #region DATA DUMMY PROPOSED REPORT AVAILABLE
            listProposedReportAvailable.Add(new ProposedReportAvailable(1, "Belum Ada Judul", "Adhoc", FillerText.ShortText, FillerText.ShortText, "Tutut", "Dudut"));
            listProposedReportAvailable.Add(new ProposedReportAvailable(2, "Belum Ada Judul", "Adhoc", FillerText.ShortText, FillerText.ShortText, "Tutut", "Dudut"));
            listProposedReportAvailable.Add(new ProposedReportAvailable(3, "Belum Ada Judul", "Adhoc", FillerText.ShortText, FillerText.ShortText, "Tutut", "Dudut"));
            listProposedReportAvailable.Add(new ProposedReportAvailable(4, "Belum Ada Judul", "Adhoc", FillerText.ShortText, FillerText.ShortText, "Tutut", "Dudut"));
            listProposedReportAvailable.Add(new ProposedReportAvailable(5, "Belum Ada Judul", "Adhoc", FillerText.ShortText, FillerText.ShortText, "Tutut", "Dudut"));
            #endregion

            #region DATA DUMMY SECURITY REQUIREMENT
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[0].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[1].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[2].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[3].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[4].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[5].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[6].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[7].StrBRID, "Antivirus", "Diinstal"));
            listSecurityRequirement.Add(new SecurityRequirement(listProposedBFD[8].StrBRID, "Antivirus", "Diinstal"));
            #endregion

            #region DATA DUMMY BACKUP REQUIREMENT
            listBackupRequirement.Add(new BackupRequirement(1, "Data Dummy", "Setiap Hari", "Backup Bulanan", "Hard Disk"));
            listBackupRequirement.Add(new BackupRequirement(2, "Data Dummy", "Setiap Hari", "Backup Bulanan", "Hard Disk"));
            listBackupRequirement.Add(new BackupRequirement(3, "Data Dummy", "Setiap Hari", "Backup Bulanan", "Hard Disk"));
            listBackupRequirement.Add(new BackupRequirement(4, "Data Dummy", "Setiap Hari", "Backup Bulanan", "Hard Disk"));
            listBackupRequirement.Add(new BackupRequirement(5, "Data Dummy", "Setiap Hari", "Backup Bulanan", "Hard Disk"));
            #endregion

            #region DATA DUMMY ASSUMPTION
            listAssumption.Add(new Assumption(1, "Data yang dipakai pada dokumen ini hanyalah data dummy."));
            listAssumption.Add(new Assumption(2, "Program yang kami buat masih berupa prototype."));
            listAssumption.Add(new Assumption(3, "Beberapa data diambil dari BRD yang asli"));
            #endregion

            #region DATA DUMMY APPENDIX
            listAppendix.Add(new Appendix(FillerText.MediumText, "Tutut Ganteng.jpg"));
            #endregion

            #region DATA DUMMY USER MATRIX
            boolMatrixProUM[0] = new bool[3] { true, false, true };
            boolMatrixProUM[1] = new bool[3] { false, true, false };
            boolMatrixProUM[2] = new bool[3] { true, false, true };
            #endregion

            #region DATA DUMMY REVISION HISTORY 2
            listRevisionHistory2 = listRevisionHistory;
            #endregion

            #region DATA DUMMY SOLUTION
            listSolution.Add(new Solution("BRID 1", "A Interface", "Tutut Ganteng.jpg", FillerText.MediumText, "Client", new string[3] { "Table 1", "Table 2", "Table 3" }, new string[3] { "SP 1", "SP 2", "SP 3" }, new Simulation("Input", "Process", "Output")));
            listSolution.Add(new Solution("BRID 2", "B Interface", "", FillerText.MediumText, "Client", new string[3] { "Table 1", "Table 2", "Table 3" }, new string[3] { "SP 1", "SP 2", "SP 3" }, new Simulation("Input", "Process", "Output")));
            listSolution.Add(new Solution("BRID 3", "C Interface", "Tutut Ganteng.jpg", FillerText.MediumText, "Client", new string[3] { "Table 1", "Table 2", "Table 3" }, new string[3] { "SP 1", "SP 2", "SP 3" }, new Simulation("Input", "Process", "Output")));
            listSolution.Add(new Solution("BRID 4", "D Interface", "", FillerText.MediumText, "Client", new string[3] { "Table 1", "Table 2", "Table 3" }, new string[3] { "SP 1", "SP 2", "SP 3" }, new Simulation("Input", "Process", "Output")));
            listSolution.Add(new Solution("BRID 5", "E Interface", "Tutut Ganteng.jpg", FillerText.MediumText, "Client", new string[3] { "Table 1", "Table 2", "Table 3" }, new string[3] { "SP 1", "SP 2", "SP 3" }, new Simulation("Input", "Process", "Output")));
            #endregion

            #region DATA DUMMY ATTACHMENT
            listAttachment.Add(new Attachment("Attachment 1", FillerText.Text, "Tutut Ganteng.jpg"));
            listAttachment.Add(new Attachment("Attachment 2", FillerText.Text, "Tutut Ganteng.jpg"));
            listAttachment.Add(new Attachment("Attachment 3", FillerText.Text, "Tutut Ganteng.jpg"));
            #endregion

            #region DATA DUMMY APPROVAL 2
            listApproval2.Add(new Approval("SA", "Wong Anthony", "System Analyst", "Bandung", DateTime.Now));
            listApproval2.Add(new Approval("BA", "Victor Wijaya", "Business Analyst", "Bandung", DateTime.Now));
            listApproval2.Add(new Approval("PM", "Rachmantyo Saroso", "Project Manager", "Bandung", DateTime.Now));
            listApproval2.Add(new Approval("LOBH", "Alvin Wibowo", "LOB Head", "Bandung", DateTime.Now));
            #endregion

            #region DATA DUMMY REVISION HISTORY 3
            listRevisionHistory3 = listRevisionHistory2;
            #endregion

            #region DATA DUMMY LINK TABLE
            listLinkTable.Add(new LinkTable(listCurrentBFD[0], listSolution[0]));
            listLinkTable.Add(new LinkTable(listCurrentBFD[0], listSolution[1]));
            listLinkTable.Add(new LinkTable(listCurrentBFD[0], listSolution[2]));
            listLinkTable.Add(new LinkTable(listCurrentBFD[0], listSolution[3]));
            listLinkTable.Add(new LinkTable(listCurrentBFD[0], listSolution[4]));
            #endregion

            #region DATA DUMMY POSITIVE SCENARIO
            listPositiveScenario.Add(new Scenario(FillerText.Text, "BRID 1", FillerText.ShortText, FillerText.ShortText, true));
            listPositiveScenario.Add(new Scenario(FillerText.Text, "BRID 2", FillerText.ShortText, FillerText.ShortText, false));
            listPositiveScenario.Add(new Scenario(FillerText.Text, "BRID 3", FillerText.ShortText, FillerText.ShortText, true));
            listPositiveScenario.Add(new Scenario(FillerText.Text, "BRID 4", FillerText.ShortText, FillerText.ShortText, false));
            listPositiveScenario.Add(new Scenario(FillerText.Text, "BRID 5", FillerText.ShortText, FillerText.ShortText, true));
            #endregion

            #region DATA DUMMY NEGATIVE SCENARIO
            listNegativeScenario.Add(new Scenario(FillerText.Text, "BRID 1", FillerText.ShortText, FillerText.ShortText, false));
            listNegativeScenario.Add(new Scenario(FillerText.Text, "BRID 2", FillerText.ShortText, FillerText.ShortText, true));
            listNegativeScenario.Add(new Scenario(FillerText.Text, "BRID 3", FillerText.ShortText, FillerText.ShortText, false));
            listNegativeScenario.Add(new Scenario(FillerText.Text, "BRID 4", FillerText.ShortText, FillerText.ShortText, true));
            listNegativeScenario.Add(new Scenario(FillerText.Text, "BRID 5", FillerText.ShortText, FillerText.ShortText, false));
            #endregion

            #region DATA DUMMY APPROVAL 3
            listApproval3.Add(new Approval("QC", "Wong Anthony", "System Analyst", "Bandung", DateTime.Now));
            listApproval3.Add(new Approval("SA", "Victor Wijaya", "Business Analyst", "Bandung", DateTime.Now));
            listApproval3.Add(new Approval("PM", "Rachmantyo Saroso", "Project Manager", "Bandung", DateTime.Now));
            listApproval3.Add(new Approval("LOBH", "Alvin Wibowo", "LOB Head", "Bandung", DateTime.Now));
            #endregion

            InitializeComponent();

            this.CenterToScreen();
            presenterBRD = new Presenter.PresenterBRDPDF(this);
            presenterFSD = new Presenter.PresenterFSDPDF(this);
            presenterCDS = new Presenter.PresenterCDSPDF(this);
        }

        private void ButtonGenerateBRD_Click(object sender, EventArgs e)
        {
            presenterBRD.GenerateBRD();
        }

        private void ButtonGenerateFSD_Click(object sender, EventArgs e)
        {
            presenterFSD.GenerateFSD();
        }

        private void ButtonGenerateCDS_Click(object sender, EventArgs e)
        {
            presenterCDS.GenerateCDS();
        }
    }
}
