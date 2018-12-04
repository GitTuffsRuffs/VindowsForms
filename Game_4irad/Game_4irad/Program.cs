using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_4irad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Get Error messadge in English
            if (Debugger.IsAttached)
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            /* TEST SERVER
            String url = "http://fir.tuffsruffs.se/api/game/1";
            var ajax = new System.Net.Http.HttpClient();
            var task = ajax.GetAsync(url).Result.Content.ReadAsStringAsync();
            task.Wait();
            MessageBox.Show(task.Result);
            */

            //Aouto generated rows
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Skapa Forum LogIn & visa det.
            Form login = new LogIn();
            login.Show();
            //Aouto generated row
            Application.Run();
        }
    }
}
