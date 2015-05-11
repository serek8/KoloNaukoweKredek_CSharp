using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab2.View
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }


        private void FormChart_Load(object sender, EventArgs e)
        {
            Image im = GetCopyImage(System.IO.Directory.GetCurrentDirectory() + "/wykres.bmp");
            pictureBoxChartSupplyAndAmount.Image = im;
                //Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "/wykres.bmp");
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
    }
}
