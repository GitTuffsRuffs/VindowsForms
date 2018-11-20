using FirApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_4irad
{
    public partial class MainForm : Form
    {
        //I dono how to link thes XD FIX LATER!
        PlayerToken player_token;
        Api game_api = new Api();

        bool activPlayer;
        int gamesList_int;

        //List of players
        List<string> playerNames = new List<string>();
        List<string> gameList = new List<string>();

        public MainForm(PlayerToken temp_player_token)
        {
            InitializeComponent();

            //Set box till player name.
            player_token = temp_player_token;
            txt_player_name.Text = player_token.Player.User_Name;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uppdate_Game_listAsync();
        }

        private async Task Uppdate_Game_listAsync()
        {
            List<Game> get_player_games = await game_api.games(player_token.Player_ID);

            //Uppdate the box.
            list_games.Items.Clear();

            foreach(Game game in get_player_games) { 
                list_games.Items.Add(game.Game_ID);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ////Cheek if player name alredy exist?

            ////Get list from DATABASE

            ////IF True - Load player
            ////IF False - Add player to list

            //bool exist = playerNames.Contains(player1_ID);
            //if (exist)
            //{
            //    //Logg in to player.
            //    activPlayer = true;

            //    //Set text in box to player name?
            //    txt_player_name.Text += "" + player1_ID;

            //    //Get players game acctiv list
            //    var gameList = "XXX"; //Game list from server
            //                          //Make List? Array?
            
            //    gamesList_int = gameList.Length;
                
            //    //Show game list.
            //    if (gamesList_int > 0) {

            //        for (int i = gamesList_int; i < gamesList_int; i++)
                                             
            //        //Show acctiv games in list
            //        list_games.Text = Convert.ToString(gameList[i]);
            //    }
            //}
            //else
            //{
            //    //Creat new player
            //    //creat a new player.
            //    //Show player name in this box
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Show the game of the acctiv game
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //Show the acctiv picture for move
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Turn off Program.
            Environment.Exit(1);
        }

        private void logOutPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Log out acctiv player
            txt_player_name.ReadOnly = false;

            //Empty the Player text box
            //Empty game list
            //Clear bord of info of previus player.
        }

        private void Game_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Click a game to change acctiv game.
            int game_Id = Int32.Parse(list_games.SelectedItem.ToString());
            //MessageBox.Show(list_games.SelectedItem.ToString());
            panel2.Visible = true;

            //Change BG_YELLOW if your turn.
            //Cange BG_GREEN if game hase ended (save ended games for 5min)
            //Change BG_READ if oponent have not made a move in 3 days - Aouto win. (game end)
        }

        private void Info_Lable_Click(object sender, EventArgs e)
        {
            //Show whos turn it it.
            //Show if game is ended and who one.
            //Set so game can not continue, players can not play more moved.
        }

        private void Opponent_lable_Click(object sender, EventArgs e)
        {
            //Show player name of your opponent

            //Get player name from Game database.
            //Show name of player.
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            //Box for holdin the Game Bord boxes.
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Box for holding the player settings.
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Box for holding the Game settings.
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //Box for holding the entier game.
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Start a new game agenst a player.
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Info settingsForm = new Info();
            // Show the settings form
            settingsForm.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Show helpfull information how to play.
            // Create a new instance of the Form2 class
            Info settingsForm = new Info();
            // Show the settings form
            settingsForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //??
        }

        private void funInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the fun window
            // Create a new instance of the Form2 class
            Info settingsForm = new Info();
            // Show the settings form
            settingsForm.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
