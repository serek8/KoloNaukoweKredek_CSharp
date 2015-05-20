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
    public partial class FormSignUp : Form
    {
        SqlConnection sqlConnection;
        public FormSignUp()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=localhost;database=MiniFacebook;Trusted_Connection=yes");
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("Insert into [User] (Name, Password, Mail) values ('" + textBoxAccountName.Text + "','"+textBoxAccountPassword.Text+"' , '"+textBoxAccountMail.Text+"')");
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Konto zostało założone.");
            Close();
        }
    }
}
