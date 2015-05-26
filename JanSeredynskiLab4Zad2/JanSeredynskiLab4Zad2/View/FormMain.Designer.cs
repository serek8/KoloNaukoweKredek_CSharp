namespace JanSeredynskiLab4Zad2.View
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelPointsValue = new System.Windows.Forms.Label();
            this.labelMoneyValue = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonBuyPokemon = new System.Windows.Forms.Button();
            this.buttonYourPokemon = new System.Windows.Forms.Button();
            this.buttonFightArena = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelShowMyPokemons = new System.Windows.Forms.Panel();
            this.dataGridViewUniversal = new System.Windows.Forms.DataGridView();
            this.panelBuyPokemon = new System.Windows.Forms.Panel();
            this.buttonBuyUnit = new System.Windows.Forms.Button();
            this.comboBoxBuyPokemon = new System.Windows.Forms.ComboBox();
            this.panelArena = new System.Windows.Forms.Panel();
            this.labelOpponentName = new System.Windows.Forms.Label();
            this.comboBoxOpponentName = new System.Windows.Forms.ComboBox();
            this.labelFightInstruction = new System.Windows.Forms.Label();
            this.buttonStartFight = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPokemonToFight3 = new System.Windows.Forms.ComboBox();
            this.comboBoxPokemonToFight2 = new System.Windows.Forms.ComboBox();
            this.comboBoxPokemonToFight1 = new System.Windows.Forms.ComboBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelNotifications = new System.Windows.Forms.Label();
            this.panelNotifications = new System.Windows.Forms.Panel();
            this.labelPokemonInfo = new System.Windows.Forms.Label();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.panelShowMyPokemons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversal)).BeginInit();
            this.panelBuyPokemon.SuspendLayout();
            this.panelArena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(477, 15);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(136, 19);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Nazwa Użytkownika";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(477, 42);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(44, 15);
            this.labelPoints.TabIndex = 1;
            this.labelPoints.Text = "Punkty";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(478, 66);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(47, 15);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "Portfel:";
            // 
            // labelPointsValue
            // 
            this.labelPointsValue.AutoSize = true;
            this.labelPointsValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointsValue.Location = new System.Drawing.Point(541, 40);
            this.labelPointsValue.Name = "labelPointsValue";
            this.labelPointsValue.Size = new System.Drawing.Size(14, 15);
            this.labelPointsValue.TabIndex = 3;
            this.labelPointsValue.Text = "0";
            // 
            // labelMoneyValue
            // 
            this.labelMoneyValue.AutoSize = true;
            this.labelMoneyValue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoneyValue.Location = new System.Drawing.Point(541, 66);
            this.labelMoneyValue.Name = "labelMoneyValue";
            this.labelMoneyValue.Size = new System.Drawing.Size(14, 15);
            this.labelMoneyValue.TabIndex = 4;
            this.labelMoneyValue.Text = "0";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(6, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(57, 23);
            this.labelMenu.TabIndex = 5;
            this.labelMenu.Text = "Akcje:";
            // 
            // buttonBuyPokemon
            // 
            this.buttonBuyPokemon.Location = new System.Drawing.Point(10, 66);
            this.buttonBuyPokemon.Name = "buttonBuyPokemon";
            this.buttonBuyPokemon.Size = new System.Drawing.Size(101, 25);
            this.buttonBuyPokemon.TabIndex = 6;
            this.buttonBuyPokemon.Text = "Kup Pokemona";
            this.buttonBuyPokemon.UseVisualStyleBackColor = true;
            this.buttonBuyPokemon.Click += new System.EventHandler(this.buttonBuyPokemon_Click);
            // 
            // buttonYourPokemon
            // 
            this.buttonYourPokemon.Location = new System.Drawing.Point(10, 97);
            this.buttonYourPokemon.Name = "buttonYourPokemon";
            this.buttonYourPokemon.Size = new System.Drawing.Size(101, 25);
            this.buttonYourPokemon.TabIndex = 7;
            this.buttonYourPokemon.Text = "Twoje Pokemony";
            this.buttonYourPokemon.UseVisualStyleBackColor = true;
            this.buttonYourPokemon.Click += new System.EventHandler(this.buttonYourPokemon_Click);
            // 
            // buttonFightArena
            // 
            this.buttonFightArena.Location = new System.Drawing.Point(10, 128);
            this.buttonFightArena.Name = "buttonFightArena";
            this.buttonFightArena.Size = new System.Drawing.Size(101, 25);
            this.buttonFightArena.TabIndex = 8;
            this.buttonFightArena.Text = "Arena Walk";
            this.buttonFightArena.UseVisualStyleBackColor = true;
            this.buttonFightArena.Click += new System.EventHandler(this.buttonFightArena_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(10, 35);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(101, 25);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Odświerz";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelShowMyPokemons
            // 
            this.panelShowMyPokemons.Controls.Add(this.dataGridViewUniversal);
            this.panelShowMyPokemons.Location = new System.Drawing.Point(131, 28);
            this.panelShowMyPokemons.Name = "panelShowMyPokemons";
            this.panelShowMyPokemons.Size = new System.Drawing.Size(308, 306);
            this.panelShowMyPokemons.TabIndex = 12;
            this.panelShowMyPokemons.Visible = false;
            // 
            // dataGridViewUniversal
            // 
            this.dataGridViewUniversal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUniversal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUniversal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUniversal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUniversal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUniversal.Name = "dataGridViewUniversal";
            this.dataGridViewUniversal.Size = new System.Drawing.Size(308, 306);
            this.dataGridViewUniversal.TabIndex = 0;
            // 
            // panelBuyPokemon
            // 
            this.panelBuyPokemon.Controls.Add(this.labelPokemonInfo);
            this.panelBuyPokemon.Controls.Add(this.pictureBoxPokemon);
            this.panelBuyPokemon.Controls.Add(this.buttonBuyUnit);
            this.panelBuyPokemon.Controls.Add(this.comboBoxBuyPokemon);
            this.panelBuyPokemon.Location = new System.Drawing.Point(131, 27);
            this.panelBuyPokemon.Name = "panelBuyPokemon";
            this.panelBuyPokemon.Size = new System.Drawing.Size(308, 307);
            this.panelBuyPokemon.TabIndex = 13;
            this.panelBuyPokemon.Visible = false;
            // 
            // buttonBuyUnit
            // 
            this.buttonBuyUnit.Location = new System.Drawing.Point(189, 51);
            this.buttonBuyUnit.Name = "buttonBuyUnit";
            this.buttonBuyUnit.Size = new System.Drawing.Size(107, 25);
            this.buttonBuyUnit.TabIndex = 1;
            this.buttonBuyUnit.Text = "Kup";
            this.buttonBuyUnit.UseVisualStyleBackColor = true;
            this.buttonBuyUnit.Click += new System.EventHandler(this.buttonBuyUnit_Click);
            // 
            // comboBoxBuyPokemon
            // 
            this.comboBoxBuyPokemon.FormattingEnabled = true;
            this.comboBoxBuyPokemon.Location = new System.Drawing.Point(3, 54);
            this.comboBoxBuyPokemon.Name = "comboBoxBuyPokemon";
            this.comboBoxBuyPokemon.Size = new System.Drawing.Size(149, 21);
            this.comboBoxBuyPokemon.TabIndex = 0;
            this.comboBoxBuyPokemon.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuyPokemon_SelectedIndexChanged);
            // 
            // panelArena
            // 
            this.panelArena.Controls.Add(this.labelOpponentName);
            this.panelArena.Controls.Add(this.comboBoxOpponentName);
            this.panelArena.Controls.Add(this.labelFightInstruction);
            this.panelArena.Controls.Add(this.buttonStartFight);
            this.panelArena.Controls.Add(this.label3);
            this.panelArena.Controls.Add(this.label2);
            this.panelArena.Controls.Add(this.label1);
            this.panelArena.Controls.Add(this.comboBoxPokemonToFight3);
            this.panelArena.Controls.Add(this.comboBoxPokemonToFight2);
            this.panelArena.Controls.Add(this.comboBoxPokemonToFight1);
            this.panelArena.Location = new System.Drawing.Point(130, 26);
            this.panelArena.Name = "panelArena";
            this.panelArena.Size = new System.Drawing.Size(309, 308);
            this.panelArena.TabIndex = 14;
            this.panelArena.Visible = false;
            // 
            // labelOpponentName
            // 
            this.labelOpponentName.AutoSize = true;
            this.labelOpponentName.Location = new System.Drawing.Point(27, 19);
            this.labelOpponentName.Name = "labelOpponentName";
            this.labelOpponentName.Size = new System.Drawing.Size(141, 13);
            this.labelOpponentName.TabIndex = 11;
            this.labelOpponentName.Text = "Wybierz osobę do wyzwania";
            // 
            // comboBoxOpponentName
            // 
            this.comboBoxOpponentName.FormattingEnabled = true;
            this.comboBoxOpponentName.Location = new System.Drawing.Point(172, 16);
            this.comboBoxOpponentName.Name = "comboBoxOpponentName";
            this.comboBoxOpponentName.Size = new System.Drawing.Size(114, 21);
            this.comboBoxOpponentName.TabIndex = 10;
            // 
            // labelFightInstruction
            // 
            this.labelFightInstruction.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFightInstruction.Location = new System.Drawing.Point(43, 61);
            this.labelFightInstruction.Name = "labelFightInstruction";
            this.labelFightInstruction.Size = new System.Drawing.Size(238, 37);
            this.labelFightInstruction.TabIndex = 9;
            this.labelFightInstruction.Text = "Wyznacz 3 pokemony, które podejmą walkę pod Twoim imieniem.";
            // 
            // buttonStartFight
            // 
            this.buttonStartFight.Location = new System.Drawing.Point(74, 241);
            this.buttonStartFight.Name = "buttonStartFight";
            this.buttonStartFight.Size = new System.Drawing.Size(151, 38);
            this.buttonStartFight.TabIndex = 8;
            this.buttonStartFight.Text = "Walcz";
            this.buttonStartFight.UseVisualStyleBackColor = true;
            this.buttonStartFight.Click += new System.EventHandler(this.buttonStartFight_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "3. Pokemon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "2. Pokemon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 Pokemon";
            // 
            // comboBoxPokemonToFight3
            // 
            this.comboBoxPokemonToFight3.FormattingEnabled = true;
            this.comboBoxPokemonToFight3.Location = new System.Drawing.Point(111, 192);
            this.comboBoxPokemonToFight3.Name = "comboBoxPokemonToFight3";
            this.comboBoxPokemonToFight3.Size = new System.Drawing.Size(114, 21);
            this.comboBoxPokemonToFight3.TabIndex = 4;
            // 
            // comboBoxPokemonToFight2
            // 
            this.comboBoxPokemonToFight2.FormattingEnabled = true;
            this.comboBoxPokemonToFight2.Location = new System.Drawing.Point(111, 153);
            this.comboBoxPokemonToFight2.Name = "comboBoxPokemonToFight2";
            this.comboBoxPokemonToFight2.Size = new System.Drawing.Size(114, 21);
            this.comboBoxPokemonToFight2.TabIndex = 3;
            // 
            // comboBoxPokemonToFight1
            // 
            this.comboBoxPokemonToFight1.FormattingEnabled = true;
            this.comboBoxPokemonToFight1.Location = new System.Drawing.Point(111, 115);
            this.comboBoxPokemonToFight1.Name = "comboBoxPokemonToFight1";
            this.comboBoxPokemonToFight1.Size = new System.Drawing.Size(114, 21);
            this.comboBoxPokemonToFight1.TabIndex = 2;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(10, 159);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(101, 26);
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelNotifications
            // 
            this.labelNotifications.AutoSize = true;
            this.labelNotifications.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelNotifications.Location = new System.Drawing.Point(487, 109);
            this.labelNotifications.Name = "labelNotifications";
            this.labelNotifications.Size = new System.Drawing.Size(93, 15);
            this.labelNotifications.TabIndex = 16;
            this.labelNotifications.Text = "Powiadomienia";
            // 
            // panelNotifications
            // 
            this.panelNotifications.AutoScroll = true;
            this.panelNotifications.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelNotifications.Location = new System.Drawing.Point(459, 128);
            this.panelNotifications.Name = "panelNotifications";
            this.panelNotifications.Size = new System.Drawing.Size(157, 203);
            this.panelNotifications.TabIndex = 17;
            // 
            // labelPokemonInfo
            // 
            this.labelPokemonInfo.Location = new System.Drawing.Point(171, 113);
            this.labelPokemonInfo.Name = "labelPokemonInfo";
            this.labelPokemonInfo.Size = new System.Drawing.Size(134, 153);
            this.labelPokemonInfo.TabIndex = 3;
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Location = new System.Drawing.Point(2, 116);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemon.TabIndex = 2;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 358);
            this.Controls.Add(this.panelBuyPokemon);
            this.Controls.Add(this.panelShowMyPokemons);
            this.Controls.Add(this.panelNotifications);
            this.Controls.Add(this.labelNotifications);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.panelArena);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonFightArena);
            this.Controls.Add(this.buttonYourPokemon);
            this.Controls.Add(this.buttonBuyPokemon);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.labelMoneyValue);
            this.Controls.Add(this.labelPointsValue);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelUserName);
            this.Name = "FormMain";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelShowMyPokemons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversal)).EndInit();
            this.panelBuyPokemon.ResumeLayout(false);
            this.panelArena.ResumeLayout(false);
            this.panelArena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelPointsValue;
        private System.Windows.Forms.Label labelMoneyValue;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonBuyPokemon;
        private System.Windows.Forms.Button buttonYourPokemon;
        private System.Windows.Forms.Button buttonFightArena;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panelShowMyPokemons;
        private System.Windows.Forms.DataGridView dataGridViewUniversal;
        private System.Windows.Forms.Panel panelBuyPokemon;
        private System.Windows.Forms.Panel panelArena;
        private System.Windows.Forms.Label labelFightInstruction;
        private System.Windows.Forms.Button buttonStartFight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPokemonToFight3;
        private System.Windows.Forms.ComboBox comboBoxPokemonToFight2;
        private System.Windows.Forms.ComboBox comboBoxPokemonToFight1;
        private System.Windows.Forms.ComboBox comboBoxBuyPokemon;
        private System.Windows.Forms.Button buttonBuyUnit;
        private System.Windows.Forms.Label labelOpponentName;
        private System.Windows.Forms.ComboBox comboBoxOpponentName;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelNotifications;
        private System.Windows.Forms.Panel panelNotifications;
        private System.Windows.Forms.Label labelPokemonInfo;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
    }
}