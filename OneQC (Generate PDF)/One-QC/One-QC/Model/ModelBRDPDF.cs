using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace One_QC.Model
{
    class ModelBRDPDF
    {
        const string FontName = "Arial";
        const double PageWidth = 16;
        
        public void GenerateBRD(string strProID, string strProTitle, string strProBRD, string strProSFAT, string strProITRoadMap, DateTime datetimeProDate, string strProBAName, string strProBUName, string strProBUEmail, string strProBUDivision, string strProBUOfficeID, string strProBUCostCenter, List<RevisionHistory> listRevisionHistory, List<Approval> listApproval, List<DistributionList> listDistributionList, List<Glossary> listGlossary, string strProOverview, string strProDependencies, List<Stakeholder> listStakeholder, List<CurrentBFD> listCurrentBFD, List<ProposedBFD> listProposedBFD, List<ProposedReportAvailable> listProposedReportAvailable, List<SecurityRequirement> listSecurityRequirement, List<BackupRequirement> listBackupRequirement, string[] strArrayProUMMenu, string[] strArrayProUMDiv, bool[][] boolMatrixProUM, List<Assumption> listAssumption, List<Appendix> listAppendix)
        {
            Document document = CreateDocument(strProID, strProTitle, strProBRD, strProSFAT, strProITRoadMap, datetimeProDate, strProBAName, strProBUName, strProBUEmail, strProBUDivision, strProBUOfficeID, strProBUCostCenter, listRevisionHistory, listApproval, listDistributionList, listGlossary, strProOverview, strProDependencies, listStakeholder, listCurrentBFD, listProposedBFD, listProposedReportAvailable, listSecurityRequirement, listBackupRequirement, strArrayProUMMenu, strArrayProUMDiv, boolMatrixProUM, listAssumption, listAppendix);
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;
            renderer.RenderDocument();
            string filename = strProID + " - " + strProTitle + ".pdf";
            renderer.PdfDocument.Save(filename);
            Process.Start(filename);
        }

        Document CreateDocument(string strProID, string strProTitle, string strProBRD, string strProSFAT, string strProITRoadMap, DateTime datetimeProDate, string strProBAName, string strProBUName, string strProBUEmail, string strProBUDivision, string strProBUOfficeID, string strProBUCostCenter, List<RevisionHistory> listRevisionHistory, List<Approval> listApproval, List<DistributionList> listDistributionList, List<Glossary> listGlossary, string strProOverview, string strProDependencies, List<Stakeholder> listStakeholder, List<CurrentBFD> listCurrentBFD, List<ProposedBFD> listProposedBFD, List<ProposedReportAvailable> listProposedReportAvailable, List<SecurityRequirement> listSecurityRequirement, List<BackupRequirement> listBackupRequirement, string[] strArrayProUMMenu, string[] strArrayProUMDiv, bool[][] boolMatrixProUM, List<Assumption> listAssumption, List<Appendix> listAppendix)
        {
            Document document = new Document();
            document.Info.Title = strProID;
            document.Info.Subject = strProTitle;
            document.Info.Author = strProBAName;
            
            DefineStyles(document, FontName, Colors.Black, Colors.Black);
            DefineCover(document, FontName, Colors.Black, strProID, strProTitle, strProBRD, strProSFAT, strProITRoadMap, datetimeProDate, strProBAName, strProBUName, strProBUEmail, strProBUDivision, strProBUOfficeID, strProBUCostCenter);
            DefineRevisionHistory(document, FontName, Colors.Black, listRevisionHistory);
            DefineApproval(document, FontName, Colors.Black, listApproval);
            DefineTableOfContent(document, FontName, Colors.Black);
            DefineDistributionList(document, FontName, Colors.Black, listDistributionList);
            DefineGlossary(document, FontName, Colors.Black, listGlossary);
            DefineProjectOverviewAndBackground(document, FontName, Colors.Black, strProOverview, strProDependencies, listStakeholder);
            DefineBusinessProcessFlow(document, FontName, Colors.Black, listCurrentBFD, listProposedBFD, listProposedReportAvailable);
            DefineSecurityAndBackupRequirements(document, FontName, Colors.Black, listSecurityRequirement, listBackupRequirement, strArrayProUMMenu, strArrayProUMDiv, boolMatrixProUM);
            DefineAssumption(document, FontName, Colors.Black, listAssumption);
            DefineAppendix(document, FontName, Colors.Black, listAppendix);

            return document;
        }

        void DefineStyles(Document document, string fontName, Color fontColor, Color borderColor)
        {
            Unit unit = 7;
            string margin = (PageWidth / 2).ToString() + "cm";
            
            Border border = new Border();
            border.Width = 1;
            border.Color = borderColor;
            
            Style style = document.Styles["Normal"];
            style.Font.Name = fontName;
            style.Font.Size = 12;
            style.ParagraphFormat.SpaceBefore = unit;
            style.ParagraphFormat.SpaceAfter = unit;
            
            style = document.Styles["Heading1"];
            style.Font.Name = fontName;
            style.Font.Size = 20;
            style.Font.Bold = true;
            style.Font.Color = fontColor;
            style.ParagraphFormat.PageBreakBefore = true;
            style.ParagraphFormat.SpaceBefore = unit;
            style.ParagraphFormat.SpaceAfter = unit;
            style.ParagraphFormat.Borders.Bottom = border;

            style = document.Styles["Heading2"];
            style.Font.Name = fontName;
            style.Font.Size = 15;
            style.Font.Bold = false;
            style.Font.Color = fontColor;
            style.ParagraphFormat.PageBreakBefore = false;
            style.ParagraphFormat.SpaceBefore = unit;
            style.ParagraphFormat.SpaceAfter = unit;
            style.ParagraphFormat.Borders.Bottom.Visible = false;

            style = document.Styles["Heading3"];
            style.Font.Name = fontName;
            style.Font.Size = 12;
            style.Font.Bold = true;
            style.Font.Color = fontColor;
            style.ParagraphFormat.PageBreakBefore = false;
            style.ParagraphFormat.SpaceBefore = unit;
            style.ParagraphFormat.SpaceAfter = unit;
            style.ParagraphFormat.Borders.Bottom.Visible = false;
            
            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop(margin, TabAlignment.Center);
            
            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop(margin, TabAlignment.Center);

            style = document.Styles.AddStyle("TOC", "Normal");
            style.ParagraphFormat.AddTabStop( PageWidth.ToString() + "cm", TabAlignment.Right, TabLeader.Dots);
            style.ParagraphFormat.Font.Name = fontName;
            style.ParagraphFormat.Font.Color = fontColor;
        }

        void DefineTableOfContent(Document document, string fontName, Color fontColor)
        {
            Section section = document.LastSection;
            
            DocumentFormat.DefineHeading(document, "Table of Content", "Heading1", "Table of Content");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Revision History");
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Distribution List");
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Glossary");
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Project Overview and Background");
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Business Process Flow / Overview");
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Security and Backup Requirements");
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Assumption");
            DocumentFormat.DefineTableOfContentList(section, FontName, fontColor, "Appendix");
        }

        void DefineCover(Document document, string fontName, Color fontColor, string strProID, string strProTitle, string strProBRD, string strProSFAT, string strProITRoadMap, DateTime datetimeProDate, string strProBAName, string strProBUName, string strProBUEmail, string strProBUDivision, string strProBUOfficeID, string strProBUCostCenter)
        {
            Unit imageWidth = "10cm";

            Section section = document.AddSection();

            DocumentFormat.DefineImage(section, "OCBC NISP Cover.png", imageWidth, ShapePosition.Center);
            
            Paragraph paragraph = section.AddParagraph();

            paragraph = section.AddParagraph("Business Requirements for " + strProTitle);
            paragraph.Format.Font.Size = 25;
            paragraph.Format.Font.Color = fontColor;
            paragraph.Format.Font.Bold = true;
            paragraph.Format.SpaceBefore = "5cm";
            paragraph.Format.SpaceAfter = "5cm";
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            string strProITRoadMapTemp = "Yes\tNo.\t: " + strProITRoadMap;
            if (strProITRoadMap.Equals("") || strProITRoadMap.Equals("-1"))
            {
                strProITRoadMapTemp = "No";
            }
            string coverContent =
                "Prepared By\t\t: " + strProBAName + "\n" +
                "Date\t\t\t: " + datetimeProDate.Date.ToLongDateString() + "\n" +
                "BRD #\t\t\t: " + strProBRD + "\n" +
                "SFAT #\t\t: " + strProSFAT + "\n" +
                "Project ID\t\t: " + strProID + "\n" +
                "IT Road Map\t\t:" + strProITRoadMapTemp +
                "\n\n\n\n\n" +
                "Project Owner\n" +
                "Name\t\t\t: " + strProBUName + "\n" +
                "Email\t\t\t: " + strProBUEmail + "\n" +
                "Division\t\t: " + strProBUDivision + "\n" +
                "Office ID\t\t: " + strProBUOfficeID + "\n" +
                "Cost Center\t\t: " + strProBUCostCenter;
            paragraph = section.AddParagraph(coverContent);
            paragraph.Format.Font.Size = 12;
            paragraph.Format.Font.Color = fontColor;
            paragraph.Format.Font.Bold = false;
            paragraph.Format.SpaceBefore = "7cm";
            paragraph.Format.SpaceAfter = "7cm";
            paragraph.Format.Alignment = ParagraphAlignment.Left;
        }
        
        void DefineRevisionHistory(Document document, string fontName, Color fontColor, List<RevisionHistory> listRevisionHistory)
        {
            Section section = document.AddSection();
            section.PageSetup.OddAndEvenPagesHeaderFooter = true;
            section.PageSetup.StartingNumber = 1;

            Paragraph paragraph = new Paragraph();
            paragraph.AddTab();
            paragraph.AddPageField();

            section.Headers.Primary.Add(paragraph);
            section.Headers.EvenPage.Add(paragraph.Clone());

            DocumentFormat.DefineHeading(document, "Revision History", "Heading1", "Revision History");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            string[] strArrayHeader = new string[4] { "Version", "Author", "Issue Date", "Changes" };
            string[] strArrayHeaderSize = new string[4] { (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListRevisionHistory(listRevisionHistory), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            
            document.LastSection.Add(table);
        }
        
        void DefineApproval(Document document, string fontName, Color fontColor, List<Approval> listApproval)
        {
            DocumentFormat.DefineHeading(document, "Approval", "Heading1", "Approval");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            Table table;
            string strSize1 = PageWidth.ToString() + "cm";
            string strSize2 = (PageWidth / 3 * 2).ToString() + "cm";
            string strSize3 = (PageWidth / 3).ToString() + "cm";
            string strSignature = "\n\n\n\n\n";
            string strTitle = "Title\t: ";
            string strName = "Name\t: ";
            string strDate = "Date\t: ";
            string[] strArrayHeader;
            string[] strArrayHeaderSize;
            Approval[][] approvalMatrix = DataStaging.GetApprovalMatrixFromListApproval(listApproval);

            strArrayHeader = new string[1] { "Agreed" };
            strArrayHeaderSize = new string[1] { strSize1 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.LightGray, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { "Business Analyst", "Project Manager", "LOB Head" };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strSignature, strSignature, strSignature };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strTitle + approvalMatrix[0][0].StrTitle , strTitle + approvalMatrix[1][0].StrTitle, strTitle + approvalMatrix[2][0].StrTitle };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strName + approvalMatrix[0][0].StrName, strName + approvalMatrix[1][0].StrName, strName + approvalMatrix[2][0].StrName };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strDate + approvalMatrix[0][0].DatetimeApprove.Date.ToShortDateString(), strDate + approvalMatrix[1][0].DatetimeApprove.Date.ToShortDateString(), strDate + approvalMatrix[2][0].DatetimeApprove.Date.ToShortDateString() };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            strArrayHeader = new string[1] { "Business User" };
            strArrayHeaderSize = new string[1] { strSize2 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[2] { strSignature, strSignature };
            strArrayHeaderSize = new string[2] { strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[2] { strTitle + approvalMatrix[3][0].StrTitle, strTitle + approvalMatrix[3][1].StrTitle };
            strArrayHeaderSize = new string[2] { strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[2] { strName + approvalMatrix[3][0].StrName, strName + approvalMatrix[3][1].StrName };
            strArrayHeaderSize = new string[2] { strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[2] { strDate + approvalMatrix[3][0].DatetimeApprove.Date.ToShortDateString(), strDate + approvalMatrix[3][1].DatetimeApprove.Date.ToShortDateString() };
            strArrayHeaderSize = new string[2] { strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            document.LastSection.AddPageBreak();

            strArrayHeader = new string[2] { "Business User Head", "Business User Division" };
            strArrayHeaderSize = new string[2] { strSize2, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strSignature, strSignature, strSignature };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strTitle + approvalMatrix[4][0].StrTitle, strTitle + approvalMatrix[4][1].StrTitle, strTitle + approvalMatrix[5][0].StrTitle };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strName + approvalMatrix[4][0].StrName, strName + approvalMatrix[4][1].StrName, strName + approvalMatrix[5][0].StrName };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strDate + approvalMatrix[4][0].DatetimeApprove.Date.ToShortDateString(), strDate + approvalMatrix[4][1].DatetimeApprove.Date.ToShortDateString(), strDate + approvalMatrix[5][0].DatetimeApprove.Date.ToShortDateString() };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            strArrayHeader = new string[1] { "Acknowledged By" };
            strArrayHeaderSize = new string[1] { strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.LightGray, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[1] { "ITRM / ORM *" };
            strArrayHeaderSize = new string[1] { strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[1] { strSignature };
            strArrayHeaderSize = new string[1] { strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[1] { strTitle + approvalMatrix[6][0].StrTitle };
            strArrayHeaderSize = new string[1] { strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[1] { strName + approvalMatrix[6][0].StrName };
            strArrayHeaderSize = new string[1] { strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[1] { strDate + approvalMatrix[6][0].DatetimeApprove.Date.ToShortDateString() };
            strArrayHeaderSize = new string[1] { strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            DocumentFormat.DefineParagraph(document, "* This approval is needed if one of the answer of Point F – IT Risk Management from Questionaire Assesment documents filled with “Y”.", ParagraphAlignment.Justify, 8);
            
            document.LastSection.AddPageBreak();

            strArrayHeader = new string[1] { "Agreed" };
            strArrayHeaderSize = new string[1] { strSize1 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.LightGray, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[1] { "Stakeholders" };
            strArrayHeaderSize = new string[1] { strSize1 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strSignature, strSignature, strSignature };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strTitle + approvalMatrix[7][0].StrTitle, strTitle + approvalMatrix[7][1].StrTitle, strTitle + approvalMatrix[7][2].StrTitle };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strName + approvalMatrix[7][0].StrName, strName + approvalMatrix[7][1].StrName, strName + approvalMatrix[7][2].StrName };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            strArrayHeader = new string[3] { strDate + approvalMatrix[7][0].DatetimeApprove.Date.ToShortDateString(), strDate + approvalMatrix[7][1].DatetimeApprove.Date.ToShortDateString(), strDate + approvalMatrix[7][2].DatetimeApprove.Date.ToShortDateString() };
            strArrayHeaderSize = new string[3] { strSize3, strSize3, strSize3 };
            table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, Colors.Black, Colors.White, 12, ParagraphAlignment.Left, 0.5, 0.5, false);
            document.LastSection.Add(table);

            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
        }

        void DefineDistributionList(Document document, string fontName, Color fontColor, List<DistributionList> listDistributionList)
        {
            DocumentFormat.DefineHeading(document, "Distribution List", "Heading1", "Distribution List");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            string[] strArrayHeader = new string[3] { "Name", "Title", "Business Unit" };
            string[] strArrayHeaderSize = new string[3] { (PageWidth / 3).ToString() + "cm", (PageWidth / 3).ToString() + "cm", (PageWidth / 3).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListDistributionList(listDistributionList), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            
            document.LastSection.Add(table);
        }

        void DefineGlossary(Document document, string fontName, Color fontColor, List<Glossary> listGlossary)
        {
            DocumentFormat.DefineHeading(document, "Glossary", "Heading1", "Glossary");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            string[] strArrayHeader = new string[2] { "Term / Acronym", "Definition" };
            string[] strArrayHeaderSize = new string[2] { (PageWidth / 3).ToString() + "cm", (PageWidth / 3 * 2).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListGlossary(listGlossary), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            
            document.LastSection.Add(table);
        }

        void DefineProjectOverviewAndBackground(Document document, string fontName, Color fontColor, string strProOverview, string strProDependencies, List<Stakeholder> listStakeholder)
        {
            DocumentFormat.DefineHeading(document, "Project Overview and Background", "Heading1", "Project Overview and Background");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            DocumentFormat.DefineHeading(document, "Project Overview and Background", "Heading2", "Project Overview and Background");
            DocumentFormat.DefineParagraph(document, strProOverview, ParagraphAlignment.Justify);
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            DocumentFormat.DefineHeading(document, "Project Dependencies", "Heading2", "Project Dependencies");
            DocumentFormat.DefineParagraph(document, strProDependencies, ParagraphAlignment.Justify);
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);
            
            DocumentFormat.DefineHeading(document, "Stakeholders", "Heading2", "Stakeholders");
            string[] strArrayHeader = new string[3] { "No.", "Stakeholders", "Implications" };
            string[] strArrayHeaderSize = new string[3] { (PageWidth / 9).ToString() + "cm", (PageWidth / 9 * 4).ToString() + "cm", (PageWidth / 9 * 4).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListStakeholder(listStakeholder), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
        }

        void DefineBusinessProcessFlow(Document document, string fontName, Color fontColor, List<CurrentBFD> listCurrentBFD, List<ProposedBFD> listProposedBFD, List<ProposedReportAvailable> listProposedReportAvailable)
        {
            Section section = document.LastSection;

            DocumentFormat.DefineHeading(document, "Business Process Flow / Overview", "Heading1", "Business Process Flow / Overview");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Current Business Flow Diagram", "Heading2", "Current Business Flow Diagram");
            for (int i = 0; i < listCurrentBFD.Count; i++)
            {
                DocumentFormat.DefineHeading(document, listCurrentBFD[i].StrTitle, "Heading3", listCurrentBFD[i].StrTitle);
                DocumentFormat.DefineParagraph(document, listCurrentBFD[i].StrContent, ParagraphAlignment.Justify);
                if (!listCurrentBFD[i].StrPicturePath.Equals("")) DocumentFormat.DefineImage(section, listCurrentBFD[i].StrPicturePath, PageWidth.ToString() + "cm", ShapePosition.Center);
                section.AddPageBreak();
            }
            
            DocumentFormat.DefineHeading(document, "Proposed Business Flow Diagram", "Heading2", "Proposed Business Flow Diagram");
            string[] strArrayHeader = new string[4] { "BRID", "Business Requirement Description", "Responsible Business Unit", "Version" };
            string[] strArrayHeaderSize = new string[4] { (PageWidth / 12 * 2).ToString() + "cm", (PageWidth / 12 * 5).ToString() + "cm", (PageWidth / 12 * 3).ToString() + "cm", (PageWidth / 12 * 2).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListProposedBFD(listProposedBFD), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
            section.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Proposed Report Available", "Heading2", "Proposed Report Available");
            strArrayHeader = new string[7] { "No.", "Report Title", "Report Type (Batch / Adhoc)", "Filter Type", "Information / Field Required", "Source of Field", "Remarks" };
            strArrayHeaderSize = new string[7] { (PageWidth / 18).ToString() + "cm", (PageWidth / 18 * 3).ToString() + "cm", (PageWidth / 18 * 2).ToString() + "cm", (PageWidth / 18 * 4).ToString() + "cm", (PageWidth / 18 * 4).ToString() + "cm", (PageWidth / 18 * 2).ToString() + "cm", (PageWidth / 18 * 2).ToString() + "cm" };
            table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListProposedReportAvailable(listProposedReportAvailable), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
        }

        void DefineSecurityAndBackupRequirements(Document document, string fontName, Color fontColor, List<SecurityRequirement> listSecurityRequirement, List<BackupRequirement> listBackupRequirement, string[] strArrayProUMMenu, string[] strArrayProUMDiv, bool[][] boolMatrixProUM)
        {
            DocumentFormat.DefineHeading(document, "Security and Backup Requirements", "Heading1", "Security and Backup Requirements");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Security Requirements", "Heading2", "Security Requirements");
            string[] strArrayHeader = new string[3] { "BRID", "Security Requirements", "Apply to Business Requirement ID" };
            string[] strArrayHeaderSize = new string[3] { (PageWidth / 8 * 2).ToString() + "cm", (PageWidth / 8 * 3).ToString() + "cm", (PageWidth / 8 * 3).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListSecurityRequirement(listSecurityRequirement), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "User Matrix", "Heading2", "User Matrix");
            string strHeaderSize = (PageWidth / (strArrayProUMDiv.GetLength(0) + 1)).ToString() + "cm";
            strArrayHeaderSize = new string[strArrayProUMDiv.GetLength(0)];
            for (int i = 0; i < strArrayHeaderSize.GetLength(0); i++)
            {
                strArrayHeaderSize[i] = strHeaderSize;
            }
            table = DocumentFormat.CreateSimpleMatrix(strArrayProUMDiv, strArrayProUMMenu, strHeaderSize, strArrayHeaderSize, DataStaging.GetStrMatrixFromBoolMatrixUM(boolMatrixProUM), FontName, fontColor, Colors.LightGray, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Backup and Recovery Needs", "Heading2", "Backup and Recovery Needs");
            strArrayHeader = new string[5] { "No.", "Data", "Frequency", "Type of Backup", "Storage" };
            strArrayHeaderSize = new string[5] { (PageWidth / 10).ToString() + "cm", (PageWidth / 10 * 3).ToString() + "cm", (PageWidth / 10 * 2).ToString() + "cm", (PageWidth / 10 * 2).ToString() + "cm", (PageWidth / 10 * 2).ToString() + "cm" };
            table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListBackupRequirements(listBackupRequirement), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
        }

        void DefineAssumption(Document document, string fontName, Color fontColor, List<Assumption> listAssumption)
        {
            DocumentFormat.DefineHeading(document, "Assumption", "Heading1", "Assumption");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            string[] strArrayHeader = new string[2] { "No.", "Assumption" };
            string[] strArrayHeaderSize = new string[2] { (PageWidth / 5).ToString() + "cm", (PageWidth / 5 * 4).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListAssumption(listAssumption), FontName, Colors.Black, Colors.LightGray, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
        }

        void DefineAppendix(Document document, string fontName, Color fontColor,List<Appendix> listAppendix)
        {
            Section section = document.LastSection;

            DocumentFormat.DefineHeading(document, "Appendix", "Heading1", "Appendix");
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            for (int i = 0; i < listAppendix.Count; i++)
            {
                if (!listAppendix[i].StrPicturePath.Equals("")) DocumentFormat.DefineImage(section, listAppendix[i].StrPicturePath, PageWidth.ToString() + "cm", ShapePosition.Center);
                DocumentFormat.DefineParagraph(document, listAppendix[i].StrText, ParagraphAlignment.Justify);
            }
        }
    }
}
