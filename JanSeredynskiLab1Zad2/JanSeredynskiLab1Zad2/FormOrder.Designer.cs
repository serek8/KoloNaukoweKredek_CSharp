namespace JanSeredynskiLab1Zad2
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelSinglePrice = new System.Windows.Forms.Label();
            this.textBoxSinglePrice = new System.Windows.Forms.TextBox();
            this.labelMainHeader = new System.Windows.Forms.Label();
            this.labelCartInfo = new System.Windows.Forms.Label();
            this.labelCartInfoText = new System.Windows.Forms.Label();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCartPriceInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCartPriceValue = new System.Windows.Forms.Label();
            this.buttonGeneratePDF = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(194, 70);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(145, 21);
            this.comboBoxProductName.TabIndex = 0;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(75, 70);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(85, 13);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Nazwa produktu";
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Location = new System.Drawing.Point(75, 136);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(28, 13);
            this.labelProductDescription.TabIndex = 2;
            this.labelProductDescription.Text = "Opis";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(194, 133);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(145, 178);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // labelSinglePrice
            // 
            this.labelSinglePrice.AutoSize = true;
            this.labelSinglePrice.Location = new System.Drawing.Point(75, 332);
            this.labelSinglePrice.Name = "labelSinglePrice";
            this.labelSinglePrice.Size = new System.Drawing.Size(32, 13);
            this.labelSinglePrice.TabIndex = 4;
            this.labelSinglePrice.Text = "Cena";
            // 
            // textBoxSinglePrice
            // 
            this.textBoxSinglePrice.Location = new System.Drawing.Point(194, 332);
            this.textBoxSinglePrice.Name = "textBoxSinglePrice";
            this.textBoxSinglePrice.ReadOnly = true;
            this.textBoxSinglePrice.Size = new System.Drawing.Size(145, 20);
            this.textBoxSinglePrice.TabIndex = 5;
            // 
            // labelMainHeader
            // 
            this.labelMainHeader.AutoSize = true;
            this.labelMainHeader.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelMainHeader.Location = new System.Drawing.Point(170, 9);
            this.labelMainHeader.Name = "labelMainHeader";
            this.labelMainHeader.Size = new System.Drawing.Size(342, 26);
            this.labelMainHeader.TabIndex = 7;
            this.labelMainHeader.Text = "Sklep multimedialny - handel płyt DVD";
            // 
            // labelCartInfo
            // 
            this.labelCartInfo.AutoSize = true;
            this.labelCartInfo.Location = new System.Drawing.Point(383, 389);
            this.labelCartInfo.Name = "labelCartInfo";
            this.labelCartInfo.Size = new System.Drawing.Size(69, 13);
            this.labelCartInfo.TabIndex = 9;
            this.labelCartInfo.Text = "Twój koszyk:";
            this.labelCartInfo.Visible = false;
            // 
            // labelCartInfoText
            // 
            this.labelCartInfoText.Location = new System.Drawing.Point(471, 389);
            this.labelCartInfoText.Name = "labelCartInfoText";
            this.labelCartInfoText.Size = new System.Drawing.Size(156, 108);
            this.labelCartInfoText.TabIndex = 10;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Image = global::JanSeredynskiLab1Zad2.Properties.Resources.przycisk_dodaj_do_koszyka;
            this.buttonAddToCart.Location = new System.Drawing.Point(77, 426);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(150, 23);
            this.buttonAddToCart.TabIndex = 8;
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProductImage.Image = global::JanSeredynskiLab1Zad2.Properties.Resources.sklep;
            this.pictureBoxProductImage.InitialImage = null;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(386, 70);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(260, 282);
            this.pictureBoxProductImage.TabIndex = 6;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // labelCartPriceInfo
            // 
            this.labelCartPriceInfo.AutoSize = true;
            this.labelCartPriceInfo.Location = new System.Drawing.Point(383, 524);
            this.labelCartPriceInfo.Name = "labelCartPriceInfo";
            this.labelCartPriceInfo.Size = new System.Drawing.Size(112, 13);
            this.labelCartPriceInfo.TabIndex = 11;
            this.labelCartPriceInfo.Text = "Podsumowanie (PLN):";
            this.labelCartPriceInfo.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // labelCartPriceValue
            // 
            this.labelCartPriceValue.AutoSize = true;
            this.labelCartPriceValue.Location = new System.Drawing.Point(553, 524);
            this.labelCartPriceValue.Name = "labelCartPriceValue";
            this.labelCartPriceValue.Size = new System.Drawing.Size(0, 13);
            this.labelCartPriceValue.TabIndex = 13;
            // 
            // buttonGeneratePDF
            // 
            this.buttonGeneratePDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGeneratePDF.Location = new System.Drawing.Point(78, 472);
            this.buttonGeneratePDF.Name = "buttonGeneratePDF";
            this.buttonGeneratePDF.Size = new System.Drawing.Size(149, 25);
            this.buttonGeneratePDF.TabIndex = 14;
            this.buttonGeneratePDF.Text = "Generuj PDF";
            this.buttonGeneratePDF.UseVisualStyleBackColor = true;
            this.buttonGeneratePDF.Click += new System.EventHandler(this.buttonGeneratePDF_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(78, 518);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 25);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Zakoncz zakupy";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 572);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGeneratePDF);
            this.Controls.Add(this.labelCartPriceValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCartPriceInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCartInfoText);
            this.Controls.Add(this.labelCartInfo);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.labelMainHeader);
            this.Controls.Add(this.pictureBoxProductImage);
            this.Controls.Add(this.textBoxSinglePrice);
            this.Controls.Add(this.labelSinglePrice);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelProductDescription);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.comboBoxProductName);
            this.Name = "FormOrder";
            this.Text = "Zamówienia - JanSeredynskiLab1Zad2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelSinglePrice;
        private System.Windows.Forms.TextBox textBoxSinglePrice;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Label labelMainHeader;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelCartInfo;
        private System.Windows.Forms.Label labelCartInfoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCartPriceInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCartPriceValue;
        private System.Windows.Forms.Button buttonGeneratePDF;
        private System.Windows.Forms.Button buttonExit;
    }
}

