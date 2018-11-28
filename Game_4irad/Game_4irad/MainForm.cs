using FirApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_4irad
{
    public partial class MainForm : Form
    {
        PlayerToken player_token;
        Api game_api = new Api();

        int game_Id;
        bool activPlayer;
        string player2_id;

        List<Game> player_games;
        List<List<PictureBox>> pawnGrid = new List<List<PictureBox>>();

        //Konstruktor
        public MainForm(PlayerToken temp_player_token)
        {
            InitializeComponent();

            //Set box till player name.
            player_token = temp_player_token;
            txt_player_name.Text = player_token.Player.User_Name;
        }

        //Uppdated game things every 5sec
        private async void WindowUppdater(){
            while (true)
            {
                var u = UppdateGameList();
                var f = FetchAndUppdateBord();
                await Task.Delay(5000);
            }
        }
        private void Form1Load(object sender, EventArgs e)
        {
            Task task = UppdateGameList();

            float deltaX = (pawn_bot.Left-pawn_top.Left)/6;
            float deltaY = (pawn_bot.Top-pawn_top.Top)/5;

            //Make gridd
            for (int y = 0; y < 6; y++)
            {
                var row = new List<PictureBox>();

                for (int x = 0; x < 7; x++)
                {
                    PictureBox cell = new PictureBox();
                    cell.Location = new Point ((int)(pawn_top.Left + deltaX*x), (int)(pawn_top.Top + deltaY*y));
                    cell.Width = pawn_top.Width;
                    cell.Height = pawn_top.Height;
                    cell.Image = Properties.Resources.Bg;
                    cell.Visible = true;
                    int x2 = x;
                    int y2 = 5 - y;
                    cell.Click += new EventHandler((a,b) => pawnClick(x2,y2));                                       
                    GamePanel.Controls.Add(cell);
                    row.Add(cell);
                }

                pawnGrid.Add(row);
            }

            //Start auto uppdate.
            WindowUppdater();
        }
   
        public async Task FetchAndUppdateBord()
        {
            if (game_Id < 1)
            {
                panel2.Visible = false;
                return;
            }
            //MessageBox.Show(list_games.SelectedItem.ToString());
            //Get game object for celected game.
            Game game1 = await game_api.game(game_Id);
            UppdateBord(game1);
        }
        public async void UppdateBord(Game game1){
            //Game visible
            panel2.Visible = true;

            //Set Game name.
            string game_name = game1.Game_ID + "";
            Game_titel.Text = "Game: " + game_name;

            //Set activ acction.
            int player_turn = 0;

            switch (game1.Status)
            {
                case Game.STATUS_TIE:
                    Info_Lable.Text = "Game wase a tie.";
                    break;

                case Game.STATUS_WAITFORP1:
                    player_turn = 1;
                    Info_Lable.Text = "Waiting on " + game1.Player1;
                    break;
                case Game.STATUS_WAITFORP2:
                    player_turn = 2;
                    Info_Lable.Text = "Waiting on " + game1.Player2;
                    break;
                case Game.STATUS_WONBYP1:
                    Info_Lable.Text = "Game won by: " + game1.Player1;
                    break;
                case Game.STATUS_WONBYP2:
                    Info_Lable.Text = "Game won by: " + game1.Player2;
                    break;

                default:
                    Info_Lable.Text = "Loading...";
                    break;
            }

            //Set Opponents name.
            if (game1.Player1_ID == player_token.Player_ID)
            {
                player2_id = game1.Player2;
                activPlayer = (player_turn == 1);
            }
            else
            {
                player2_id = game1.Player1;
                activPlayer = (player_turn == 2);
            }
            Opponent_lable.Text = player2_id;

            //textDebugg.Clear();
            List<List<int>> brickPlacement = await game_api.grid(game_Id);


            for (int i = 0; i < 6; i++)
            {
                //string textRow = "";
                int y = 5 - i;

                for (int j = 0; j < 7; j++)
                {
                    //textRow = textRow + brickPlacement[i][j] + " ";
                    int x = j;

                    switch (brickPlacement[i][j])
                    {
                        case 1:
                            pawnGrid[y][x].Image = Properties.Resources.Player1;
                            break;

                        case 2:
                            pawnGrid[y][x].Image = Properties.Resources.Player2;
                            break;

                        default:
                            pawnGrid[y][x].Image = Properties.Resources.Bg;
                            break;
                    }
                }
                //textDebugg.Text = textRow + " \r\n" + textDebugg.Text;
            }

            //Change BG_YELLOW if your turn.
            //Cange BG_GREEN if game hase ended (save ended games for 5min)
            //Change BG_READ if oponent have not made a move in 3 days - Aouto win. (game end)
        }
        private async Task UppdateGameList()
        {
            player_games = await game_api.games(player_token.Player_ID);

            for(int k = player_games.Count-1; k >= 0; k--)
            {
                switch(player_games[k].Status)
                {
                    case Game.STATUS_WONBYP1:
                    case Game.STATUS_WONBYP2:
                    case Game.STATUS_TIE:

                        player_games.RemoveAt(k);
                        break;
                }
            }

            //Uppdate the box.
            list_games.Items.Clear();

            foreach(Game game in player_games) { 
                //Game1: Tuffs vs Puggan
                list_games.Items.Add(game.Game_ID +": "+ game.Player1 +" vs "+ game.Player2);
            }
        }
        private async void AcctivGameSelected(object sender, EventArgs e)
        {
            int index = list_games.SelectedIndex;
            Game game;

            try
            {
                game = player_games[index];
                //Click a game to change acctiv game.
            }
            catch (Exception)
            {
                panel2.Visible = false;
                game_Id = 0;
                return;
            }

            game_Id = game.Game_ID;
            await FetchAndUppdateBord();
        }

        public async void pawnClick(int x, int y)
        {
            try
            {
                Game gameBordstate = await game_api.play(player_token.Token, game_Id, x, y);
                UppdateBord(gameBordstate);
            }
            catch (NoResultException) //Api fel
            {
                MessageBox.Show("Acction not valid.");
            }
            catch (Exception){
                MessageBox.Show("An error has occurred.");
            } //Andra fel
        }

        private async void MenueNewGameChalange(object sender, EventArgs e)
        {
            String name = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the player you want to challenge:");

            if (name.Length <= 0) {
                return;
            }

            try {
                Game newGameChallange = await game_api.startGame(player_token.Token, name);
                game_Id = newGameChallange.Game_ID;
                UppdateBord(newGameChallange);
                await UppdateGameList();
            }
            catch (NoResultException)
            {
                MessageBox.Show("Opponent not found.");
            }
            catch(Exception)
            {
                MessageBox.Show("An error has occurred.");
            }
        }
        private async void MenueNewGameRandomChalange(object sender, EventArgs e)
        {
            try { 
                Game NewRandomChalange = await game_api.randomGame(player_token.Token);
                game_Id = NewRandomChalange.Game_ID;
                UppdateBord(NewRandomChalange);
                await UppdateGameList();
            }
            catch (NoResultException)
            {
                MessageBox.Show("You have been added to the queue.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred.");
            }
        }
        private void MenueExitProgram(object sender, EventArgs e)
        {
            //Turn off Program.
            Environment.Exit(1);
        }

        private void MenueFunInfo(object sender, EventArgs e)
        {
            //Open the fun window
            // Create a new instance of the Form2 class
            Info settingsForm = new Info();
            // Show the settings form
            settingsForm.Show();
        }
        private void MenueLogOut(object sender, EventArgs e)
        {
            //Log out acctiv player
            txt_player_name.ReadOnly = false;

            //Empty the Player text box
            //Empty game list
            //Clear bord of info of previus player.
        }

        private void MenueAboutProgram(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Info settingsForm = new Info();
            // Show the settings form
            settingsForm.Show();
        }
        private void MenueHelpProgram(object sender, EventArgs e)
        {
            //Show helpfull information how to play.
            // Create a new instance of the Form2 class
            Info settingsForm = new Info();
            // Show the settings form
            settingsForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
