using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;

namespace SMARTLEARN.Database
{
    public class DBCheckOnline
    {
        MySqlConnection connection = Host.connection;

        public void check()
        {
            try
            {
                string search = $"SELECT * FROM studentaccount";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(search, connection);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {
                FrontEnd.ProcessMessage mess = new FrontEnd.ProcessMessage();
                FrontEnd.ProcessMessage.firstmessage = "DATABASE NOT FOUND!";
                FrontEnd.ProcessMessage.secondmessage = "Check if it's imported or turned off.";

                mess.Show();
            }

        }

    }
}
