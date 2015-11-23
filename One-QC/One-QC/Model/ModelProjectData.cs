using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace One_QC.Model
{
    class ModelProjectData
    {
        public void GenerateBRD()
        {

        }

        public void GenerateBRDCover(string strProID, string strProTitle, DateTime datetimeProDate, string strProBRD, string strProSFAT, string strProITRoadMap, string strEmpIDBA, string strEmpIDBU)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = strProID + " - " + strProTitle;
            PdfPage pdfPage = pdf.AddPage();
            pdfPage.Size = PageSize.A4;
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            DrawRectangle(graph, XColors.Black, new XRect(GetCoordinateFromInch(0.3), GetCoordinateFromInch(0.3), GetCoordinateFromInch(7.7), GetCoordinateFromInch(11.1)));
            DrawImage(graph, "OCBC NISP Cover.png", new XRect(148.8, GetCoordinateFromInch(1.3), 300, 63));

            string pdfFileName = strProID + " - " + strProTitle + ".pdf";
            pdf.Save(pdfFileName);
            Process.Start(pdfFileName);
        }

        public void DrawRectangle(XGraphics graph, XColor color, XRect rect)
        {
            XPen pen = new XPen(color);
            graph.DrawRectangle(pen, rect);
        }

        public void DrawImage(XGraphics graph, string path, XRect rect)
        {
            XImage image = XImage.FromFile(path);
            graph.DrawImage(image, rect);
        }

        public double GetCoordinateFromInch(double inches)
        {
            return inches * 72;
        }

        public double GetCoordinateFromCentimeter(double centimeters)
        {
            return centimeters * 0.39370 * 72;
        }
    }
}
