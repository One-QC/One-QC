using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC
{
    static class DataStaging
    {
        public static string GetStrFromStrArray(string[] strArray)
        {
            string str = "";
            for (int i = 0; i < strArray.Length; i++)
            {
                str += strArray[i];
                if (i < strArray.Length - 1) str += ", ";
            }
            return str;
        }

        public static string[][] GetStrMatrixFromListRevisionHistory(List<RevisionHistory> listRevisionHistory)
        {
            string[][] strMatrixContent = new string[listRevisionHistory.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[4];
                strArrayTemp[0] = listRevisionHistory[i].StrVersion;
                strArrayTemp[1] = listRevisionHistory[i].StrAuthor;
                strArrayTemp[2] = listRevisionHistory[i].DatetimeIssueDate.Date.ToLongDateString();
                strArrayTemp[3] = listRevisionHistory[i].StrChanges;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListDistributionList(List<DistributionList> listDistributionList)
        {
            string[][] strMatrixContent = new string[listDistributionList.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[3];
                strArrayTemp[0] = listDistributionList[i].StrName;
                strArrayTemp[1] = listDistributionList[i].StrTitle;
                strArrayTemp[2] = listDistributionList[i].StrBusinessUnit;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListGlossary(List<Glossary> listGlossary)
        {
            string[][] strMatrixContent = new string[listGlossary.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[2];
                strArrayTemp[0] = listGlossary[i].StrTerm;
                strArrayTemp[1] = listGlossary[i].StrDefinition;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListStakeholder(List<Stakeholder> listStakeholder)
        {
            string[][] strMatrixContent = new string[listStakeholder.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[3];
                strArrayTemp[0] = listStakeholder[i].No.ToString();
                strArrayTemp[1] = listStakeholder[i].StrStakeholder;
                strArrayTemp[2] = listStakeholder[i].StrImplication;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListProposedBFD(List<ProposedBFD> listProposedBFD)
        {
            string[][] strMatrixContent = new string[listProposedBFD.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[4];
                strArrayTemp[0] = listProposedBFD[i].StrBRID;
                strArrayTemp[1] = listProposedBFD[i].StrBRDesc;
                strArrayTemp[2] = listProposedBFD[i].StrResponsibleBU;
                strArrayTemp[3] = listProposedBFD[i].StrVersion;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListProposedReportAvailable(List<ProposedReportAvailable> listProposedReportAvailable)
        {
            string[][] strMatrixContent = new string[listProposedReportAvailable.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[7];
                strArrayTemp[0] = listProposedReportAvailable[i].No.ToString();
                strArrayTemp[1] = listProposedReportAvailable[i].StrReportTitle;
                strArrayTemp[2] = listProposedReportAvailable[i].StrReportType;
                strArrayTemp[3] = listProposedReportAvailable[i].StrFilterType;
                strArrayTemp[4] = listProposedReportAvailable[i].StrFieldRequired;
                strArrayTemp[5] = listProposedReportAvailable[i].StrFieldSource;
                strArrayTemp[6] = listProposedReportAvailable[i].StrRemarks;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListSecurityRequirement(List<SecurityRequirement> listSecurityRequirement)
        {
            string[][] strMatrixContent = new string[listSecurityRequirement.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[3];
                strArrayTemp[0] = listSecurityRequirement[i].StrBRID;
                strArrayTemp[1] = listSecurityRequirement[i].StrSecurityRequirement;
                strArrayTemp[2] = listSecurityRequirement[i].StrApplyBRID;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListBackupRequirements(List<BackupRequirement> listBackupRequirement)
        {
            string[][] strMatrixContent = new string[listBackupRequirement.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[5];
                strArrayTemp[0] = listBackupRequirement[i].No.ToString();
                strArrayTemp[1] = listBackupRequirement[i].StrData;
                strArrayTemp[2] = listBackupRequirement[i].StrFrequency;
                strArrayTemp[3] = listBackupRequirement[i].StrBackupType;
                strArrayTemp[4] = listBackupRequirement[i].StrStorage;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromBoolMatrixUM(bool[][] boolMatrixProUM)
        {
            string[][] strMatrixContent = new string[boolMatrixProUM.GetLength(0)][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[boolMatrixProUM[i].GetLength(0)];
                for (int j = 0; j < strArrayTemp.GetLength(0); j++)
                {
                    if (boolMatrixProUM[i][j]) strArrayTemp[j] = "O";
                    else strArrayTemp[j] = "X";
                }
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListAssumption(List<Assumption> listAssumption)
        {
            string[][] strMatrixContent = new string[listAssumption.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[2];
                strArrayTemp[0] = listAssumption[i].No.ToString();
                strArrayTemp[1] = listAssumption[i].StrAssumption;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static string[][] GetStrMatrixFromListScenario(List<Scenario> listScenario)
        {
            string[][] strMatrixContent = new string[listScenario.Count][];
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                string[] strArrayTemp = new string[7];
                strArrayTemp[0] = (i + 1).ToString();
                strArrayTemp[1] = listScenario[i].StrScenario;
                strArrayTemp[2] = listScenario[i].StrBRID;
                strArrayTemp[3] = listScenario[i].StrExpectedResult;
                if (listScenario[i].IsOK)
                {
                    strArrayTemp[4] = "O";
                    strArrayTemp[5] = "X";
                }
                else
                {
                    strArrayTemp[4] = "X";
                    strArrayTemp[5] = "O";
                }
                strArrayTemp[6] = listScenario[i].StrDescription;
                strMatrixContent[i] = strArrayTemp;
            }
            return strMatrixContent;
        }

        public static Approval[][] GetApprovalMatrixFromListApproval(List<Approval> listApproval)
        {
            Approval[][] approvalMatrix = new Approval[8][];
            Approval[] approvalArrayBA = new Approval[1];   // Business Analyst
            Approval[] approvalArrayPM = new Approval[1];   // Project Manager
            Approval[] approvalArrayLOBH = new Approval[1]; // LOB Head
            Approval[] approvalArrayBU = new Approval[2];   // Business User
            Approval[] approvalArrayBUH = new Approval[2];  // Business User Head
            Approval[] approvalArrayBUDH = new Approval[1]; // Business User Division Head
            Approval[] approvalArrayITRM = new Approval[1]; // ITRM
            Approval[] approvalArrayS = new Approval[3];    // Stakeholder
            int indexBU = 0;
            int indexBUH = 0;
            int indexS = 0;
            for (int i = 0; i < listApproval.Count; i++)
            {
                switch (listApproval[i].StrRole)
                {
                    case "BA":
                        approvalArrayBA[0] = listApproval[i];
                        break;
                    case "PM":
                        approvalArrayPM[0] = listApproval[i];
                        break;
                    case "LOBH":
                        approvalArrayLOBH[0] = listApproval[i];
                        break;
                    case "BU":
                        approvalArrayBU[indexBU] = listApproval[i];
                        indexBU++;
                        break;
                    case "BUH":
                        approvalArrayBUH[indexBUH] = listApproval[i];
                        indexBUH++;
                        break;
                    case "BUDH":
                        approvalArrayBUDH[0] = listApproval[i];
                        break;
                    case "ITRM":
                        approvalArrayITRM[0] = listApproval[i];
                        break;
                    case "S":
                        approvalArrayS[indexS] = listApproval[i];
                        indexS++;
                        break;
                }
            }
            approvalMatrix[0] = approvalArrayBA;
            approvalMatrix[1] = approvalArrayPM;
            approvalMatrix[2] = approvalArrayLOBH;
            approvalMatrix[3] = approvalArrayBU;
            approvalMatrix[4] = approvalArrayBUH;
            approvalMatrix[5] = approvalArrayBUDH;
            approvalMatrix[6] = approvalArrayITRM;
            approvalMatrix[7] = approvalArrayS;
            return approvalMatrix;
        }

        public static Approval[] GetApprovalArrayFromListApproval(List<Approval> listApproval)
        {
            Approval[] approvalArray = new Approval[4];
            for (int i = 0; i < listApproval.Count; i++)
            {
                switch (listApproval[i].StrRole)
                {
                    case "SA":
                        approvalArray[0] = listApproval[i];
                        break;
                    case "BA":
                        approvalArray[1] = listApproval[i];
                        break;
                    case "PM":
                        approvalArray[2] = listApproval[i];
                        break;
                    case "LOBH":
                        approvalArray[3] = listApproval[i];
                        break;
                }
            }
            return approvalArray;
        }

        public static Approval[] GetApprovalArrayFromListApproval2(List<Approval> listApproval)
        {
            Approval[] approvalArray = new Approval[4];
            for (int i = 0; i < listApproval.Count; i++)
            {
                switch (listApproval[i].StrRole)
                {
                    case "QC":
                        approvalArray[0] = listApproval[i];
                        break;
                    case "SA":
                        approvalArray[1] = listApproval[i];
                        break;
                    case "PM":
                        approvalArray[2] = listApproval[i];
                        break;
                    case "LOBH":
                        approvalArray[3] = listApproval[i];
                        break;
                }
            }
            return approvalArray;
        }
    }
}
