namespace JanSeredynskiLab2.View
{
    partial class FormChart
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
            this.pictureBoxChartSupplyAndAmount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChartSupplyAndAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChartSupplyAndAmount
            // 
            this.pictureBoxChartSupplyAndAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxChartSupplyAndAmount.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxChartSupplyAndAmount.Name = "pictureBoxChartSupplyAndAmount";
            this.pictureBoxChartSupplyAndAmount.Size = new System.Drawing.Size(578, 358);
            this.pictureBoxChartSupplyAndAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxChartSupplyAndAmount.TabIndex = 0;
            this.pictureBoxChartSupplyAndAmount.TabStop = false;
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 359);
            this.Controls.Add(this.pictureBoxChartSupplyAndAmount);
            this.Name = "FormChart";
            this.Text = "FormChart";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChartSupplyAndAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxChartSupplyAndAmount;
    }
}