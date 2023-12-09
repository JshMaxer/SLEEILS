using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.Model;
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
                    string logad = $"SELECT password FROM studentaccount_section1 WHERE id = '{Accounts.UserID}' AND password = '{current.Text}' UNION ALL SELECT password FROM studentaccount_section2 WHERE id = '{Accounts.UserID}' AND password = '{current.Text}' UNION ALL SELECT password FROM studentaccount_section3 WHERE id = '{Accounts.UserID}' AND password = '{current.Text}'";
                    MySqlCommand cmd = new MySqlCommand(logad, connection);
                    object result = cmd.ExecuteScalar();

                    if (result != null)  // Current password matches
                    {
                        // Update the password
                        string changepass = $"UPDATE studentaccount_section1 SET password = '1234' WHERE ID = {confirmpass.Text};" +
                                            $"UPDATE studentaccount_section2 SET password = '1234' WHERE ID = {confirmpass.Text};" +
                                            $"UPDATE studentaccount_section3 SET password = '1234' WHERE ID = {confirmpass.Text};";

                        MySqlCommand cmd1 = new MySqlCommand(changepass, connection);
                        cmd1.ExecuteNonQuery();

                        ProcessMessage.firstmessage = "Password changed successfully";
                        ProcessMessage.secondmessage = "\n\rThank you!.";

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
            else if (Accounts.role == "FACULTY")
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

                        ProcessMessage.firstmessage = "Password changed successfully";
                        ProcessMessage.secondmessage = "\n\rThank you!.";

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
