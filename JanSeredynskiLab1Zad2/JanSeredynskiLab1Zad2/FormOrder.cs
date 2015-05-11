using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace JanSeredynskiLab1Zad2
{
    public partial class FormOrder : Form
    {
        public ProductDescription[] products;
        public int priceInTotal;
        public FormOrder()
        {
            InitializeComponent();
            products = new ProductDescription[3];
            products[0] = new ProductDescription("Matrix I", "australijsko-amerykański film science fiction, pierwszy z trylogii filmowej o tej samej nazwie, napisany i wyreżyserowany przez Larry’ego i Andy’ego Wachowskich. Treść filmu zawiera ukryte przesłania i aluzje, ukazujące topos życia-snu", 27);
            products[1] = new ProductDescription("Iron Man III", "Iron Man jest superbohaterem, który walczy ze zbrodnią za pomocą skonstruowanych przez siebie serii cybernetycznych zbroi, wyposażonych w najnowocześniejsze technologie[1]. Jako Tony Stark prowadzi życie bogatego przedsiębiorcy i filantropa, kierującego konglomeratem Stark Industries[2]. Jest członkiem elitarnej grupy superherosów o nazwie Avengers[1].", 42);
            products[2] = new ProductDescription("Star Wars V", "seria filmów fantastycznych z gatunku space opera (science fantasy) George’a Lucasa oraz innych produktów związanych ze światem stworzonym w filmie: wydawnictw literackich, komiksów, gier fabularnych, gier komputerowych itp",  59);

            foreach (ProductDescription singleProduct in products)
                comboBoxProductName.Items.Add(singleProduct.name);

            
        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxDescription.Text = products[comboBoxProductName.SelectedIndex].description;
            textBoxSinglePrice.Text = (products[comboBoxProductName.SelectedIndex].price).ToString();
            string nameOfProduct = comboBoxProductName.Text;

            switch (nameOfProduct)
            {
                case "Iron Man III":
                    pictureBoxProductImage.Image = Properties.Resources.ironman;
                    break;
                case "Matrix I":
                    pictureBoxProductImage.Image = Properties.Resources.matrix;
                    break;
                case "Star Wars V":
                    pictureBoxProductImage.Image = Properties.Resources.starwars;
                    break;
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            labelCartInfo.Visible = true;
            labelCartPriceInfo.Visible = true;
            products[comboBoxProductName.SelectedIndex].orderQuantity++;
            labelCartInfoText.Text += products[comboBoxProductName.SelectedIndex].name + " - " + products[comboBoxProductName.SelectedIndex].price +" PLN"+ Environment.NewLine;
            priceInTotal+=products[comboBoxProductName.SelectedIndex].price;
            labelCartPriceValue.Text = priceInTotal.ToString();
        }

        private void buttonGeneratePDF_Click(object sender, EventArgs e)
        {
            Document documentInvoice = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(documentInvoice, new FileStream("Rachunek.pdf", FileMode.Create));
            documentInvoice.Open(); // opens document to write
            //Write some content
            documentInvoice.AddAuthor("Sklep u Janusza  Sp. z o.o.");
            
            
            Paragraph firstHeader = new Paragraph("Rachunek\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22));
            firstHeader.Alignment = Element.ALIGN_CENTER;
            documentInvoice.Add(firstHeader);
            documentInvoice.Add(new Phrase(Environment.NewLine));

            PdfPTable table = new PdfPTable(2); // We ake for table with two columns
            table.AddCell("Nazwa produktu");
            table.AddCell("Cena");
            for (int productID = 0 ; productID < products.Count() ; productID++)
            {
                if (products[productID].orderQuantity > 0)
                {
                    table.AddCell(products[productID].orderQuantity + "szt.  " + products[productID].name);
                    table.AddCell(products[productID].orderQuantity + " * " + products[productID].price + " PLN = " + products[productID].orderQuantity * products[productID].price + " PLN");
                }
            }

            documentInvoice.Add(table);

            
            // Now I add the above created text using different class object to our pdf document
            documentInvoice.Add(new Paragraph("Dziekujemy za zakupy w naszym sklepie."));
            documentInvoice.Close();
            MessageBox.Show("Zapisano do Rachunek.pdf");
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }







    }
}
