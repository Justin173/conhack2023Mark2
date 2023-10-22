using System.Data;
using System.Data.SqlClient;

using MySqlConnector;
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

            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ("Server=localhost; user id= root; password=rootpassword; database=conhacks");

            try
            {
                connection.Open();
                MessageBox.Show("database is connected");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            using var cmd = new MySqlCommand();
            cmd.CommandText = "";

            Application.Run(new Form1());

        }
    }
}