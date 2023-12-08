using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;

namespace SMARTLEARN.Database
{
    public class DBCheckOnline
    {
        MySqlConnection connection = Host.connection;

        public void check(Guna2Button loginbutton)
        {
            try
            {
                string search = $"SELECT * FROM handout_week1";
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
                loginbutton.Enabled = false;

                mess.Show();
            }

        }

    }
}
