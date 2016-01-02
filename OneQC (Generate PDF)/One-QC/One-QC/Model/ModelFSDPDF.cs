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
    class ModelFSDPDF
    {
        const string FontName = "Arial";
        const double PageWidth = 27.7;

        public void GenerateFSD(string strProID, string strProTitle, string strProType, List<RevisionHistory> listRevisionHistory, string strProObjective, string strProAppName, string[] strArrayProDatabase, string[] strArrayProMiddleware, string[] strArrayProPicturePathTopology, string[] strArrayProPicturePathMenuRelation, string[] strArrayProPicturePathDatabaseDiagram, List<Solution> listSolution, string[] strArrayProJobBatch, string[] strArrayProParam, List<Attachment> listAttachment, string strProTestScenario, string strProOtherInfo, List<Approval> listApproval)
        {
            Document document = CreateDocument(strProID, strProTitle, strProType, listRevisionHistory, strProObjective, strProAppName, strArrayProDatabase, strArrayProMiddleware, strArrayProPicturePathTopology, strArrayProPicturePathMenuRelation, strArrayProPicturePathDatabaseDiagram, listSolution, strArrayProJobBatch, strArrayProParam, listAttachment, strProTestScenario, strProOtherInfo, listApproval);
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;
            renderer.RenderDocument();
            string filename = strProID + " - " + strProTitle + ".pdf";
            renderer.PdfDocument.Save(filename);
            Process.Start(filename);
        }

        Document CreateDocument(string strProID, string strProTitle, string strProType, List<RevisionHistory> listRevisionHistory, string strProObjective, string strProAppName, string[] strArrayProDatabase, string[] strArrayProMiddleware, string[] strArrayProPicturePathTopology, string[] strArrayProPicturePathMenuRelation, string[] strArrayProPicturePathDatabaseDiagram, List<Solution> listSolution, string[] strArrayProJobBatch, string[] strArrayProParam, List<Attachment> listAttachment, string strProTestScenario, string strProOtherInfo, List<Approval> listApproval)
        {
            Document document = new Document();
            document.Info.Title = strProID;
            document.Info.Subject = strProTitle;
            document.Info.Author = DataStaging.GetApprovalArrayFromListApproval(listApproval)[0].StrName;

            DefineStyles(document, FontName, Colors.Black, Colors.White, Colors.Black);
            DefineTitle(document, strProID, strProTitle, strProType);
            DefineDocumentChangeControl(document, FontName, Colors.Black, listRevisionHistory);
            DefineObjectives(document, strProObjective);
            DefineScope(document, strProAppName, strArrayProDatabase, strArrayProMiddleware);
            DefineTopology(document, strArrayProPicturePathTopology);
            DefineMenuRelation(document, strArrayProPicturePathMenuRelation);
            DefineDatabaseDiagram(document, strArrayProPicturePathDatabaseDiagram);
            DefineSolution(document, FontName, Colors.Black, listSolution);
            DefineJobBatch(document, strArrayProJobBatch);
            DefineParam(document, strArrayProParam);
            DefineAttachment(document, listAttachment);
            DefineTestScenario(document, strProTestScenario);
            DefineOtherInfo(document, strProOtherInfo);
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

        void DefineTitle(Document document, string strProID, string strProTitle, string strProType)
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
            DocumentFormat.DefineHeading(document, "Functional Specification Design", "Heading1", "Functional Specification Design");
            
            string titleContent =
                "Title of Functional Specification Design\t\t:\t" + strProTitle + "\n" +
                "Project ID\t\t\t\t\t\t\t:\t" + strProID + "\n" +
                "Security / Network / Infrastructure / Application\t:\t" + strProType;
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

        void DefineMenuRelation(Document document, string[] strArrayProPicturePathMenuRelation)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Menu Relation", "Heading2", "Menu Relation");

            for (int i = 0; i < strArrayProPicturePathMenuRelation.Length; i++)
            {
                DocumentFormat.DefineImage(document.LastSection, strArrayProPicturePathMenuRelation[i], PageWidth.ToString() + "cm", ShapePosition.Center);
                if (i < strArrayProPicturePathMenuRelation.Length - 1) document.LastSection.AddPageBreak();
            }
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

        void DefineSolution(Document document, string fontName, Color fontColor, List<Solution> listSolution)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Solution", "Heading2", "Solution");

            for (int i = 0; i < listSolution.Count; i++)
            {
                DocumentFormat.DefineHeading(document, listSolution[i].StrBRID, "Heading3", listSolution[i].StrBRID);
                string[] strArrayColumnSize = new string[4] { (PageWidth / 22).ToString() + "cm", (PageWidth / 22 * 5).ToString() + "cm", (PageWidth / 22).ToString() + "cm", (PageWidth / 22 * 15).ToString() + "cm" };
                if (listSolution[i].StrFlowPicturePath.Equals(""))
                {
                    string[][] strMatrixContent = new string[9][];
                    strMatrixContent[0] = new string[4] { "a.", "Handles BR ID", ":", listSolution[i].StrHandleBRID };
                    strMatrixContent[1] = new string[4] { "b.", "Flow", ":", listSolution[i].StrFlowText };
                    strMatrixContent[2] = new string[4] { "c.", "Table Reference", ":", DataStaging.GetStrFromStrArray(listSolution[i].StrArrayTableReference) };
                    strMatrixContent[3] = new string[4] { "d.", "Store Procedure Reference", ":", DataStaging.GetStrFromStrArray(listSolution[i].StrArrayStoreProcedureReference) };
                    strMatrixContent[4] = new string[4] { "e.", "Client", ":", listSolution[i].StrClient };
                    strMatrixContent[5] = new string[4] { "f.", "Simulation", ":", "" };
                    strMatrixContent[6] = new string[4] { "", "Input", ":", listSolution[i].Simulation.StrInput };
                    strMatrixContent[7] = new string[4] { "", "Process", ":", listSolution[i].Simulation.StrProcess };
                    strMatrixContent[8] = new string[4] { "", "Output", ":", listSolution[i].Simulation.StrOutput };
                    Table table = DocumentFormat.CreateSimpleTableWithoutHeader(strArrayColumnSize, strMatrixContent, fontName, fontColor, 12, 0, 0, ParagraphAlignment.Justify);
                    document.LastSection.Add(table);
                }
                else
                {
                    string[][] strMatrixContent = new string[10][];
                    strMatrixContent[0] = new string[4] { "a.", "Handles BR ID", ":", listSolution[i].StrHandleBRID };
                    strMatrixContent[1] = new string[4] { "b.", "Flow", ":", listSolution[i].StrFlowPicturePath };
                    strMatrixContent[2] = new string[4] { "", "", "", listSolution[i].StrFlowText };
                    strMatrixContent[3] = new string[4] { "c.", "Table Reference", ":", DataStaging.GetStrFromStrArray(listSolution[i].StrArrayTableReference) };
                    strMatrixContent[4] = new string[4] { "d.", "Store Procedure Reference", ":", DataStaging.GetStrFromStrArray(listSolution[i].StrArrayStoreProcedureReference) };
                    strMatrixContent[5] = new string[4] { "e.", "Client", ":", listSolution[i].StrClient };
                    strMatrixContent[6] = new string[4] { "f.", "Simulation", ":", "" };
                    strMatrixContent[7] = new string[4] { "", "Input", ":", listSolution[i].Simulation.StrInput };
                    strMatrixContent[8] = new string[4] { "", "Process", ":", listSolution[i].Simulation.StrProcess };
                    strMatrixContent[9] = new string[4] { "", "Output", ":", listSolution[i].Simulation.StrOutput };
                    Table table = DocumentFormat.CreateSimpleTableWithoutHeader(strArrayColumnSize, strMatrixContent, fontName, fontColor, 12, 0, 0, ParagraphAlignment.Justify);
                    document.LastSection.Add(table);
                }
                if (i < listSolution.Count - 1) document.LastSection.AddPageBreak();
            }
        }

        void DefineJobBatch(Document document, string[] strArrayProJobBatch)
        {
            document.LastSection.AddPageBreak();

            DocumentFormat.DefineHeading(document, "Job / Batch", "Heading2", "Job / Batch");

            DocumentFormat.DefineParagraph(document, DataStaging.GetStrFromStrArray(strArrayProJobBatch), ParagraphAlignment.Justify);
        }

        void DefineParam(Document document, string[] strArrayProParam)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Parameter", "Heading2", "Parameter");

            DocumentFormat.DefineParagraph(document, DataStaging.GetStrFromStrArray(strArrayProParam), ParagraphAlignment.Justify);
        }

        void DefineAttachment(Document document, List<Attachment> listAttachment)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Attachment", "Heading2", "Attachment");

            for (int i = 0; i < listAttachment.Count; i++)
            {
                DocumentFormat.DefineHeading(document, listAttachment[i].StrTitle, "Heading3", listAttachment[i].StrTitle);
                if (!listAttachment[i].StrPicturePath.Equals("")) DocumentFormat.DefineImage(document.LastSection, listAttachment[i].StrPicturePath, (PageWidth / 3 * 2).ToString() + "cm", ShapePosition.Center);
                DocumentFormat.DefineParagraph(document, listAttachment[i].StrText, ParagraphAlignment.Justify);
            }
        }

        void DefineTestScenario(Document document, string strProTestScenario)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Test Scenario", "Heading2", "Test Scenario");

            DocumentFormat.DefineParagraph(document, strProTestScenario, ParagraphAlignment.Justify);
        }

        void DefineOtherInfo(Document document, string strProOtherInfo)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            DocumentFormat.DefineHeading(document, "Other Information", "Heading2", "Other Information");

            DocumentFormat.DefineParagraph(document, strProOtherInfo, ParagraphAlignment.Justify);
        }

        void DefineApproval(Document document, string fontName, Color fontColor, List<Approval> listApproval)
        {
            DocumentFormat.DefineParagraph(document, "", ParagraphAlignment.Center);

            string[] strArrayHeaderSize = new string[3] { (PageWidth / 4).ToString() + "cm", (PageWidth / 2).ToString() + "cm", (PageWidth / 4).ToString() + "cm" };
            string[] strArrayHeader = new string[3] { "Prepared By", "Verified By", "Approved By" };
            Table table = DocumentFormat.CreateSimpleRow(strArrayHeader, strArrayHeaderSize, FontName, fontColor, Colors.White, 12, ParagraphAlignment.Center, 0.5, 0.5, true);
            document.LastSection.Add(table);

            Approval[] approvalArray = DataStaging.GetApprovalArrayFromListApproval(listApproval);
            string[] strArrayContentSize = new string[4] { (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm", (PageWidth / 4).ToString() + "cm" };
            string[][] strMatrixContent = new string[4][];
            strMatrixContent[0] = new string[4] { approvalArray[0].StrPlace + ", " + approvalArray[0].DatetimeApprove.Date.ToString("d MMM yyyy"), approvalArray[1].StrPlace + ", " + approvalArray[1].DatetimeApprove.Date.ToString("d MMM yyyy"), approvalArray[2].StrPlace + ", " + approvalArray[2].DatetimeApprove.Date.ToString("d MMM yyyy"), approvalArray[3].StrPlace + ", " + approvalArray[3].DatetimeApprove.Date.ToString("d MMM yyyy") };
            strMatrixContent[1] = new string[4] { "\n\n\n\n\n", "\n\n\n\n\n", "\n\n\n\n\n", "\n\n\n\n\n" };
            strMatrixContent[2] = new string[4] { approvalArray[0].StrName, approvalArray[1].StrName, approvalArray[2].StrName, approvalArray[3].StrName };
            strMatrixContent[3] = new string[4] { "System Analyst", "Business Analyst", "Project Manager", "LOB Head" };
            table = DocumentFormat.CreateSimpleTableWithoutHeader(strArrayContentSize, strMatrixContent, fontName, fontColor, 12, 0.5, 0.5, ParagraphAlignment.Center);
            document.LastSection.Add(table);
        }
    }
}
