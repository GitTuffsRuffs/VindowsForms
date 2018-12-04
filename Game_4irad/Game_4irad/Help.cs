using System;
using System.Windows.Forms;

namespace Game_4irad
{
    public partial class Help : Form
    {
        //Konstruktor
        public Help()
        {
            InitializeComponent();
        }

        //Show panel whit how to play, hide other.
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = true;
            panelMenuOptions.Visible = false;
        }

        //Show panel whit Menu optons, hide other.
        private void menuOpptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPlay.Visible = false;
            panelMenuOptions.Visible = true;     
        }
    }
}
