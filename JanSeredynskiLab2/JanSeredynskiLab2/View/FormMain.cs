using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab2
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controller.FormMainController.productDatabase = new Model.DatabaseModel(dataGridViewArrivals);
            Controller.FormMainController.productDatabase.ShowOnDataGridView();
            dataGridViewArrivals.Columns[0].HeaderText = "Nr. rej";
            dataGridViewArrivals.Columns[1].HeaderText = "Towar";
            dataGridViewArrivals.Columns[2].HeaderText = "Ilość";
        }

        /// <summary>
        /// Add data from textBoxRegisterNumber, textBoxRegisterSupply and
        /// textBoxRegisterAmount to dataGridViewArrivals
        /// </summary>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            //Controller.FormMainController.productDatabase.AddRow(textBoxRegisterNumber.Text, textBoxSupply.Text, textBoxAmount.Text);
            Controller.FormMainController.productDatabase.dataTable.Rows.Add
                (new object[] { textBoxRegisterNumber.Text, textBoxSupply.Text, textBoxAmount.Text });
            toolStripStatusLabelMain.Text = "Dodano wpis";
        }

        private void ToolStripMenuItemSaveFileAs_Click(object sender, EventArgs e)
        {
            Controller.FormMainController.productDatabase.SaveToFile(SaveFileDialog("txt files (*.txt)|*.txt|All files (*.*)|*.*"));
            toolStripStatusLabelMain.Text = "Zapisano";
        }

        private void toolStripMenuItemSaveFile_Click(object sender, EventArgs e)
        {
            Controller.FormMainController.productDatabase.SaveToFile(Controller.FormMainController.currentDatabaseFileName);
            toolStripStatusLabelMain.Text = "Zapisano";
        }

        private void toolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            Controller.FormMainController.productDatabase.LoadDatabaseFromFile(OpenFileDialog());
            toolStripStatusLabelMain.Text = "Otworzono bazę danych. Liczba wpisów: "+dataGridViewArrivals.Rows.Count.ToString();
        }
        /// <summary>
        /// Universal method to execute FileDialog
        /// </summary>
        /// <returns>Stream to file chosen in the FileDialog</returns>
        private System.IO.Stream OpenFileDialog()
        {
            System.IO.Stream fileStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFileDialog1.OpenFile()) != null)
                    {
                        MessageBox.Show("Zaladowalem plik");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                Controller.FormMainController.currentDatabaseFileName = openFileDialog1.FileName;
                this.Text= "Rejestr przyjazdów ("+ openFileDialog1.FileName+")";
                return fileStream;
            }
            return null;
        }

        /// <summary>
        /// Open SaveFileDialog to choose location for the file
        /// </summary>
        /// <param name="fileExtensionDescription">Extension types that appear on extension box in SaveFileDialog</param>
        /// <returns>Chosen filename</returns>
        private string SaveFileDialog(string fileExtensionDescription)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = fileExtensionDescription;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Controller.FormMainController.currentDatabaseFileName = saveFileDialog1.FileName;
                return saveFileDialog1.FileName;
                 
            }
            return null;
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            Controller.FormMainController.productDatabase.FilterDatabase(textBoxFind.Text);
            toolStripStatusLabelMain.Text = "Znaleziona liczba wpisów: " + dataGridViewArrivals.Rows.Count.ToString();
        }

        private void buttonGenerateChart_Click(object sender, EventArgs e)
        {
            Controller.FormChartController.ConnectExcel();
            Controller.FormChartController.TransferDataTableToExcel(Controller.FormMainController.productDatabase.dataTable);
            Controller.FormChartController.SaveExcelToFile(System.IO.Directory.GetCurrentDirectory() + "/ark.xls");
            Controller.FormChartController.DisconnectExcel();
            JanSeredynskiLab2.View.FormChart formChart = new JanSeredynskiLab2.View.FormChart();
            formChart.Show();
            toolStripStatusLabelMain.Text = "Wygenerowano wykres"; 
        }


        private void toolStripMenuItemExportToExcel_Click(object sender, EventArgs e)
        {
            Controller.FormChartController.ConnectExcel();
            Controller.FormChartController.TransferDataTableToExcel(Controller.FormMainController.productDatabase.dataTable);
            Controller.FormChartController.SaveExcelToFile(SaveFileDialog("Excel files (*.xls)|*.xls|All files (*.*)|*.*"));
            Controller.FormChartController.DisconnectExcel();
            toolStripStatusLabelMain.Text = "Wyeksportowano baze danych";
        }

        private void ToolStripMenuItemGenerateChart_Click(object sender, EventArgs e)
        {
            Controller.FormChartController.ConnectExcel();
            Controller.FormChartController.TransferDataTableToExcel(Controller.FormMainController.productDatabase.dataTable);
            Controller.FormChartController.SaveExcelToFile(System.IO.Directory.GetCurrentDirectory() + "/ark.xls");
            Controller.FormChartController.DisconnectExcel();
            JanSeredynskiLab2.View.FormChart formChart = new JanSeredynskiLab2.View.FormChart();
            formChart.Show();
            toolStripStatusLabelMain.Text = "Wygenerowano wykres"; 
        }

        private void toolStripMenuItemExportToPDF_Click(object sender, EventArgs e)
        {
            Controller.FormMainController.GeneratePDF(SaveFileDialog("PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"));
            toolStripStatusLabelMain.Text = "Wyeksportowano baze danych";
        }
    }
}
