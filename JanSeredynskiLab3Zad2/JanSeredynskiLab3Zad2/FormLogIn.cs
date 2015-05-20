using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JanSeredynskiLab3Zad2
{
    public partial class FormLogIn : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;

        public FormLogIn()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=localhost;database=MiniFacebook;Trusted_Connection=yes");
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //inicjalizuje dostep do bazy danych
            sqlDataAdapter = new SqlDataAdapter
                ("select ID from [User] where Mail = '"+textBoxAccountMail.Text+"' AND Password = '"+textBoxAccountPassword.Text+"'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)  (new FormMainPage(Convert.ToInt32(dataTable.Rows[0][0].ToString()))).Show();
            else MessageBox.Show("Podano nieprawidłowe dane.");
        }

        private void labelSingUp_Click(object sender, EventArgs e)
        {
            (new FormSignUp()).Show();
        }
    }
}
