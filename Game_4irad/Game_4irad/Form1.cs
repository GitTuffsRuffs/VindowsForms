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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Enter Name
            //Log in to that player
            //Show player name in this box

            //Show activ games in game box.
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
            //Turn off game.
            Environment.Exit(1);
        }

        private void logOutPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Log out acctiv player
            //Clear bord of info of previus player.
        }

        private void Game_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show games of the acctiv player
            //Click a game to change acctiv game.

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
            //Bout the Game.
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Show helpfull information how to play.
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //??
        }

        private void funInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Show some fun info.

            Games played in total:
            Games won:
            Games lost:

            Avredgs win rate?
            Total play time of all games?
            */
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
