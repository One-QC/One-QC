using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace One_QC
{
    static class DocumentFormat
    {
        public static void DefineTableOfContentList(Section section, string fontName, Color fontColor, string strName)
        {
            Paragraph paragraph = section.AddParagraph();
            paragraph.Style = "TOC";
            Hyperlink hyperlink = paragraph.AddHyperlink(strName);
            hyperlink.Font.Name = fontName;
            hyperlink.Font.Color = fontColor;
            hyperlink.AddText(strName);
            hyperlink.AddTab();
            hyperlink.AddPageRefField(strName);
        }

        public static void DefineHeading(Document document, string strTitle, string strHeading, string strBookmark)
        {
            Paragraph paragraph = document.LastSection.AddParagraph(strTitle, strHeading);
            paragraph.AddBookmark(strBookmark);
        }
        
        public static void DefineParagraph(Document document, string strText, ParagraphAlignment alignment)
        {
            Paragraph paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Alignment = alignment;
            paragraph.AddText(strText);
        }

        public static void DefineParagraph(Document document, string strText, ParagraphAlignment alignment, Unit fontSize)
        {
            Paragraph paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Alignment = alignment;
            paragraph.Format.Font.Size = fontSize;
            paragraph.AddText(strText);
        }

        public static void DefineImage(Section section, string strPath, Unit strWidth, ShapePosition shapePosition)
        {
            Image image = section.AddImage(strPath);
            image.Width = strWidth;
            image.Left = shapePosition;
        }

        public static void DefineImage(Section section, string strPath, Unit strWidth, ShapePosition shapePosition, WrapStyle wrapStyle)
        {
            Image image = section.AddImage(strPath);
            image.Width = strWidth;
            image.Left = shapePosition;
            image.WrapFormat.Style = wrapStyle;
        }

        public static Table CreateSimpleRow(string[] strArrayRow, string[] strArrayRowSize, string fontName, Color fontColor, Color shadeColor, Unit fontSize, ParagraphAlignment alignment, double borderSize, double edgeSize, bool isBold)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayRow.GetLength(0); i++)
            {
                table.AddColumn(strArrayRowSize[i]);
            }

            Row row = table.AddRow();
            row.Format.Alignment = alignment;
            row.Format.Font.Bold = isBold;
            row.Format.Font.Name = fontName;
            row.Format.Font.Color = fontColor;
            row.Format.Font.Size = fontSize;
            row.Shading.Color = shadeColor;
            row.VerticalAlignment = VerticalAlignment.Center;

            Cell cell;

            for (int i = 0; i < strArrayRow.GetLength(0); i++)
            {
                cell = row.Cells[i];
                cell.AddParagraph(strArrayRow[i]);
            }

            table.SetEdge(0, 0, strArrayRow.GetLength(0), 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateSimpleTable(string[] strArrayHeader, string[] strArrayHeaderSize, string[][] strMatrixContent, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }

            Row row = table.AddRow();
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = isHeaderBold;
            row.Format.Font.Name = fontName;
            row.Format.Font.Color = fontColor;
            row.Format.Font.Size = fontSize;
            row.Shading.Color = shadeColor;
            row.VerticalAlignment = VerticalAlignment.Center;

            Cell cell;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                cell = row.Cells[i];
                cell.AddParagraph(strArrayHeader[i]);
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = strArrayHeaderSize[j];
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strArrayHeader.GetLength(0), strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateSimpleTableWithoutHeader(string[] strArrayColumnSize, string[][] strMatrixContent, string fontName, Color fontColor, Unit fontSize, double borderSize, double edgeSize, ParagraphAlignment alignment)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayColumnSize.GetLength(0); i++)
            {
                table.AddColumn(strArrayColumnSize[i]);
            }

            Row row;
            Cell cell;
            
            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                row = table.AddRow();
                row.Format.Alignment = alignment;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = strArrayColumnSize[j];
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strArrayColumnSize.GetLength(0), strMatrixContent.GetLength(0), Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateMergedDownTable(string[] strArrayHeader, string[] strArrayHeaderSize, string[][] strMatrixContent, int[][] matrixMergeDown, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }

            Row row = table.AddRow();
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = isHeaderBold;
            row.Format.Font.Name = fontName;
            row.Format.Font.Color = fontColor;
            row.Format.Font.Size = fontSize;
            row.Shading.Color = shadeColor;
            row.VerticalAlignment = VerticalAlignment.Center;

            Cell cell;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                cell = row.Cells[i];
                cell.AddParagraph(strArrayHeader[i]);
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    cell.MergeDown = matrixMergeDown[i][j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = strArrayHeaderSize[j];
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strArrayHeader.GetLength(0), strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateMergedDownTable(string[] strArrayHeader, string[] strArrayHeaderSize, string[][] strMatrixContent, int[][] matrixMergeDown, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold, string imageWidth)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }

            Row row = table.AddRow();
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = isHeaderBold;
            row.Format.Font.Name = fontName;
            row.Format.Font.Color = fontColor;
            row.Format.Font.Size = fontSize;
            row.Shading.Color = shadeColor;
            row.VerticalAlignment = VerticalAlignment.Center;

            Cell cell;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                cell = row.Cells[i];
                cell.AddParagraph(strArrayHeader[i]);
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    cell.MergeDown = matrixMergeDown[i][j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = imageWidth;
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strArrayHeader.GetLength(0), strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateMergedDownTable(string[] strArrayHeader, string[] strArrayHeaderSize, string[][] strMatrixContent, int[][] matrixMergeDown, bool[][] isBottomBorderVisible, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }

            Row row = table.AddRow();
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = isHeaderBold;
            row.Format.Font.Name = fontName;
            row.Format.Font.Color = fontColor;
            row.Format.Font.Size = fontSize;
            row.Shading.Color = shadeColor;
            row.VerticalAlignment = VerticalAlignment.Center;

            Cell cell;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                cell = row.Cells[i];
                cell.AddParagraph(strArrayHeader[i]);
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    cell.MergeDown = matrixMergeDown[i][j];
                    cell.Borders.Bottom.Visible = isBottomBorderVisible[i][j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = strArrayHeaderSize[j];
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strArrayHeader.GetLength(0), strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateMergedDownTable(string[] strArrayHeader, string[] strArrayHeaderSize, string[][] strMatrixContent, int[][] matrixMergeDown, bool[][] isBottomBorderVisible, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold, string imageWidth)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }

            Row row = table.AddRow();
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = isHeaderBold;
            row.Format.Font.Name = fontName;
            row.Format.Font.Color = fontColor;
            row.Format.Font.Size = fontSize;
            row.Shading.Color = shadeColor;
            row.VerticalAlignment = VerticalAlignment.Center;

            Cell cell;

            for (int i = 0; i < strArrayHeader.GetLength(0); i++)
            {
                cell = row.Cells[i];
                cell.AddParagraph(strArrayHeader[i]);
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    cell.MergeDown = matrixMergeDown[i][j];
                    cell.Borders.Bottom.Visible = isBottomBorderVisible[i][j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = imageWidth;
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strArrayHeader.GetLength(0), strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateMergedHeaderTable(string[][] strMatrixHeader, string[] strArrayHeaderSize, int[][] matrixHeaderMergeDown, int[][] matrixHeaderMergeRight, string[][] strMatrixContent, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayHeaderSize.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }

            Cell cell;

            for (int i = 0; i < strMatrixHeader.GetLength(0); i++)
            {
                Row row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Format.Font.Bold = isHeaderBold;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;
                row.Shading.Color = shadeColor;
                row.VerticalAlignment = VerticalAlignment.Center;

                string[] strArrayHeader = strMatrixHeader[i];

                for (int j = 0; j < strArrayHeader.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    cell.MergeDown = matrixHeaderMergeDown[i][j];
                    cell.MergeRight = matrixHeaderMergeRight[i][j];
                    cell.AddParagraph(strMatrixHeader[i][j]);
                }
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                Row row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = strArrayHeaderSize[j];
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strMatrixHeader.GetLength(0), strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateMergedTable(string[][] strMatrixHeader, string[] strArrayHeaderSize, int[][] matrixHeaderMergeDown, int[][] matrixHeaderMergeRight, string[][] strMatrixContent, int[][] matrixContentMergeDown, int[][] matrixContentMergeRight, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            for (int i = 0; i < strArrayHeaderSize.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }
            
            Cell cell;

            for (int i = 0; i < strMatrixHeader.GetLength(0); i++)
            {
                Row row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Format.Font.Bold = isHeaderBold;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;
                row.Shading.Color = shadeColor;
                row.VerticalAlignment = VerticalAlignment.Center;

                string[] strArrayHeader = strMatrixHeader[i];

                for (int j = 0; j < strArrayHeader.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    cell.MergeDown = matrixHeaderMergeDown[i][j];
                    cell.MergeRight = matrixHeaderMergeRight[i][j];
                    cell.AddParagraph(strMatrixHeader[i][j]);
                }
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                Row row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0); j++)
                {
                    cell = row.Cells[j];
                    cell.MergeDown = matrixContentMergeDown[i][j];
                    cell.MergeRight = matrixContentMergeRight[i][j];
                    if (strArrayContent[j].Contains(".jpg") || strArrayContent[j].Contains(".png"))
                    {
                        Image image = new Image(strArrayContent[j]);
                        image.Width = strArrayHeaderSize[j];
                        cell.Add(image);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j]);
                    }
                }
            }

            table.SetEdge(0, 0, strMatrixHeader.GetLength(0), strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }

        public static Table CreateSimpleMatrix(string[] strArrayHeaderHorizontal, string[] strArrayHeaderVertical, string strHeaderSize, string[] strArrayHeaderSize, string[][] strMatrixContent, string fontName, Color fontColor, Color shadeColor, Unit fontSize, double borderSize, double edgeSize, bool isHeaderBold)
        {
            Table table = new Table();
            table.Borders.Width = borderSize;

            Column column = table.AddColumn(strHeaderSize);
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Format.Font.Bold = true;
            column.Format.Font.Name = fontName;
            column.Format.Font.Color = fontColor;
            column.Format.Font.Size = fontSize;
            column.Shading.Color = shadeColor;

            for (int i = 0; i < strArrayHeaderHorizontal.GetLength(0); i++)
            {
                table.AddColumn(strArrayHeaderSize[i]);
            }

            Row row = table.AddRow();
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = isHeaderBold;
            row.Format.Font.Name = fontName;
            row.Format.Font.Color = fontColor;
            row.Format.Font.Size = fontSize;
            row.Shading.Color = shadeColor;
            row.VerticalAlignment = VerticalAlignment.Center;

            Cell cell;

            for (int i = 0; i < strArrayHeaderHorizontal.GetLength(0) + 1; i++)
            {
                cell = row.Cells[i];
                if (i == 0)
                {
                    cell.Shading.Color = Colors.Black;
                }
                else
                {
                    cell.AddParagraph(strArrayHeaderHorizontal[i - 1]);
                }
            }

            for (int i = 0; i < strMatrixContent.GetLength(0); i++)
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Left;
                row.Format.Font.Bold = false;
                row.Format.Font.Name = fontName;
                row.Format.Font.Color = fontColor;
                row.Format.Font.Size = fontSize;

                string[] strArrayContent = strMatrixContent[i];

                for (int j = 0; j < strArrayContent.GetLength(0) + 1; j++)
                {
                    cell = row.Cells[j];
                    if (j == 0)
                    {
                        cell.AddParagraph(strArrayHeaderVertical[i]);
                    }
                    else
                    {
                        cell.AddParagraph(strArrayContent[j - 1]);
                    }
                }
            }

            table.SetEdge(0, 0, strArrayHeaderHorizontal.GetLength(0) + 1, strMatrixContent.GetLength(0) + 1, Edge.Box, BorderStyle.Single, edgeSize, Colors.Black);
            return table;
        }
    }
}
