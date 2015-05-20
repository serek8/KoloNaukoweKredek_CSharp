namespace JanSeredynskiLab3Zad2
{
    partial class FormLogIn
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
            this.labellabelAccountPassword = new System.Windows.Forms.Label();
            this.labelSignUpQuestion = new System.Windows.Forms.Label();
            this.textBoxAccountMail = new System.Windows.Forms.TextBox();
            this.textBoxAccountPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelSingUp = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAccountMail
            // 
            this.labelAccountMail.AutoSize = true;
            this.labelAccountMail.Location = new System.Drawing.Point(47, 96);
            this.labelAccountMail.Name = "labelAccountMail";
            this.labelAccountMail.Size = new System.Drawing.Size(61, 13);
            this.labelAccountMail.TabIndex = 1;
            this.labelAccountMail.Text = "Adres email";
            // 
            // labellabelAccountPassword
            // 
            this.labellabelAccountPassword.AutoSize = true;
            this.labellabelAccountPassword.Location = new System.Drawing.Point(47, 149);
            this.labellabelAccountPassword.Name = "labellabelAccountPassword";
            this.labellabelAccountPassword.Size = new System.Drawing.Size(36, 13);
            this.labellabelAccountPassword.TabIndex = 2;
            this.labellabelAccountPassword.Text = "Hasło";
            // 
            // labelSignUpQuestion
            // 
            this.labelSignUpQuestion.AutoSize = true;
            this.labelSignUpQuestion.Location = new System.Drawing.Point(47, 257);
            this.labelSignUpQuestion.Name = "labelSignUpQuestion";
            this.labelSignUpQuestion.Size = new System.Drawing.Size(127, 13);
            this.labelSignUpQuestion.TabIndex = 3;
            this.labelSignUpQuestion.Text = "Nie masz jeszcze konta ?";
            // 
            // textBoxAccountMail
            // 
            this.textBoxAccountMail.Location = new System.Drawing.Point(114, 93);
            this.textBoxAccountMail.Name = "textBoxAccountMail";
            this.textBoxAccountMail.Size = new System.Drawing.Size(129, 20);
            this.textBoxAccountMail.TabIndex = 4;
            // 
            // textBoxAccountPassword
            // 
            this.textBoxAccountPassword.Location = new System.Drawing.Point(114, 149);
            this.textBoxAccountPassword.Name = "textBoxAccountPassword";
            this.textBoxAccountPassword.PasswordChar = '*';
            this.textBoxAccountPassword.Size = new System.Drawing.Size(129, 20);
            this.textBoxAccountPassword.TabIndex = 5;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(50, 191);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(193, 34);
            this.buttonLogIn.TabIndex = 6;
            this.buttonLogIn.Text = "Zaloguj";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelSingUp
            // 
            this.labelSingUp.AutoSize = true;
            this.labelSingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSingUp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSingUp.Location = new System.Drawing.Point(180, 256);
            this.labelSingUp.Name = "labelSingUp";
            this.labelSingUp.Size = new System.Drawing.Size(62, 14);
            this.labelSingUp.TabIndex = 7;
            this.labelSingUp.Text = "Rejestracja";
            this.labelSingUp.Click += new System.EventHandler(this.labelSingUp_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::JanSeredynskiLab3Zad2.Properties.Resources.Untitled;
            this.pictureBoxLogo.Location = new System.Drawing.Point(93, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(128, 45);
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 323);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelSingUp);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxAccountPassword);
            this.Controls.Add(this.textBoxAccountMail);
            this.Controls.Add(this.labelSignUpQuestion);
            this.Controls.Add(this.labellabelAccountPassword);
            this.Controls.Add(this.labelAccountMail);
            this.Name = "FormLogIn";
            this.Text = "Logowanie do Fejsbuka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccountMail;
        private System.Windows.Forms.Label labellabelAccountPassword;
        private System.Windows.Forms.Label labelSignUpQuestion;
        private System.Windows.Forms.TextBox textBoxAccountMail;
        private System.Windows.Forms.TextBox textBoxAccountPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelSingUp;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

