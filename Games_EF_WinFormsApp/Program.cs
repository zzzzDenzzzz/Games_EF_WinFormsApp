using Games_EF_WinFormsApp.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Games_EF_WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var context = new GameContext();
            context.Database.Migrate();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}