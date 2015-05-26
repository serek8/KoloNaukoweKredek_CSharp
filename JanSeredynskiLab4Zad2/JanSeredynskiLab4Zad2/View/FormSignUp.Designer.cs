namespace JanSeredynskiLab4Zad2.View
{
    partial class FormSignUp
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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(31, 190);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(226, 29);
            this.buttonSignUp.TabIndex = 15;
            this.buttonSignUp.Text = "Załóż konto";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(158, 142);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(99, 20);
            this.textBoxPassword.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(158, 106);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(99, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(28, 145);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Hasło";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 109);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Nazwa użytkownika";
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.Location = new System.Drawing.Point(85, 41);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(107, 26);
            this.labelSignUp.TabIndex = 8;
            this.labelSignUp.Text = "Rejestracja";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSignUp);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSignUp;
    }
}