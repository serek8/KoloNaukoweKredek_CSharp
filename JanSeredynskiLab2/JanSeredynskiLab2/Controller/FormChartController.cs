using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace JanSeredynskiLab2.Controller
{
    public static class FormChartController
    {
        //declare an Excel.Application object.
        public static Excel.Application xlApp;

        //declare workbook
        public static Excel.Workbook xlWorkBook;

        //declare single sheet
        public static Excel.Worksheet xlWorkSheet;

        //define empty value
        static  object misValue = System.Reflection.Missing.Value;

        /// <summary>
        /// Provide COM connection to Excel
        /// </summary>
        public static void ConnectExcel()
        {
            //creating an Excel.Application object.
            xlApp = new Microsoft.Office.Interop.Excel.Application();

            //check whether Excel is installed in your system
            if (xlApp == null)
            {
                System.Windows.Forms.MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            //Then create new Workbook. Only single Workbook will be used so it's already placed in this connection function
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            // Prepare first sheet to write inside
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1); // get first page
        }

        /// <summary>
        /// Transfer data from dataTable to Excel
        /// </summary>
        public static void TransferDataTableToExcel(System.Data.DataTable dataTable)
        {
            //write content to worksheet
            xlWorkSheet.Cells[1, 1] = "Sheet 1 content";

            // Managa dataTable in Excel
            xlWorkSheet.Cells[1, 1] = "Nr. Rej";
            xlWorkSheet.Cells[1, 2] = "Towar";
            xlWorkSheet.Cells[1, 3] = "Ilość";  
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                xlWorkSheet.Cells[i + 2, 1] = dataTable.Rows[i]["ColumnRegisterNumber"];
                xlWorkSheet.Cells[i + 2, 2] = dataTable.Rows[i]["ColumnSupply"];
                xlWorkSheet.Cells[i + 2, 3] = dataTable.Rows[i]["ColumnAmount"];             
            }
            

            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(180, 10, 400, 250);
            Excel.Chart chartPage = myChart.Chart;
            chartRange = xlWorkSheet.get_Range("A2", "C"+(dataTable.Rows.Count+1).ToString());
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            //export chart as picture file
            chartPage.Export(System.IO.Directory.GetCurrentDirectory() + "/wykres.bmp", "BMP", misValue);
        }

        /// <summary>
        /// Save excel to file
        /// </summary>
        public static void SaveExcelToFile(string fileName)
        {
            if (System.IO.File.Exists(fileName))    System.IO.File.Delete(fileName);
            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
        }

        /// <summary>
        /// Relese all COM references
        /// </summary>
        public static void DisconnectExcel()
        {
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
    
            // Clean up COM references
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        /// <summary>
        /// Clean up COM references
        /// </summary>
        /// <param name="obj">ComObject to release</param>
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }



    }
}
