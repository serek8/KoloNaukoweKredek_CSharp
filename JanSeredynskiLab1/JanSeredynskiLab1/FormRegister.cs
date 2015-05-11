using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab1
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisano: "+textBoxName.Text+"\nNazwisko: "+textBoxPassword.Text);
            //FormOrder formOrder = new FormOrder();
            //formOrder.ShowDialog();
        }
    }
}
