using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SMARTLEARN.Database
{
    public class DBFacultyProfile
    {
        MySqlConnection connection = Host.connection;

        //Set a flag to give the current role to lblrole.txt
        public static string role;

        //Set a flag for user who's log-in
        public static string user;

        //Set a flag for userID
        public static string UserID;

        public void showinfo(System.Windows.Forms.Label username, System.Windows.Forms.Label email, System.Windows.Forms.Label mobile, System.Windows.Forms.Label department, System.Windows.Forms.Label roles, System.Windows.Forms.Label ID)
        {
            //login
            string logad = $"SELECT userid, email, mobilenumber, department FROM facultyaccount WHERE userid = '{UserID}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(logad, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    username.Text = user;
                    roles.Text = role;
                    ID.Text = UserID;

                    email.Text = row["email"].ToString();
                    mobile.Text = row["mobilenumber"].ToString();
                    department.Text = row["department"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }


    }
}
