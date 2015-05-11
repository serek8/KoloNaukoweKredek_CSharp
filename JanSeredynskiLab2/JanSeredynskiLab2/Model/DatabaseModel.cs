using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanSeredynskiLab2.Model
{
    public class DatabaseModel
    {
        public const uint columnAmount = 3;

        /// <summary>
        /// dataTable contains data loaded from file
        /// </summary>
        public DataTable dataTable;

        /// <summary>
        /// Contains DataGridView where main DataTable is located
        /// </summary>
        private System.Windows.Forms.DataGridView mainDataGridView;

        public DatabaseModel(System.Windows.Forms.DataGridView dgv)
        {
            dataTable = new DataTable();
            mainDataGridView = dgv;
            dataTable.Columns.Add("ColumnRegisterNumber", typeof(string));
            dataTable.Columns.Add("ColumnSupply", typeof(string));
            dataTable.Columns.Add("ColumnAmount", typeof(string));
            
            //loadDatabaseFromFile();
        }
        /// <summary>
        /// Load Database from File
        /// </summary>
        /// <param name="inputStream"></param>
        public void LoadDatabaseFromFile(System.IO.Stream inputStream)
        {
            System.IO.StreamReader databaseFile = new System.IO.StreamReader(inputStream);
            dataTable.Clear();
            while (databaseFile.Peek() != -1)
            {
                dataTable.Rows.Add(new object[] 
                    { databaseFile.ReadLine(), databaseFile.ReadLine(), databaseFile.ReadLine() });
            }
            databaseFile.Close();
        }

        /// <summary>
        /// Show dataTable on DataGridView
        /// </summary>
        public void ShowOnDataGridView()
        {
            mainDataGridView.DataSource = this.dataTable; // Refreshes as something added thanks to properties
        }

        /// <summary>
        /// Add row to dataTable
        /// </summary>
        /// <param name="columnRegisterNumber">Register number - cell</param>
        /// <param name="columnSupply">Supply - cell</param>
        /// <param name="columnAmount">Amount - cell</param>
        public void AddRow(string columnRegisterNumber, string columnSupply, string columnAmount)
        {
            dataTable.Rows.Add(columnRegisterNumber, columnSupply, columnAmount);
        }



        /// <summary>
        /// Save data from dataGridViewArrivals to text.txt
        /// </summary>
        /// <param name="dgv">DataGridView object from which method fetches data to write do file</param>
        public void SaveToFile(string fileName)
        {
            // Create StreamWriter object to push data to file
            System.IO.StreamWriter stream = new System.IO.StreamWriter(fileName);
            for (int i = 0; i < dataTable.Rows.Count; i++) // Rows
            {
                stream.WriteLine(dataTable.Rows[i]["ColumnRegisterNumber"].ToString());
                stream.WriteLine(dataTable.Rows[i]["ColumnSupply"].ToString());
                stream.WriteLine(dataTable.Rows[i]["ColumnAmount"].ToString());
                //stream.Write(Environment.NewLine);
            }
            stream.Close();
        }

        /// <summary>
        /// Filter dataBase by {text}
        /// </summary>
        /// <param name="text">Filter pattern</param>
        public void FilterDatabase(string text)
        {
            dataTable.DefaultView.RowFilter = string.Format("ColumnRegisterNumber LIKE '%{0}%' OR ColumnSupply LIKE '%{0}%' OR ColumnAmount LIKE '%{0}%'", text);

        }
        /// <summary>
        /// Clear dataTable
        /// </summary>
        public void ClearDataTable()
        {
            dataTable.Clear();
        }
    }
}
//textBoxFind