namespace JanSeredynskiLab4Zad2
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
            this.labelLogIn = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNewAccountInfo = new System.Windows.Forms.Label();
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.Location = new System.Drawing.Point(94, 31);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(106, 26);
            this.labelLogIn.TabIndex = 0;
            this.labelLogIn.Text = "Logowanie";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nazwa użytkownika";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(37, 135);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Hasło";
            // 
            // labelNewAccountInfo
            // 
            this.labelNewAccountInfo.AutoSize = true;
            this.labelNewAccountInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNewAccountInfo.Location = new System.Drawing.Point(164, 180);
            this.labelNewAccountInfo.Name = "labelNewAccountInfo";
            this.labelNewAccountInfo.Size = new System.Drawing.Size(89, 13);
            this.labelNewAccountInfo.TabIndex = 3;
            this.labelNewAccountInfo.Text = "Nie masz konta ?";
            // 
            // labelCreateNewAccount
            // 
            this.labelCreateNewAccount.AutoSize = true;
            this.labelCreateNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewAccount.ForeColor = System.Drawing.Color.Teal;
            this.labelCreateNewAccount.Location = new System.Drawing.Point(164, 193);
            this.labelCreateNewAccount.Name = "labelCreateNewAccount";
            this.labelCreateNewAccount.Size = new System.Drawing.Size(74, 16);
            this.labelCreateNewAccount.TabIndex = 4;
            this.labelCreateNewAccount.Text = "Załóż je !";
            this.labelCreateNewAccount.Click += new System.EventHandler(this.labelCreateNewAccount_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(99, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(167, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(99, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(40, 180);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(99, 29);
            this.buttonLogIn.TabIndex = 7;
            this.buttonLogIn.Text = "Zaloguj";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 264);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCreateNewAccount);
            this.Controls.Add(this.labelNewAccountInfo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLogIn);
            this.Name = "FormLogIn";
            this.Text = "Pokomon Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelNewAccountInfo;
        private System.Windows.Forms.Label labelCreateNewAccount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
    }
}

