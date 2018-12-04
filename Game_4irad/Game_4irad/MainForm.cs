using FirApi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_4irad
{
    public partial class MainForm : Form
    {
        //Sparar personen som är inloggad
        PlayerToken player_token;

        //Ny api för att koma åt Api.cs
        Api game_api = new Api();

        //ID numnet av valda spelet.
        int game_Id;

        //Kontrollera om Login Forum är open
        bool Login_open = false;

        //Listor för games av inloggad spelare.
        List<Game> player_games_acctiv;
        List<Game> player_games_done;

        //Listan med alla brikor i.
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
        private async void WindowUppdater()
        {

            //Körs till progamets stängs av.
            while (true)
            {
                //Uppdate Players game lists
                var u = UppdateGameList();
                //Uppdate players game bord
                var f = FetchAndUppdateBord();
                //Wait a little (millisec)
                await Task.Delay(5000);
            }
        }

        //When Forum is created.
        private void Form1Load(object sender, EventArgs e)
        {
            //Uppdate Game list (No wait)
            Task task = UppdateGameList();

            //Avstånd mellan brickor
            float deltaX = (pawn_bot.Left-pawn_top.Left)/6;
            float deltaY = (pawn_bot.Top-pawn_top.Top)/5;

            //Make gridd, Rader
            for (int y = 0; y < 6; y++)
            {
                //TOM Lista: med platser för pictursBox, för varje rad.
                var row = new List<PictureBox>();

                //MAke gridd, Colums
                for (int x = 0; x < 7; x++)
                {
                    //Skapa bricka.
                    PictureBox cell = new PictureBox();
                    cell.Width = pawn_top.Width;
                    cell.Height = pawn_top.Height;
                    cell.Image = Properties.Resources.Bg;
                    cell.Visible = true;

                    //Calculate boxPathern baset on box Pickturs from desice Window
                    cell.Location = new Point ((int)(pawn_top.Left + deltaX*x), (int)(pawn_top.Top + deltaY*y));

                    //Converterar våra cordinater till API cordinater
                    int x2 = x;
                    int y2 = 5 - y;

                    //Vid click, kör pawnklick med API cordinater
                    cell.Click += new EventHandler((a,b) => pawnClick(x2,y2));

                    //Lägger till brickan på skärmen
                    GamePanel.Controls.Add(cell);

                    //Läg till Brickan på raden
                    row.Add(cell);
                }
                //Lägger till hela raden    
                pawnGrid.Add(row);
            }

            //Start auto uppdate.
            WindowUppdater();
        }
   
        //Uppdate bord whit selected game.
        public async Task FetchAndUppdateBord()
        {
            //Om inget spel är markerat, göm spelbrädet.
            if (game_Id < 1)
            {
                panel2.Visible = false;
                return;
            }

            //Uppdatera valt spel hämtat från API, till spelpan.
            try
            {
                Game game1 = await game_api.game(game_Id);
                UppdateBord(game1);
            }
            catch (Exception) {
                MessageBox.Show("ERROR 404: Game not found.");
            }
        }

        //Uppdatera spelpan med speldata
        public async void UppdateBord(Game game1){
            //Game visible
            panel2.Visible = true;

            //Set titlar till namn, spelare och motståndare
            LableYou.Text = game1.Player1;
            Opponent_lable.Text = game1.Player2;

            //Game time, start och last chang in game.
            labelGameTime.Text = game1.Start_Time;
            lableChangeTime.Text = game1.Changed_Time;

            //Set Game name.
            string game_name = game1.Game_ID + "";
            Game_titel.Text = "Game: " + game_name;

            //Uppdate vems tur det är text, och indicatorer.
            switch (game1.Status)
            {
                case Game.STATUS_TIE:
                    Info_Lable.Text = "Game wase a tie.";
                    break;

                case Game.STATUS_WAITFORP1:
                    Info_Lable.Text = "Waiting on " + game1.Player1;
                    turnInicator1.Visible = false;
                    turnInicator2.Visible = true;
                    break;
                case Game.STATUS_WAITFORP2:
                    Info_Lable.Text = "Waiting on " + game1.Player2;
                    turnInicator1.Visible = true;
                    turnInicator2.Visible = false;
                    break;
                case Game.STATUS_WONBYP1:
                    Info_Lable.Text = "Game won by: " + game1.Player1;
                    turnInicator1.Visible = false;
                    turnInicator2.Visible = false;
                    break;
                case Game.STATUS_WONBYP2:
                    Info_Lable.Text = "Game won by: " + game1.Player2;
                    turnInicator1.Visible = false;
                    turnInicator2.Visible = false;
                    break;

                default:
                    Info_Lable.Text = "Loading...";
                    break;
            }

            //Hämtar brickor.
            List<List<int>> brickPlacement = await game_api.grid(game_Id);

            //Brick rader.
            for (int i = 0; i < 6; i++)
            {
                //Vänder spelplan rätt håll, (uppoch ner)
                int y = 5 - i;

                //Brick columner.
                for (int j = 0; j < 7; j++)
                {
                    int x = j;

                    //Målar ut rätt färg bricka.
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
            }
        }

        //Uppdaterar Spelarens acctiva spel lista och historik lista, håller också koll på statestic.
        private async Task UppdateGameList()
        {
            int gameWon = 0;
            int gameTotal;

            //All games:
            List<Game> player_games = await game_api.games(player_token.Player_ID);
            //Tomma listor att fylla.
            player_games_acctiv = new List<Game>();
            player_games_done = new List<Game>();

            //Sort games to Acctiv and Done
            for(int k = 0; k < player_games.Count; k++)
            {
                switch(player_games[k].Status)
                {
                    case Game.STATUS_WONBYP1:
                    case Game.STATUS_WONBYP2:
                    case Game.STATUS_TIE:

                        player_games_done.Add(player_games[k]);
                        break;

                    case Game.STATUS_WAITFORP1:
                    case Game.STATUS_WAITFORP2:

                        player_games_acctiv.Add(player_games[k]);
                        break;
                }
            }

            //Uppdate the Activ box
            list_games.Items.Clear();

            foreach(Game game in player_games_acctiv) { 
                //Exemple: Game2: Tuffs vs Puggan
                list_games.Items.Add(game.Game_ID +": "+ game.Player1 +" vs "+ game.Player2);

                if(game.Status == Game.STATUS_WAITFORP1){
                    if (game.Player1_ID == player_token.Player_ID)
                    {
                        //Game BG Yellow
                        list_games.Items[list_games.Items.Count-1].BackColor = Color.Yellow;
                    }
                }
            }

            //Uppdate the History box
            list_history.Items.Clear();

            foreach (Game game in player_games_done)
            {
                list_history.Items.Add(game.Game_ID + ": " + game.Player1 + " vs " + game.Player2);

                //Set BG Rad or green, depending if you won or lost that game.
                if (game.Status == Game.STATUS_WONBYP1)
                {
                    if (game.Player1_ID == player_token.Player_ID)
                    {
                        list_history.Items[list_history.Items.Count - 1].BackColor = Color.Green;
                        gameWon++;
                    }
                    else
                    {
                        list_history.Items[list_history.Items.Count - 1].BackColor = Color.Red;
                    }
                }
                else if (game.Status == Game.STATUS_WONBYP2)
                {
                    if (game.Player1_ID == player_token.Player_ID)
                    {
                        list_history.Items[list_history.Items.Count - 1].BackColor = Color.Red;
                    }
                    else
                    {
                        list_history.Items[list_history.Items.Count - 1].BackColor = Color.Green;
                        gameWon++;
                    }
                }
                else
                {
                    list_history.Items[list_history.Items.Count - 1].BackColor = Color.White;
                }
            }

            //Statestic
            //Keeps track of all games you ended.
            gameTotal = player_games_done.Count;

            //Writes ut some statistic, on win rate and total games.
            if (gameTotal == 0)
            {
                lableFun.Text = "Statistic\n \nGames Won: 0/0\nGame Win Rate: 50%";
            }
            else
            {
                int procentWon = 100 * gameWon / gameTotal;
                lableFun.Text = "Statistic\n \nGames Won: " + gameWon + "/" + gameTotal + "\nGame Win Rate: " + procentWon + "%";
            }
        }

        //When selecting acctiv game, set game to select and call uppdateBord.
        private async void AcctivGameSelected(object sender, EventArgs e)
        {
            if (list_games.SelectedItems.Count < 1)
            {
                return;
            }

            int index = list_games.Items.IndexOf(list_games.SelectedItems[0]);
            Game game;

            try
            {
                game = player_games_acctiv[index];
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

        //When selcted done game, set game to slecet and call uppdateBord.
        private async void HistoryGameSelected(object sender, EventArgs e)
        {
            if (list_history.SelectedItems.Count < 1)
            {
                return;
            }

            int index = list_history.Items.IndexOf(list_history.SelectedItems[0]);
            Game game;

            try
            {
                game = player_games_done[index];
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

        //When placing a new pawn.
        public async void pawnClick(int x, int y)
        {
            //Sickar brick placeringen till API, om du inte får spela där, gnäller API:t.
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

        //MENU__Callange a new player throw input username.
        private async void MenueNewGameChalange(object sender, EventArgs e)
        {
            //Visa en VisualBasic ruta, med text, title, och knappar.
            String name = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the player you want to challenge:","Connect four!");

            //om inget username anges, avslut.
            if (name.Length <= 0) {
                return;
            }

            //Försök skapa ett nytt spel mot angiven spelare.
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

        //MENU__Utmana spelare genom att joina kö.
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

        //MENU__Exit progam
        private void MenueExitProgram(object sender, EventArgs e)
        {
            //Turn off Program.
            Environment.Exit(1);
        }

        //MENU__Loggar ut spelare och visar loginrutan.
        private void MenueLogOut(object sender, EventArgs e)
        {
            txt_player_name.ReadOnly = false;
            Form Login = new LogIn();
            Login.Show();
            Login_open = true;
            this.Close();            
        }

        //MENU__Show about the application
        private void MenueAboutProgram(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Info settingsForm = new Info();
            // Show the settings form
            settingsForm.Show();
        }

        //MENU__Show Help window
        private void MenueHelpProgram(object sender, EventArgs e)
        {
            Help settingsForm = new Help();
            settingsForm.Show();
        }

        //Setting for when Form is closing.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Login_open == false)
            {
                Environment.Exit(0);
            }
        }
    }
}
