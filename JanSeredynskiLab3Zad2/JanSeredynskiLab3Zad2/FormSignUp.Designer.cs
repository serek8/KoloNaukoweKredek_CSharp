namespace JanSeredynskiLab3Zad2
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
            this.labelAccountMail = new System.Windows.Forms.Label();
            this.labelAccountPassword = new System.Windows.Forms.Label();
            this.labelSignUpTitle = new System.Windows.Forms.Label();
            this.textBoxAccountMail = new System.Windows.Forms.TextBox();
            this.textBoxAccountPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAccountMail
            // 
            this.labelAccountMail.AutoSize = true;
            this.labelAccountMail.Location = new System.Drawing.Point(31, 133);
            this.labelAccountMail.Name = "labelAccountMail";
            this.labelAccountMail.Size = new System.Drawing.Size(61, 13);
            this.labelAccountMail.TabIndex = 0;
            this.labelAccountMail.Text = "Adres email";
            // 
            // labelAccountPassword
            // 
            this.labelAccountPassword.AutoSize = true;
            this.labelAccountPassword.Location = new System.Drawing.Point(31, 161);
            this.labelAccountPassword.Name = "labelAccountPassword";
            this.labelAccountPassword.Size = new System.Drawing.Size(36, 13);
            this.labelAccountPassword.TabIndex = 1;
            this.labelAccountPassword.Text = "Hasło";
            // 
            // labelSignUpTitle
            // 
            this.labelSignUpTitle.AutoSize = true;
            this.labelSignUpTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpTitle.Location = new System.Drawing.Point(69, 33);
            this.labelSignUpTitle.Name = "labelSignUpTitle";
            this.labelSignUpTitle.Size = new System.Drawing.Size(104, 26);
            this.labelSignUpTitle.TabIndex = 2;
            this.labelSignUpTitle.Text = "Rejestracja";
            // 
            // textBoxAccountMail
            // 
            this.textBoxAccountMail.Location = new System.Drawing.Point(112, 130);
            this.textBoxAccountMail.Name = "textBoxAccountMail";
            this.textBoxAccountMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountMail.TabIndex = 3;
            // 
            // textBoxAccountPassword
            // 
            this.textBoxAccountPassword.Location = new System.Drawing.Point(112, 158);
            this.textBoxAccountPassword.Name = "textBoxAccountPassword";
            this.textBoxAccountPassword.PasswordChar = '*';
            this.textBoxAccountPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountPassword.TabIndex = 4;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(34, 208);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(164, 32);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Utwórz konto";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(31, 103);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(78, 13);
            this.labelAccountName.TabIndex = 6;
            this.labelAccountName.Text = "Imie i nazwisko";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(112, 100);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountName.TabIndex = 7;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 252);
            this.Controls.Add(this.textBoxAccountName);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxAccountPassword);
            this.Controls.Add(this.textBoxAccountMail);
            this.Controls.Add(this.labelSignUpTitle);
            this.Controls.Add(this.labelAccountPassword);
            this.Controls.Add(this.labelAccountMail);
            this.Name = "FormSignUp";
            this.Text = "Rejestracja konta - Fejsbuk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccountMail;
        private System.Windows.Forms.Label labelAccountPassword;
        private System.Windows.Forms.Label labelSignUpTitle;
        private System.Windows.Forms.TextBox textBoxAccountMail;
        private System.Windows.Forms.TextBox textBoxAccountPassword;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.TextBox textBoxAccountName;
    }
}