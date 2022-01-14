using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace MainUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            showForm();
        }
        [Obsolete]
        public static void showForm()
        {
            try
            {
                string path = SystemPath.ConnectionPath;
                MySqlDBConnection.stringCon =  MySqlDBConnection.XMLConnection(path);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SplashScreen());
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
