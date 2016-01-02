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
    class ModelCDSPDF
    {
        const string FontName = "Arial";
        const double PageWidth = 27.7;

        public void GenerateCDS(string strProID , string strProTitle, string strProCDS, string strProType, string strProModule, DateTime datetimeProDate, List<RevisionHistory> listRevisionHistory, string strProObjective, string strProAppName, string[] strArrayProDatabase, string[] strArrayProMiddleware, List<LinkTable> listLinkTable, string[] strArrayProPicturePathDatabaseDiagram, string[] strArrayProPicturePathTopology, List<Scenario> listPositiveScenario, List<Scenario> listNegativeScenario, string strProOtherInfo, List<Approval> listApproval)
        {
            Document document = CreateDocument(strProID, strProTitle, strProCDS, strProType, strProModule, datetimeProDate, listRevisionHistory, strProObjective, strProAppName, strArrayProDatabase, strArrayProMiddleware, listLinkTable, strArrayProPicturePathDatabaseDiagram, strArrayProPicturePathTopology, listPositiveScenario, listNegativeScenario, strProOtherInfo, listApproval);
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;
            renderer.RenderDocument();
            string filename = strProID + " - " + strProTitle + ".pdf";
            renderer.PdfDocument.Save(filename);
            Process.Start(filename);
        }

        Document CreateDocument(string strProID, string strProTitle, string strProCDS, string strProType, string strProModule, DateTime datetimeProDate, List<RevisionHistory> listRevisionHistory, string strProObjective, string strProAppName, string[] strArrayProDatabase, string[] strArrayProMiddleware, List<LinkTable> listLinkTable, string[] strArrayProPicturePathDatabaseDiagram, string[] strArrayProPicturePathTopology, List<Scenario> listPositiveScenario, List<Scenario> listNegativeScenario, string strProOtherInfo, List<Approval> listApproval)
        {
            Document document = new Document();

            DefineStyles(document, FontName, Colors.Black, Colors.White, Colors.Black);
            DefineTitle(document, strProID, strProTitle, strProCDS, strProType, strProModule, datetimeProDate);
            DefineDocumentChangeControl(document, FontName, Colors.Black, listRevisionHistory);
            DefineObjectives(document, strProObjective);
            DefineScope(document, strProAppName, strArrayProDatabase, strArrayProMiddleware);
            DefineFlowChart(document, FontName, Colors.Black, listLinkTable);
            DefineDatabaseDiagram(document, strArrayProPicturePathDatabaseDiagram);
            DefineTopology(document, strArrayProPicturePathTopology);
            DefineScenario(document, FontName, Colors.Black, listPositiveScenario, listNegativeScenario);
            DefineOthersInformation(document, strProOtherInfo);
            DefineApproval(document, FontName, Colors.Black, listApproval);

            return document;
        }

        void DefineStyles(Document document, string fontName, Color fontColor, Color fontColor2, Color borderColor)
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
            style.ParagraphFormat.PageBreakBefore = false;
            style.ParagraphFormat.SpaceBefore = unit;
            style.ParagraphFormat.SpaceAfter = unit;
            style.ParagraphFormat.Borders.Bottom = border;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Right;

            style = document.Styles["Heading2"];
            style.Font.Name = fontName;
            style.Font.Size = 15;
            style.Font.Bold = true;
            style.Font.Color = fontColor2;
            style.ParagraphFormat.PageBreakBefore = false;
            style.ParagraphFormat.SpaceBefore = unit;
            style.ParagraphFormat.SpaceAfter = unit;
            style.ParagraphFormat.Borders.Bottom.Visible = false;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Left;
            style.ParagraphFormat.Shading.Color = fontColor;

            style = document.Styles["Heading3"];
            style.Font.Name = fontName;
            style.Font.Size = 12;
            style.Font.Bold = true;
            style.Font.Color = fontColor;
            style.ParagraphFormat.PageBreakBefore = false;
            style.ParagraphFormat.SpaceBefore = unit;
            style.ParagraphFormat.SpaceAfter = unit;
            style.ParagraphFormat.Borders.Bottom.Visible = false;
            style.ParagraphFormat.Shading.Color = Colors.Transparent;

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop(margin, TabAlignment.Center);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop(margin, TabAlignment.Center);

            style = document.Styles.AddStyle("TOC", "Normal");
            style.ParagraphFormat.AddTabStop(PageWidth.ToString() + "cm", TabAlignment.Right, TabLeader.Dots);
            style.ParagraphFormat.Font.Name = fontName;
            style.ParagraphFormat.Font.Color = fontColor;
        }

        void DefineTitle(Document document, string strProID, string strProTitle, string strProCDS, string strProType, string strProModule, DateTime datetimeProDate)
        {
            Unit imageWidth = "5cm";
            Unit pageMargin = "1cm";

            Section section = document.AddSection();
            section.PageSetup.LeftMargin = pageMargin;
            section.PageSetup.RightMargin = pageMargin;
            section.PageSetup.TopMargin = pageMargin;
            section.PageSetup.BottomMargin = pageMargin;
            section.PageSetup.Orientation = Orientation.Landscape;

            DocumentFormat.DefineImage(section, "OCBC NISP Cover.png", imageWidth, ShapePosition.Left, WrapStyle.Through);
            DocumentFormat.DefineHeading(document, "Compliance Design Specification", "Heading1", "Compliance Design Specification");

            string titleContent =
                "Title of Compliance Design Specification\t\t:\t" + strProTitle + "\n" +
                "CDS Number\t\t\t\t\t\t:\t" + strProCDS + "\n" +
                "Project ID\t\t\t\t\t\t\t:\t" + strProID + "\n" +
                "Security / Network / Infrastructure / Application\t:\t" + strProType + "\n" +
                "Module\t\t\t\t\t\t\t:\t" + strProModule + "\n" +
                "Date\t\t\t\t\t\t\t\t:\t" + datetimeProDate.ToLongDateString();
            Paragraph paragraph = section.AddParagraph(titleContent);
            paragraph.Format.Font.Bold = true;
        }

        void DefineDocumentChangeControl(Document document, string fontName, Color fontColor, List<RevisionHistory> listRevisionHistory)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Document Change Control", "Heading2", "Document Change Control");

            string[] strArrayHeader = new string[4] { "Document Version", "Name", "Date", "Summary of Changes" };
            string[] strArrayHeaderSize = new string[4] { (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm" };
            Table table = DocumentFormat.CreateSimpleTable(strArrayHeader, strArrayHeaderSize, DataStaging.GetStrMatrixFromListRevisionHistory(listRevisionHistory), fontName, fontColor, Colors.White, 12, 0.5, 0.5, true);

            document.LastSection.Add(table);
        }

        void DefineObjectives(Document document, string strProObjective)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Objectives", "Heading2", "Objectives");

            DocumentFormat.DefineParagraph(document, strProObjective, ParagraphAlignment.Justify);
        }

        void DefineScope(Document document, string strProAppName, string[] strArrayProDatabase, string[] strArrayProMiddleware)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Scope", "Heading2", "Scope");

            string scopeContent =
                "Nama Aplikasi\t: " + strProAppName + "\n" +
                "Database\t\t: " + DataStaging.GetStrFromStrArray(strArrayProDatabase) + "\n" +
                "Middleware\t\t: " + DataStaging.GetStrFromStrArray(strArrayProMiddleware);
            DocumentFormat.DefineParagraph(document, scopeContent, ParagraphAlignment.Left);
        }
        
        void DefineFlowChart(Document document, string fontName, Color fontColor, List<LinkTable> listLinkTable)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Flow Chart (Database / Link Table)", "Heading2", "Flow Chart (Database / Link Table)");

            string[] strArrayHeaderSize = new string[2] { (PageWidth / 2).ToString() + "cm", (PageWidth / 2).ToString() + "cm" };
            string[] strArrayHeader = new string[2] { "BRD", "FSD" };
            string[][] strMatrixContent = new string[listLinkTable.Count * 4][];
            int[][] matrixMergeDown = new int[listLinkTable.Count * 4][];
            bool[][] isBottomBorderVisible = new bool[listLinkTable.Count * 4][];
            for (int i = 0; i < listLinkTable.Count * 4; i++)
            {
                if (i % 4 == 0)
                {
                    strMatrixContent[i] = new string[2] { "BRD " + listLinkTable[i / 4].Solution.StrBRID, "FSD " + listLinkTable[i / 4].Solution.StrBRID };
                    matrixMergeDown[i] = new int[2];
                    matrixMergeDown[i][0] = 0;
                    matrixMergeDown[i][1] = 0;
                    isBottomBorderVisible[i] = new bool[2];
                    isBottomBorderVisible[i][0] = false;
                    isBottomBorderVisible[i][1] = false;
                }
                else if (i % 4 == 1)
                {
                    string strContent =
                        "a.\tHandles BR ID\t\t\t: " + listLinkTable[i / 4].Solution.StrBRID + "\n" +
                        "b.\tFlow\t\t\t\t\t: " + listLinkTable[i / 4].Solution.StrFlowText + "\n" +
                        "c.\tTable Reference\t\t\t: " + DataStaging.GetStrFromStrArray(listLinkTable[i / 4].Solution.StrArrayTableReference) + "\n" +
                        "d.\tStore Procedure Reference\t: " + DataStaging.GetStrFromStrArray(listLinkTable[i / 4].Solution.StrArrayStoreProcedureReference) + "\n" +
                        "e.\tClient\t\t\t\t\t: " + listLinkTable[i / 4].Solution.StrClient;
                    if (listLinkTable[i / 4].CurrentBFD.StrPicturePath.Equals(""))
                    {
                        strMatrixContent[i] = new string[2] { listLinkTable[i / 4].CurrentBFD.StrTitle, strContent };
                        matrixMergeDown[i] = new int[2];
                        matrixMergeDown[i][0] = 0;
                        matrixMergeDown[i][1] = 1;
                        isBottomBorderVisible[i] = new bool[2];
                        isBottomBorderVisible[i][0] = false;
                        isBottomBorderVisible[i][1] = true;
                    }
                    else
                    {
                        strMatrixContent[i] = new string[2] { listLinkTable[i / 4].CurrentBFD.StrTitle, strContent };
                        matrixMergeDown[i] = new int[2];
                        matrixMergeDown[i][0] = 0;
                        matrixMergeDown[i][1] = 2;
                        isBottomBorderVisible[i] = new bool[2];
                        isBottomBorderVisible[i][0] = false;
                        isBottomBorderVisible[i][1] = true;
                    }
                }
                else if (i % 4 == 2)
                {
                    strMatrixContent[i] = new string[2] { listLinkTable[i / 4].CurrentBFD.StrPicturePath, "" };
                    matrixMergeDown[i] = new int[2];
                    matrixMergeDown[i][0] = 0;
                    matrixMergeDown[i][1] = 0;
                    isBottomBorderVisible[i] = new bool[2];
                    isBottomBorderVisible[i][0] = false;
                    isBottomBorderVisible[i][1] = true;
                }
                else
                {
                    strMatrixContent[i] = new string[2] { listLinkTable[i / 4].CurrentBFD.StrContent, "" };
                    matrixMergeDown[i] = new int[2];
                    matrixMergeDown[i][0] = 0;
                    matrixMergeDown[i][1] = 0;
                    isBottomBorderVisible[i] = new bool[2];
                    isBottomBorderVisible[i][0] = true;
                    isBottomBorderVisible[i][1] = true;
                }
            }
            Table table = DocumentFormat.CreateMergedDownTable(strArrayHeader, strArrayHeaderSize, strMatrixContent, matrixMergeDown, isBottomBorderVisible, FontName, Colors.Black, Colors.White, 12, 0.5, 0.5, true, (PageWidth / 2 * 0.95).ToString() + "cm");
            document.LastSection.Add(table);
        }

        void DefineDatabaseDiagram(Document document, string[] strArrayProPicturePathDatabaseDiagram)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Database Diagram", "Heading2", "Database Diagram");

            for (int i = 0; i < strArrayProPicturePathDatabaseDiagram.Length; i++)
            {
                DocumentFormat.DefineImage(document.LastSection, strArrayProPicturePathDatabaseDiagram[i], PageWidth.ToString() + "cm", ShapePosition.Center);
                if (i < strArrayProPicturePathDatabaseDiagram.Length - 1) document.LastSection.AddPageBreak();
            }
        }

        void DefineTopology(Document document, string[] strArrayProPicturePathTopology)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Topology / Network / Connection", "Heading2", "Topology / Network / Connection");

            for (int i = 0; i < strArrayProPicturePathTopology.Length; i++)
            {
                DocumentFormat.DefineImage(document.LastSection, strArrayProPicturePathTopology[i], PageWidth.ToString() + "cm", ShapePosition.Center);
                if (i < strArrayProPicturePathTopology.Length - 1) document.LastSection.AddPageBreak();
            }
        }

        void DefineScenario(Document document, string fontName, Color fontColor, List<Scenario> listPositiveScenario, List<Scenario> listNegativeScenario)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Test Scenario", "Heading2", "Test Scenario");

            DocumentFormat.DefineHeading(document, "Positive Scenario and Result", "Heading3", "Positive Scenario and Result");

            string[][] strArrayHeader = new string[2][];
            strArrayHeader[0] = new string[7] { "No", "Scenario", "BR ID Number", "Expected Result (Mandatory)", "Result", "", "Description" };
            strArrayHeader[1] = new string[7] { "", "", "", "", "OK", "Not OK", "" };
            string[] strArrayHeaderSize = new string[7] { (PageWidth / 15).ToString() + "cm", (PageWidth / 15 * 3).ToString() + "cm", (PageWidth / 15 * 2).ToString() + "cm", (PageWidth / 15 * 4).ToString() + "cm", (PageWidth / 15).ToString() + "cm", (PageWidth / 15).ToString() + "cm", (PageWidth / 15 * 3).ToString() + "cm" };
            int[][] matrixHeaderMergeDown = new int[2][];
            matrixHeaderMergeDown[0] = new int[7] { 1, 1, 1, 1, 0, 0, 1 };
            matrixHeaderMergeDown[1] = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            int[][] matrixHeaderMergeRight = new int[2][];
            matrixHeaderMergeRight[0] = new int[7] { 0, 0, 0, 0, 1, 0, 0 };
            matrixHeaderMergeRight[1] = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            string[][] strMatrixContent = DataStaging.GetStrMatrixFromListScenario(listPositiveScenario);
            Table table = DocumentFormat.CreateMergedHeaderTable(strArrayHeader, strArrayHeaderSize, matrixHeaderMergeDown, matrixHeaderMergeRight, strMatrixContent, fontName, fontColor, Colors.White, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);

            DocumentFormat.DefineHeading(document, "Negative Scenario and Result", "Heading3", "Negative Scenario and Result");

            strMatrixContent = DataStaging.GetStrMatrixFromListScenario(listNegativeScenario);
            table = DocumentFormat.CreateMergedHeaderTable(strArrayHeader, strArrayHeaderSize, matrixHeaderMergeDown, matrixHeaderMergeRight, strMatrixContent, fontName, fontColor, Colors.White, 12, 0.5, 0.5, true);
            document.LastSection.Add(table);
        }

        void DefineOthersInformation(Document document, string strProOtherInfo)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Others Information", "Heading2", "Others Information");

            DocumentFormat.DefineParagraph(document, strProOtherInfo, ParagraphAlignment.Justify);
        }

        void DefineApproval(Document document, string fontName, Color fontColor, List<Approval> listApproval)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            string[] strArrayHeaderSize = new string[3] { (PageWidth / 4).ToString() + "cm", (PageWidth / 2).ToString() + "cm", (PageWidth / 4).ToString() + "cm" };
            string[] strArrayHeader = new string[3] { "Prepared By", "Verified By", "Approved By" };
            Table table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, fontColor, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            Approval[] approvalArray = DataStaging.GetApprovalArrayFromListApproval2(listApproval);
            string[] strArrayContentSize = new string[4] { (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm" };
            string[][] strMatrixContent = new string[4][];
            strMatrixContent[0] = new string[4] { approvalArray[0].StrPlace + ", " + approvalArray[0].DatetimeApprove.Date.ToString("d MMM yyyy"), approvalArray[1].StrPlace + ", " + approvalArray[1].DatetimeApprove.Date.ToString("d MMM yyyy"), approvalArray[2].StrPlace + ", " + approvalArray[2].DatetimeApprove.Date.ToString("d MMM yyyy"), approvalArray[3].StrPlace + ", " + approvalArray[3].DatetimeApprove.Date.ToString("d MMM yyyy") };
            strMatrixContent[1] = new string[4] { "\n\n\n\n\n", "\n\n\n\n\n", "\n\n\n\n\n", "\n\n\n\n\n" };
            strMatrixContent[2] = new string[4] { approvalArray[0].StrName, approvalArray[1].StrName, approvalArray[2].StrName, approvalArray[3].StrName };
            strMatrixContent[3] = new string[4] { "Quality Control", "Business Analyst", "Project Manager", "LOB Head" };
            table = DocumentFormat.CreateSimpleTableWithoutHeader(strArrayContentSize, strMatrixContent, fontName, fontColor, 12, 0.5, 0.5, ParagraphAlignment.Center);
            document.LastSection.Add(table);
        }
    }
}
