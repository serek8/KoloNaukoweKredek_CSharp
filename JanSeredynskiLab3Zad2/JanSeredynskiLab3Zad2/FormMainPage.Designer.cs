namespace JanSeredynskiLab3Zad2
{
    partial class FormMainPage
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelPost = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonAllPosts = new System.Windows.Forms.Button();
            this.buttonEvent = new System.Windows.Forms.Button();
            this.buttonFriendhips = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 20);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(75, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "ImieINazwisko";
            // 
            // textBoxPost
            // 
            this.textBoxPost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPost.Location = new System.Drawing.Point(142, 110);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(320, 41);
            this.textBoxPost.TabIndex = 6;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(387, 157);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Opublikuj";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(408, 20);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(54, 23);
            this.buttonLogOut.TabIndex = 9;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelPost
            // 
            this.panelPost.AutoScroll = true;
            this.panelPost.Location = new System.Drawing.Point(142, 197);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(320, 226);
            this.panelPost.TabIndex = 10;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(139, 82);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 13);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Dodaj status";
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(12, 98);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonGroup.TabIndex = 13;
            this.buttonGroup.Text = "Grupy";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(12, 80);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(39, 15);
            this.labelMenu.TabIndex = 14;
            this.labelMenu.Text = "Menu";
            // 
            // buttonAllPosts
            // 
            this.buttonAllPosts.Location = new System.Drawing.Point(12, 127);
            this.buttonAllPosts.Name = "buttonAllPosts";
            this.buttonAllPosts.Size = new System.Drawing.Size(75, 23);
            this.buttonAllPosts.TabIndex = 15;
            this.buttonAllPosts.Text = "Posty";
            this.buttonAllPosts.UseVisualStyleBackColor = true;
            this.buttonAllPosts.Click += new System.EventHandler(this.buttonAllPosts_Click);
            // 
            // buttonEvent
            // 
            this.buttonEvent.Location = new System.Drawing.Point(12, 156);
            this.buttonEvent.Name = "buttonEvent";
            this.buttonEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonEvent.TabIndex = 16;
            this.buttonEvent.Text = "Wydarzenia";
            this.buttonEvent.UseVisualStyleBackColor = true;
            this.buttonEvent.Click += new System.EventHandler(this.buttonEvent_Click);
            // 
            // buttonFriendhips
            // 
            this.buttonFriendhips.Location = new System.Drawing.Point(12, 185);
            this.buttonFriendhips.Name = "buttonFriendhips";
            this.buttonFriendhips.Size = new System.Drawing.Size(75, 23);
            this.buttonFriendhips.TabIndex = 17;
            this.buttonFriendhips.Text = "Znajomi";
            this.buttonFriendhips.UseVisualStyleBackColor = true;
            this.buttonFriendhips.Click += new System.EventHandler(this.buttonFriendhips_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JanSeredynskiLab3Zad2.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(189, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFriendhips);
            this.Controls.Add(this.buttonEvent);
            this.Controls.Add(this.buttonAllPosts);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panelPost);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelUserName);
            this.Name = "FormMainPage";
            this.Text = "Strona główna";
            this.Load += new System.EventHandler(this.FormMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonAllPosts;
        private System.Windows.Forms.Button buttonEvent;
        private System.Windows.Forms.Button buttonFriendhips;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}