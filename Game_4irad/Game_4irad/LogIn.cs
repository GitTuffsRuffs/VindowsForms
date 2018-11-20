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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private async void buttonLogIn_ClickAsync(object sender, EventArgs e)
        {
            //TODO/////////////////////////////////////////////////////////////////////////////////////

            Api game_api = new Api();
            PlayerToken logInCall = null;

            try
            {
                logInCall = await game_api.auth(text_Login.Text);
            }
            catch(NoResultException)
            {
                //Andvändaren skrev fel.
                MessageBox.Show("Invalid user.");
                //Start owere.
                return;
            }

            Form main = new MainForm(logInCall);
            main.Show();
            this.Hide();
        }
    }
}
