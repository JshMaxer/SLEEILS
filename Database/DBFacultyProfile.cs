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

        public void showinfo(System.Windows.Forms.Label username, System.Windows.Forms.Label email, System.Windows.Forms.Label mobile, System.Windows.Forms.Label department, System.Windows.Forms.Label roles, System.Windows.Forms.Label ID)
        {
            //login
            string logad = $"SELECT department FROM facultyaccount WHERE userid = '{Model.Accounts.UserID}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(logad, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    username.Text = Model.Accounts.user;
                    roles.Text = Model.Accounts.role;
                    ID.Text = Model.Accounts.UserID;

                    email.Text = Model.Accounts.email;
                    mobile.Text = Model.Accounts.mobile;
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
