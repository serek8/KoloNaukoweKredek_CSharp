namespace JanSeredynskiLab4
{
    partial class FormMain
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
            this.dataGridViewContent = new System.Windows.Forms.DataGridView();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelCustomerCompany = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCompany = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowOrders = new System.Windows.Forms.Button();
            this.buttonGetByName = new System.Windows.Forms.Button();
            this.textBoxGetByName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContent
            // 
            this.dataGridViewContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContent.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewContent.Name = "dataGridViewContent";
            this.dataGridViewContent.Size = new System.Drawing.Size(518, 268);
            this.dataGridViewContent.TabIndex = 0;
            // 
            // buttonGet
            // 
            this.buttonGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGet.Location = new System.Drawing.Point(12, 286);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 1;
            this.buttonGet.Text = "Pobierz";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdate.Location = new System.Drawing.Point(93, 286);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Uaktualnij";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(174, 286);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(551, 24);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(47, 13);
            this.labelCustomerID.TabIndex = 4;
            this.labelCustomerID.Text = "Klient ID";
            // 
            // labelCustomerCompany
            // 
            this.labelCustomerCompany.AutoSize = true;
            this.labelCustomerCompany.Location = new System.Drawing.Point(551, 61);
            this.labelCustomerCompany.Name = "labelCustomerCompany";
            this.labelCustomerCompany.Size = new System.Drawing.Size(32, 13);
            this.labelCustomerCompany.TabIndex = 5;
            this.labelCustomerCompany.Text = "Firma";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(614, 21);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 6;
            // 
            // textBoxCustomerCompany
            // 
            this.textBoxCustomerCompany.Location = new System.Drawing.Point(614, 61);
            this.textBoxCustomerCompany.Name = "textBoxCustomerCompany";
            this.textBoxCustomerCompany.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerCompany.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(255, 286);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowOrders
            // 
            this.buttonShowOrders.Location = new System.Drawing.Point(336, 286);
            this.buttonShowOrders.Name = "buttonShowOrders";
            this.buttonShowOrders.Size = new System.Drawing.Size(118, 23);
            this.buttonShowOrders.TabIndex = 9;
            this.buttonShowOrders.Text = "Wyświetl zamówienia";
            this.buttonShowOrders.UseVisualStyleBackColor = true;
            this.buttonShowOrders.Click += new System.EventHandler(this.buttonShowOrders_Click);
            // 
            // buttonGetByName
            // 
            this.buttonGetByName.Location = new System.Drawing.Point(600, 257);
            this.buttonGetByName.Name = "buttonGetByName";
            this.buttonGetByName.Size = new System.Drawing.Size(179, 23);
            this.buttonGetByName.TabIndex = 10;
            this.buttonGetByName.Text = "Filtruj zamowienia wg nazwy";
            this.buttonGetByName.UseVisualStyleBackColor = true;
            this.buttonGetByName.Click += new System.EventHandler(this.buttonGetByName_Click);
            // 
            // textBoxGetByName
            // 
            this.textBoxGetByName.Location = new System.Drawing.Point(600, 289);
            this.textBoxGetByName.Name = "textBoxGetByName";
            this.textBoxGetByName.Size = new System.Drawing.Size(179, 20);
            this.textBoxGetByName.TabIndex = 11;
            this.textBoxGetByName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 321);
            this.Controls.Add(this.textBoxGetByName);
            this.Controls.Add(this.buttonGetByName);
            this.Controls.Add(this.buttonShowOrders);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxCustomerCompany);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelCustomerCompany);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.dataGridViewContent);
            this.Name = "FormMain";
            this.Text = "Baza danych";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContent;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelCustomerCompany;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerCompany;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShowOrders;
        private System.Windows.Forms.Button buttonGetByName;
        private System.Windows.Forms.TextBox textBoxGetByName;
    }
}

