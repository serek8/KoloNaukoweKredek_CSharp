using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab3Zad2
{
    public partial class FormUniversalDataViewer : Form
    {
        
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        public FormUniversalDataViewer(string tableKind)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=localhost;database=MiniFacebook;Trusted_Connection=yes");
            sqlDataAdapter = new SqlDataAdapter
            ("select * from ["+tableKind+"]", sqlConnection);
 
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewDatabase.DataSource = dataTable;
        }
    }
}
