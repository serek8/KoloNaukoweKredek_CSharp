using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab4PracaDomowa
{
    public partial class FormMainView : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public FormMainView()
        {
            InitializeComponent();
            dc = new DataClasses1DataContext();
        }

        private void bTest1_Click(object sender, EventArgs e)
        {
            var query = from c in dc.Products select c;
            DgvView.DataSource = query;
        }

        private void bTest2_Click(object sender, EventArgs e)
        {
            var query = from c in dc.Products select new { c.ProductID, c.ProductName };
            DgvView.DataSource = query;
        }

        private void bTest3_Click(object sender, EventArgs e)
        {
            var query = from c in dc.Products orderby c.ProductID descending select new { c.ProductID, c.ProductName };
            DgvView.DataSource = query;
        }

        private void bTest4_Click(object sender, EventArgs e)
        {
            var query = from c in dc.Products
                        where c.ProductID < 10
                        where c.ProductName.Substring(0,1) == "C"
                        orderby c.ProductID
                        select new { c.ProductID, c.ProductName };
            DgvView.DataSource = query;
        }

        private void bTest5_Click(object sender, EventArgs e)
        {
            var query = from c in dc.Products
                        orderby c.ProductID
                        select new { c.ProductID, c.ProductName, c.Category.CategoryName }; // odwolujemy sie do Category jak do siebie bo mamy Relations
            DgvView.DataSource = query; 
        }

        private void bTest6_Click(object sender, EventArgs e)
        {
            var query = (from c in dc.Products
                         orderby c.ProductName
                         select new { c.ProductID, c.ProductName, c.Category.CategoryName }).ToArray();
            MessageBox.Show(query[0].ToString());
        }

        private void bTest7_Click(object sender, EventArgs e)
        {
            var query = (from c in dc.Products
                         select c).Count();
            MessageBox.Show(query.ToString());
        }
    }
}
