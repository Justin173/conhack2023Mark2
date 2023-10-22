using System.Data;
using System.Data.SqlClient;
using MySqlConnector;
using conhack2023;

namespace conhack2023Mark2
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
            ApplicationConfiguration.Initialize();

            Application.Run(new Form2());

            SQL sql = new SQL("Server=localhost; user id= root; password=rootpassword; database=conhacks");

            sql.openConnection();
        }
    }
}