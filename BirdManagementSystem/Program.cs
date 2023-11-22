using BusinessObjects.Models;

namespace Bird.APP
{
    internal static class GlobalData
    {
        public static User AuthenticatedUser { get; set; }

        static GlobalData()
        {
            AuthenticatedUser = null;
        }


    }
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
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}