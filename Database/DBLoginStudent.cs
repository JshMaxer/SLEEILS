using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBLoginStudent
    {
        MySqlConnection connection = Host.connection;

        public void logstu(Guna2TextBox userid, Guna2TextBox password, ErrorProvider err)
        {
            try
            {
                string logad = $"SELECT FirstName, LastName, ID, password, email, mobile\r\nFROM studentaccount_section1\r\nWHERE ID = '{userid.Text}' AND password = '{password.Text}'\r\n\r\nUNION ALL\r\n\r\nSELECT FirstName, LastName, ID, password, email, mobile\r\nFROM studentaccount_section2\r\nWHERE ID = '{userid.Text}' AND password = '{password.Text}'\r\n\r\nUNION ALL\r\n\r\nSELECT FirstName, LastName, ID, password, email, mobile\r\nFROM studentaccount_section3\r\nWHERE ID = '{userid.Text}' AND password = '{password.Text}';\r\n";

                using (MySqlCommand cmd = new MySqlCommand(logad, connection))
                {
                    connection.Open();

                    using (MySqlDataReader row = cmd.ExecuteReader())
                    {
                        if (row.HasRows)
                        {
                            string userFirstName = string.Empty;
                            string userLastName = string.Empty;
                            string userID = string.Empty;
                            string userEmail = string.Empty;
                            string userMobile = string.Empty;

                            while (row.Read())
                            {
                                userFirstName = row["FirstName"].ToString();
                                userLastName = row["LastName"].ToString();
                                userID = row["ID"].ToString();
                                userEmail = row["email"].ToString();
                                userMobile = row["mobile"].ToString();
                            }

                            FrontEnd.FEDashboard dash = new FEDashboard();
                            FrontEnd.FEDashboard.timertoclose = false; // Set the flag to false on the Dashboard

                            // Role
                            Model.Accounts.role = "STUDENT";

                            // User
                            Model.Accounts.user = $"{userFirstName} {userLastName}";

                            // UserID
                            Model.Accounts.UserID = userID;

                            // Email
                            Model.Accounts.email = userEmail;

                            // Mobile
                            Model.Accounts.mobile = userMobile;

                            dash.Show();
                            FrontEnd.FEStudentLogin.closethis = true; // Make this false on log out!
                            FEHome.timetoclose = true; // To hide the home form
                        }
                        else
                        {
                            err.SetError(userid, "Invalid UserID!");
                            err.SetError(password, "Invalid Password!");
                        }
                    }
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
}
