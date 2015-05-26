using JanSeredynskiLab4Zad2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab4Zad2.View
{
    public partial class FormMain : Form
    {
        int userID;
        DataClassesGamePokemonDataContext dataContext;
        public FormMain(int userID)
        {
            InitializeComponent();
            dataContext = new DataClassesGamePokemonDataContext();
            this.userID = userID;
        }
        /// <summary>
        /// Po zaladowaniu strony pokaż użytkownika i odświerz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            labelUserName.Text =  Model.User.getStatusByID(userID).Name;
            
            refresh();

        }
        #region Panel - pokemony użytkownika
        /// <summary>
        /// Wyswietla panel z datagridview wlasnych pokemonow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonYourPokemon_Click(object sender, EventArgs e)
        {
            dataGridViewUniversal.DataSource = Model.Pokemon.getMyPokemonList(userID);
            dataGridViewUniversal.Columns.Remove("UserID");
            panelBuyPokemon.Visible = false;
            panelArena.Visible = false;
            panelShowMyPokemons.Visible = true;
            refresh();
        }
        #endregion
        #region Panel zakupu pokemonów
        private void comboBoxBuyPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Resources.ResourceManager resourceManager =
                            JanSeredynskiLab4Zad2.Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)resourceManager.GetObject(comboBoxBuyPokemon.Text);
            pictureBoxPokemon.Image = myImage;
            labelPokemonInfo.Text = "Atak: " + Model.Pokemon.getInfoByName(comboBoxBuyPokemon.Text).DamageRate +
                                    "\nHP: " + Model.Pokemon.getInfoByName(comboBoxBuyPokemon.Text).HitPoint +
                                    "\nKoszt: " + Model.Pokemon.getInfoByName(comboBoxBuyPokemon.Text).Cost +
                                    "\nTyp: " + Model.Pokemon.getInfoByName(comboBoxBuyPokemon.Text).PokemonTypeName;
        }

        /// <summary>
        /// Wyswietla panel do zakupu pokemonow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPokemon_Click(object sender, EventArgs e)
        {
            panelArena.Visible = false;
            panelShowMyPokemons.Visible = false;
            panelBuyPokemon.Visible = true;
            refresh();
        }
        #endregion
        #region Panel - Arena Walk
        /// <summary>
        /// Klawisz rozpoczynający walke i wyliczanie obrażen LUB wysyla wyzwanie do walki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartFight_Click(object sender, EventArgs e)
        {
            if (comboBoxPokemonToFight1.Text == comboBoxPokemonToFight2.Text ||
                comboBoxPokemonToFight1.Text == comboBoxPokemonToFight3.Text ||
                comboBoxPokemonToFight3.Text == comboBoxPokemonToFight2.Text)
            {
                MessageBox.Show("Nie możesz użyć tych samych pokemonów w jednej walce !");
                return;
            }
            MessageBox.Show(
                Model.Pokemon.fight(
                    userID,
                    Model.User.getIDByName(comboBoxOpponentName.Text),
                    Model.Pokemon.getIDByName(comboBoxPokemonToFight1.Text),
                    Model.Pokemon.getIDByName(comboBoxPokemonToFight2.Text),
                    Model.Pokemon.getIDByName(comboBoxPokemonToFight3.Text))
                            );

        }
        /// <summary>
        /// Wyswietla panel do walki z innymi graczami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFightArena_Click(object sender, EventArgs e)
        {
            panelShowMyPokemons.Visible = false;
            panelBuyPokemon.Visible = false;
            panelArena.Visible = true;
            refresh();
        }
        #endregion
        #region Panel Kupowanie pokemonów
        /// <summary>
        /// Kupuje koknretnego pokemona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyUnit_Click(object sender, EventArgs e)
        {
            if (Model.Pokemon.buyPokemon(comboBoxBuyPokemon.Text, userID) == -1)
                MessageBox.Show("Nie stać Cię na tego pokemona");
            else MessageBox.Show("Pokemon został kupiony ;-)");
        }
        #endregion
        #region Odświerzanie
        /// <summary>
        /// Po naciesnieciu klawisza osdswierz, osweirzam panele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        /// <summary>
        /// Odświerz panele
        /// </summary>
        void refresh()
        {
            comboBoxOpponentName.Items.Clear();
            comboBoxPokemonToFight1.Items.Clear();
            comboBoxPokemonToFight2.Items.Clear();
            comboBoxPokemonToFight3.Items.Clear();
            comboBoxBuyPokemon.Items.Clear();
            
            labelMoneyValue.Text = Model.User.getStatusByID(userID).Money.ToString();
            for (int i = 0; i < Model.Pokemon.getMyPokemonList(userID).Count(); i++)
            {
                comboBoxPokemonToFight1.Items.Add(Model.Pokemon.getPokemonList()[i].Name);
                comboBoxPokemonToFight2.Items.Add(Model.Pokemon.getPokemonList()[i].Name);
                comboBoxPokemonToFight3.Items.Add(Model.Pokemon.getPokemonList()[i].Name);
            }
            for (int i = 0; i < Model.User.getUserListToFight(userID).Count(); i++)
            {
                comboBoxOpponentName.Items.Add(Model.User.getUserListToFight(userID)[i]);
            }
            for (int i = 0; i < Model.Pokemon.getPokemonList().Count(); i++)
            {
                comboBoxBuyPokemon.Items.Add(Model.Pokemon.getPokemonList()[i].Name);
            }


            //powiadomienia
            if (Model.Pokemon.getNotification(userID) != null)
            {
                panelNotifications.Controls.Clear();
                Label[] labelPosts = new Label[Model.Pokemon.getNotification(userID).Count];
                var notification = Model.Pokemon.getNotification(userID);
                for (int i = 0; i < Model.Pokemon.getNotification(userID).Count; i++)
                {
                    labelPosts[i] = new Label();
                    labelPosts[i].Location = new Point(5, 40 * i + 10);
                    labelPosts[i].Width = 200;
                    labelPosts[i].Height = 40;
                    labelPosts[i].Text = notification[i] + "\n";
                    labelPosts[i].Tag = i;
                    this.panelNotifications.Controls.Add(labelPosts[i]);

                }
            }
        }
        #endregion
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
