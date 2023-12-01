using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBLoginStudent
    {
        MySqlConnection connection = Host.connection;

        public void logstu(Guna2TextBox userid, Guna2TextBox password, ErrorProvider err)
        {
            //login
            string logad = $"SELECT FirstName, LastName, ID, password, email, mobile FROM studentaccount WHERE ID = '{userid.Text}' AND password = '{password.Text}'";
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
                    Model.Accounts.role = "STUDENT";

                    //User
                    Model.Accounts.user = row["firstname"] + " " + row["lastname"];

                    //UserID
                    Model.Accounts.UserID = row["ID"].ToString();

                    //Email
                    Model.Accounts.email = row["email"].ToString();

                    //Mobile
                    Model.Accounts.mobile = row["mobile"].ToString();

                    dash.Show();
                    FrontEnd.FEStudentLogin.closethis = true; // make this false on log out!
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
