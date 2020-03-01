using System;
using System.Windows.Forms;

namespace AppUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartApp start = new StartApp();
            start.StartRun();
        }
    }
}