using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab4Zad2.View
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            int userID;
            userID = Model.User.createAccount(textBoxName.Text, textBoxPassword.Text);
            if (userID == -1) MessageBox.Show("Nazwa użytkownika lub hasło jest błędne !");
            else new View.FormMain(userID).Show(); //wchodze od razu na profil nowego uzytkownika

        }
    }
}
