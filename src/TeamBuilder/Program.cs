using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TeamBuilder
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(DatabaseHandler.Instance));
        }
    }
}
