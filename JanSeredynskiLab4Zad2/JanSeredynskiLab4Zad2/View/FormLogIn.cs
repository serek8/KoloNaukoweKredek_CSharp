using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab4Zad2
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            int userID;
            userID = Model.User.getIDByNameAndPassword(textBoxName.Text, textBoxPassword.Text);
            if (userID == -1) MessageBox.Show("Nazwa użytkownika lub hasło jest błędne !");
            else new JanSeredynskiLab4Zad2.View.FormMain(userID).Show();

        }

        private void labelCreateNewAccount_Click(object sender, EventArgs e)
        {
            (new View.FormSignUp()).Show();
        }
    }
}
