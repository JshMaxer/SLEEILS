using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMARTLEARN.Database
{
    public class DBStudentProfile
    {
        MySqlConnection connection = Host.connection;

        public static int UserID;

        public void searchbalance()
        {
            //login
            string logad = $"SELECT FirstSemesterBalance, SecondSemesterBalance FROM studenttable WHERE userid = '{UserID}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(logad, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {

                }

            }
            else
            {

            }
            connection.Close();
        }

    }
}
