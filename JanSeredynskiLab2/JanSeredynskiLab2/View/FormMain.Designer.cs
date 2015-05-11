namespace JanSeredynskiLab2
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelRegisterNumber = new System.Windows.Forms.Label();
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxRegisterNumber = new System.Windows.Forms.TextBox();
            this.textBoxSupply = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.dataGridViewArrivals = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportToPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGenerateChart = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.buttonGenerateChart = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivals)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(26, 30);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(99, 44);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nowy przyjazd";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelRegisterNumber
            // 
            this.labelRegisterNumber.AutoSize = true;
            this.labelRegisterNumber.Location = new System.Drawing.Point(194, 30);
            this.labelRegisterNumber.Name = "labelRegisterNumber";
            this.labelRegisterNumber.Size = new System.Drawing.Size(32, 13);
            this.labelRegisterNumber.TabIndex = 1;
            this.labelRegisterNumber.Text = "Nr rej";
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(309, 30);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(37, 13);
            this.labelSupply.TabIndex = 2;
            this.labelSupply.Text = "Towar";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(442, 30);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(29, 13);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Ilość";
            // 
            // textBoxRegisterNumber
            // 
            this.textBoxRegisterNumber.Location = new System.Drawing.Point(161, 54);
            this.textBoxRegisterNumber.Name = "textBoxRegisterNumber";
            this.textBoxRegisterNumber.Size = new System.Drawing.Size(92, 20);
            this.textBoxRegisterNumber.TabIndex = 4;
            this.textBoxRegisterNumber.Text = "DLE995";
            // 
            // textBoxSupply
            // 
            this.textBoxSupply.Location = new System.Drawing.Point(283, 54);
            this.textBoxSupply.Name = "textBoxSupply";
            this.textBoxSupply.Size = new System.Drawing.Size(95, 20);
            this.textBoxSupply.TabIndex = 5;
            this.textBoxSupply.Text = "komputery";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(412, 54);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(90, 20);
            this.textBoxAmount.TabIndex = 6;
            this.textBoxAmount.Text = "10";
            // 
            // dataGridViewArrivals
            // 
            this.dataGridViewArrivals.AllowUserToAddRows = false;
            this.dataGridViewArrivals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArrivals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrivals.Location = new System.Drawing.Point(26, 124);
            this.dataGridViewArrivals.Name = "dataGridViewArrivals";
            this.dataGridViewArrivals.Size = new System.Drawing.Size(476, 139);
            this.dataGridViewArrivals.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.ToolStripMenuItemTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenFile,
            this.toolStripMenuItemSaveFile,
            this.toolStripMenuItemSaveFileAs,
            this.toolStripMenuItemExport});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItemFile.Text = "Plik";
            // 
            // toolStripMenuItemOpenFile
            // 
            this.toolStripMenuItemOpenFile.Name = "toolStripMenuItemOpenFile";
            this.toolStripMenuItemOpenFile.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemOpenFile.Text = "Otwórz plik...";
            this.toolStripMenuItemOpenFile.Click += new System.EventHandler(this.toolStripMenuItemOpenFile_Click);
            // 
            // toolStripMenuItemSaveFile
            // 
            this.toolStripMenuItemSaveFile.Name = "toolStripMenuItemSaveFile";
            this.toolStripMenuItemSaveFile.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemSaveFile.Text = "Zapisz";
            this.toolStripMenuItemSaveFile.Click += new System.EventHandler(this.toolStripMenuItemSaveFile_Click);
            // 
            // toolStripMenuItemSaveFileAs
            // 
            this.toolStripMenuItemSaveFileAs.Name = "toolStripMenuItemSaveFileAs";
            this.toolStripMenuItemSaveFileAs.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemSaveFileAs.Text = "Zapisz jako...";
            this.toolStripMenuItemSaveFileAs.Click += new System.EventHandler(this.ToolStripMenuItemSaveFileAs_Click);
            // 
            // toolStripMenuItemExport
            // 
            this.toolStripMenuItemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportToExcel,
            this.toolStripMenuItemExportToPDF});
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemExport.Text = "Ekspotuj...";
            // 
            // toolStripMenuItemExportToExcel
            // 
            this.toolStripMenuItemExportToExcel.Name = "toolStripMenuItemExportToExcel";
            this.toolStripMenuItemExportToExcel.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemExportToExcel.Text = "Excel";
            this.toolStripMenuItemExportToExcel.Click += new System.EventHandler(this.toolStripMenuItemExportToExcel_Click);
            // 
            // toolStripMenuItemExportToPDF
            // 
            this.toolStripMenuItemExportToPDF.Name = "toolStripMenuItemExportToPDF";
            this.toolStripMenuItemExportToPDF.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemExportToPDF.Text = "PDF";
            this.toolStripMenuItemExportToPDF.Click += new System.EventHandler(this.toolStripMenuItemExportToPDF_Click);
            // 
            // ToolStripMenuItemTools
            // 
            this.ToolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGenerateChart});
            this.ToolStripMenuItemTools.Name = "ToolStripMenuItemTools";
            this.ToolStripMenuItemTools.Size = new System.Drawing.Size(70, 20);
            this.ToolStripMenuItemTools.Text = "Narzędzia";
            // 
            // ToolStripMenuItemGenerateChart
            // 
            this.ToolStripMenuItemGenerateChart.Name = "ToolStripMenuItemGenerateChart";
            this.ToolStripMenuItemGenerateChart.Size = new System.Drawing.Size(170, 22);
            this.ToolStripMenuItemGenerateChart.Text = "Wygeneruj wykres";
            this.ToolStripMenuItemGenerateChart.Click += new System.EventHandler(this.ToolStripMenuItemGenerateChart_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(95, 284);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(92, 20);
            this.textBoxFind.TabIndex = 11;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFind.Location = new System.Drawing.Point(23, 284);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(66, 16);
            this.labelFind.TabIndex = 16;
            this.labelFind.Text = "Wyszukaj";
            // 
            // buttonGenerateChart
            // 
            this.buttonGenerateChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGenerateChart.Location = new System.Drawing.Point(414, 284);
            this.buttonGenerateChart.Name = "buttonGenerateChart";
            this.buttonGenerateChart.Size = new System.Drawing.Size(88, 29);
            this.buttonGenerateChart.TabIndex = 17;
            this.buttonGenerateChart.Text = "Generuj wykres";
            this.buttonGenerateChart.UseVisualStyleBackColor = false;
            this.buttonGenerateChart.Click += new System.EventHandler(this.buttonGenerateChart_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabelMain.Text = "Gotowy do pracy";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 351);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonGenerateChart);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.dataGridViewArrivals);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxSupply);
            this.Controls.Add(this.textBoxRegisterNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.labelRegisterNumber);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Rejestr przyjazdów";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivals)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelRegisterNumber;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxRegisterNumber;
        private System.Windows.Forms.TextBox textBoxSupply;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.DataGridView dataGridViewArrivals;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveFileAs;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Button buttonGenerateChart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportToExcel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportToPDF;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGenerateChart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
    }
}

