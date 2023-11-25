using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.FrontEnd.Message;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    //database
    public  class DBLoginFaculty
    {
        MySqlConnection connection = Host.connection;
        public void logad(Guna2TextBox userid, Guna2TextBox password, ErrorProvider err)
        {
            //login
            string logad = $"SELECT first_name, userid, password FROM facultyaccount WHERE userid = '{userid.Text}' AND password = '{password.Text}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(logad, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    FrontEnd.FEDashboard dash = new FEDashboard();
                    FrontEnd.FEDashboard.timertoclose = false; //Set the flag to false on the Dashboard

                    //Role
                    FrontEnd.FEDashboard.role = "Faculty";

                    dash.Show();
                    FELoginAdmin.closethis = true; // make this false on log out!
                    FEHome.timetoclose = true; //To hide the home form
                }

            }
            else
            {
                err.SetError(userid, "Invalid UserID!");
                err.SetError(password, "Invalid Password!");
            }
            connection.Close();
        }
    }
}
