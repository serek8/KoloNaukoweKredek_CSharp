using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab2.Controller
{

    public static class FormMainController
    {
        /// <summary>
        /// Model of Database implemented as DataTable
        /// </summary>
        public static Model.DatabaseModel productDatabase;
        public static System.IO.Stream currentWorkingspaceStream;
        public static string currentDatabaseFileName;


        /// <summary>
        /// Generate PDF from productDatabase.dataTable
        /// </summary>
        /// <param name="fileName"></param>
        public static void GeneratePDF(string fileName)
        {
            Document documentInvoice = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(documentInvoice, new FileStream(fileName, FileMode.Create));
            documentInvoice.Open(); // opens document to write
            //Write some content
            documentInvoice.AddAuthor("Jan Seredynski");


            Paragraph firstHeader = new Paragraph("Rejestr przyjazdów", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22));
            firstHeader.Alignment = Element.ALIGN_CENTER;
            documentInvoice.Add(firstHeader);
            documentInvoice.Add(new Phrase(Environment.NewLine));

            PdfPTable table = new PdfPTable(3); // We ake for table with two columns
            table.AddCell("Nr rej");
            table.AddCell("Towar");
            table.AddCell("Ilosc");
            for (int i = 0; i < productDatabase.dataTable.Rows.Count; i++)
            {

                table.AddCell(productDatabase.dataTable.Rows[i]["ColumnRegisterNumber"].ToString());
                table.AddCell(productDatabase.dataTable.Rows[i]["ColumnSupply"].ToString());
                table.AddCell(productDatabase.dataTable.Rows[i]["ColumnAmount"].ToString());
                
            }

            documentInvoice.Add(table);


            // Now I add the above created text using different class object to our pdf document
            //documentInvoice.Add(new Paragraph("Koniec"));
            documentInvoice.Close();
            MessageBox.Show("Zapisano");

        }

    }
}
