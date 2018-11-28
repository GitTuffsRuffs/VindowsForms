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
        bool main_open = false;

        public LogIn()
        {
            InitializeComponent();
        }

        //Log in button presst.
        private async void buttonLogIn_ClickAsync(object sender, EventArgs e)
        {
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
            }catch(Exception)
            {
                MessageBox.Show("No conection to server.");
                //Start owere.
                return;
            }

            Form main = new MainForm(logInCall);
            main_open = true;
            main.Show();
            //Application.Run(main);
            this.Close();
        }

        private async void butt_MakeAccount_ClickAsync(object sender, EventArgs e)
        {
            Api game_api = new Api();
            PlayerToken logInCall = null;

            try
            {
                logInCall = await game_api.join(text_Login.Text);
            }
            catch (NoResultException)
            {
                //Andvändaren skrev fel.
                MessageBox.Show("Username alredy taken.");
                //Start owere.
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("No conection to server.");
                //Start owere.
                return;
            }

            Form main = new MainForm(logInCall);
            main_open = true;
            main.Show();
            //Application.Run(main);
            this.Close();
        }

        //When Pressing X
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (main_open == false) {
            Environment.Exit(0);
            }
        }



    }
}
