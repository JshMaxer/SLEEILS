﻿using Guna.UI2.WinForms;
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
    public class DBChangepass
    {
        MySqlConnection connection = Host.connection;

        public void changepass(Guna2TextBox current, Guna2TextBox newpass, Guna2TextBox confirmpass, ErrorProvider error)
        {
            if (Accounts.role == "STUDENT")
            {
                if (newpass.Text == confirmpass.Text)
                {
                    connection.Open();

                    // Check if the current password matches
                    string logad = $"SELECT password FROM studentaccount WHERE id = '{Accounts.UserID}' AND password = '{current.Text}'";
                    MySqlCommand cmd = new MySqlCommand(logad, connection);
                    object result = cmd.ExecuteScalar();

                    if (result != null)  // Current password matches
                    {
                        // Update the password
                        string changepass = $"UPDATE studentaccount SET password = '{confirmpass.Text}' WHERE id = '{Accounts.UserID}'";
                        MySqlCommand cmd1 = new MySqlCommand(changepass, connection);
                        cmd1.ExecuteNonQuery();

                        ProcessMessage.firstmessage = "Password changed ";
                        ProcessMessage.secondmessage = "successfully.";

                        ProcessMessage pr = new ProcessMessage();
                        pr.Show();


                    }
                    else
                    {
                        error.SetError(current, "Incorrect current password.");
                    }

                    connection.Close();
                }
                else
                {
                    error.SetError(newpass, "Passwords do not match.");
                    error.SetError(confirmpass, "Passwords do not match.");
                }
            }
            else
            {
                if (newpass.Text == confirmpass.Text)
                {
                    connection.Open();

                    // Check if the current password matches
                    string logad = $"SELECT password FROM facultyaccount WHERE userid = '{Accounts.UserID}' AND password = '{current.Text}'";
                    MySqlCommand cmd = new MySqlCommand(logad, connection);
                    object result = cmd.ExecuteScalar();

                    if (result != null)  // Current password matches
                    {
                        // Update the password
                        string changepass = $"UPDATE facultyaccount SET password = '{confirmpass.Text}' WHERE userid = '{Accounts.UserID}'";
                        MySqlCommand cmd1 = new MySqlCommand(changepass, connection);
                        cmd1.ExecuteNonQuery();

                        ProcessMessage.firstmessage = "Password changed ";
                        ProcessMessage.secondmessage = "Successfully.";

                        ProcessMessage pr = new ProcessMessage();
                        pr.Show();


                    }
                    else
                    {
                        error.SetError(current, "Incorrect current password.");
                    }

                    connection.Close();
                }
                else
                {
                    error.SetError(newpass, "Passwords do not match.");
                    error.SetError(confirmpass, "Passwords do not match.");
                }
            }
        }

    }
}