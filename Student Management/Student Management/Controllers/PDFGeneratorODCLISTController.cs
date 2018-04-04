using ClassLibrary2.BuisnessObject;
using ClassLibrary2.ViewModels;
using ClassLibrary3.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Student_Management.Controllers
{
    public class PDFGeneratorODCLISTController : Controller
    {
        // GET: PDFGeneratorODCLIST
        public FileResult CreatePdf()
        {
            MemoryStream workStream = new MemoryStream();
            StringBuilder status = new StringBuilder("");
            DateTime dTime = DateTime.Now;
            //file name to be created   
            string strPDFFileName = string.Format("ODLList" + dTime.ToString("yyyyMMdd") + "-" + ".pdf");
            Document doc = new Document();
            doc.SetMargins(0f,0f,0f,0f);
            //Create PDF Table with 5 columns  
            PdfPTable tableLayout = new PdfPTable(5);
            doc.SetMargins(0f,0f,0f,0f);
            //Create PDF Table  

            //file will created in this path  
            string strAttachment = Server.MapPath("~/Downloads/" + strPDFFileName);


            PdfWriter.GetInstance(doc, workStream).CloseStream = false;
            doc.Open();

            //Add Content to PDF   
            doc.Add(Add_Content_To_PDF(tableLayout));

            // Closing the document  
            doc.Close();

            byte[] byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;


            return File(workStream, "application/pdf", strPDFFileName);

        }

        protected PdfPTable Add_Content_To_PDF(PdfPTable tableLayout)
        {
            

            float[] headers = { 30, 25, 25, 20,25}; //Header Widths  
            tableLayout.SetWidths(headers); //Set the pdf headers  
            tableLayout.WidthPercentage = 100; //Set the PDF File witdh percentage  
            tableLayout.HeaderRows = 1;
            //Add Title to the PDF file at the top  

            //  List<ODCDetails> employees = Content.employees.toList<ODCDetails>();
            var odc = new ODC();
            var oDCListViewModel = new ODCListViewModel();
            oDCListViewModel.ListofODC = odc.ODCList();

            tableLayout.AddCell(new PdfPCell(new Phrase("Student List(ODC)", new Font(Font.FontFamily.HELVETICA, 8, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) {
                Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_CENTER
            });


            ////Add header  
            AddCellToHeader(tableLayout, "Name");
            AddCellToHeader(tableLayout, "Place");
            AddCellToHeader(tableLayout, "Timing");
            AddCellToHeader(tableLayout, "Date of ODC");
            AddCellToHeader(tableLayout, "Department");
            

            ////Add body  

            foreach (var emp in oDCListViewModel.ListofODC)
            {

                AddCellToBody(tableLayout, emp.NameOfCandidate.ToString()+emp.SurnameOfCandidate.ToString());
                AddCellToBody(tableLayout, emp.Place);
                AddCellToBody(tableLayout, emp.Timing);
                AddCellToBody(tableLayout, emp.DateOfODC.ToString());
                AddCellToBody(tableLayout, emp.Department.ToString());
            }

            return tableLayout;
        }
        // Method to add single cell to the Header  
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {

            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, iTextSharp.text.BaseColor.YELLOW)))
            {
                HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(128, 0, 0)
    });
        }

        // Method to add single cell to the body  
        private static void AddCellToBody(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.FontFamily.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
             {
                HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
    });
        }
    }
}