using System;
using System.Windows.Forms;
using SQLitePCL;

namespace PMQLSVDH
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize SQLite provider
            Batteries.Init();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
            Application.Run(new GiangVienForm());
            Application.Run(new AdminForm());
        }
    }
}