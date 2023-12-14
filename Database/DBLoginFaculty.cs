using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.Model;
using SMARTLEARN;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;

public class DBLoginFaculty
{
    MySqlConnection connection = Host.connection;

    public void logad(Guna2TextBox userid, Guna2TextBox password, ErrorProvider err)
    {
        try
        {
            string logad = $"SELECT first_name, last_name, userid, email, mobilenumber, password FROM facultyaccount WHERE userid = '{userid.Text}' AND password = '{password.Text}'";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand(logad, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            List<string[]> userData = new List<string[]>();

            while (row.Read())
            {
                string[] data = new string[]
                {
                    row["first_name"].ToString(),
                    row["last_name"].ToString(),
                    row["userid"].ToString(),
                    row["email"].ToString(),
                    row["mobilenumber"].ToString()
                };
                userData.Add(data);
            }

            row.Close();
            connection.Close();

            if (userData.Count > 0)
            {
                FEDashboard dash = new FEDashboard();
                FEDashboard.timertoclose = false; // Set the flag to false on the Dashboard

                // Role
                Accounts.role = "FACULTY";

                // User
                Accounts.user = $"{userData[0][0]} {userData[0][1]}";

                // UserID
                Accounts.UserID = userData[0][2];

                // Email
                Accounts.email = userData[0][3];

                // Mobile
                Accounts.mobile = userData[0][4];

                dash.Show();
                FELoginAdminFaculty.closethis = true; // Make this false on log out!
                FEHome.timetoclose = true; // To hide the home form
            }
            else
            {
                err.SetError(userid, "Invalid UserID!");
                err.SetError(password, "Invalid Password!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
