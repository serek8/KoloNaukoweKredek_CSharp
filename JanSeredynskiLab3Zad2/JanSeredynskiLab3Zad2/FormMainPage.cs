using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanSeredynskiLab3Zad2
{
    public partial class FormMainPage : Form
    {
        int userID;
        string userName;
        Label[] labelPosts;

        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        public FormMainPage(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            sqlConnection = new SqlConnection("Data Source=localhost;database=MiniFacebook;Trusted_Connection=yes");
        }

        /// <summary>
        /// Łącze z bazą danych oraz wypisuje naze zalogowanego uzytkownika
        /// </summary>
        private void FormMainPage_Load(object sender, EventArgs e)
        {
            sqlDataAdapter = new SqlDataAdapter
                ("select Name from [User] where ID = "+userID, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            userName = dataTable.Rows[0][0].ToString();

            this.labelUserName.Text = userName;
            loadWall();  
        }
        /// <summary>
        /// Wpisuje nowy status do bazy danych a nastepnie odświerzam panelPost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPost_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("Insert into [Post] (UserID, Text) values ("+userID+", '"+ textBoxPost.Text+"')");
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            loadWall();
        }
        /// <summary>
        /// Sprawdzam w bazie danych czy ktoś dodał nowy wpis a następnie wypisuje go na panelPost
        /// </summary>
        private void loadWall()
        {
            sqlDataAdapter = new SqlDataAdapter("select * from [UserPost] order by PostID desc", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nie ma zadnych aktualnosci");
                return;
            }
           if(labelPosts != null) for(int i=0; i<labelPosts.Count(); i++) this.panelPost.Controls.Remove(labelPosts[i]);
           labelPosts = new Label[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                labelPosts[i] = new Label();
                labelPosts[i].Location = new Point(40, 70 * i + 10);
                labelPosts[i].Width = 200;
                labelPosts[i].Height = 40;
                labelPosts[i].Text = dataTable.Rows[i][1].ToString() + " napisał(ła):" + Environment.NewLine +
                                    " -> " + dataTable.Rows[i][0].ToString();
                labelPosts[i].Tag = i;
                this.panelPost.Controls.Add(labelPosts[i]);
                
            }
            panelPost.Refresh();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadWall();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            (new FormUniversalDataViewer("UserGroupMember")).Show();
        }

        private void buttonAllPosts_Click(object sender, EventArgs e)
        {
            (new FormUniversalDataViewer("UserPostComment")).Show();
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            (new FormUniversalDataViewer("EventMemberUserName")).Show();
        }

        private void buttonFriendhips_Click(object sender, EventArgs e)
        {
            (new FormUniversalDataViewer("UserFriendship")).Show();
        }

    }
}
