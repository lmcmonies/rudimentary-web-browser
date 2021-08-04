using BrowserLibrary;
using System;
using System.Windows.Forms;

namespace BrowserUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialise Text File Connection for writing to text files.
            GlobalDataConnection.InitialiseConnection(true);

            Application.Run(new BrowserForm());
        }
    }
}
