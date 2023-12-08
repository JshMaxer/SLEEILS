using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBForumMessage
    {
        MySqlConnection connection = Host.connection;

        public static string ID;
        public static string fname;
        public static string lname;

        public void message(RichTextBox messagebox)
        {
            if (Accounts.role == "STUDENT")
            {
                string user = $"SELECT ID, FirstName, LastName FROM studentaccount_section1 WHERE ID = '{Accounts.UserID}' UNION ALL SELECT ID, FirstName, LastName FROM studentaccount_section2 WHERE ID = '{Accounts.UserID}' UNION ALL SELECT ID, FirstName, LastName FROM studentaccount_section3 WHERE ID = '{Accounts.UserID}';";
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(user, connection);
                    MySqlDataReader row = cmd.ExecuteReader();

                    while (row.Read())
                    {
                        fname = row["FirstName"].ToString();
                        lname = row["LastName"].ToString();
                        ID = row["ID"].ToString();
                    }

                    // Close the DataReader after reading all necessary data
                    row.Close();

                    string query = $"INSERT INTO forum VALUES ('{ID}', '{fname + " " + lname}', '{messagebox.Text}', NOW())";
                    MySqlCommand insertCommand = new MySqlCommand(query, connection);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Posted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else if (Accounts.role == "FACULTY")
            {
                string user = $"SELECT userID, First_Name, Last_Name FROM facultyaccount WHERE userID = '{Accounts.UserID}'";
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(user, connection);
                    MySqlDataReader row = cmd.ExecuteReader();

                    while (row.Read())
                    {
                        fname = row["First_Name"].ToString();
                        lname = row["Last_Name"].ToString();
                        ID = row["userID"].ToString();
                    }

                    // Close the DataReader after reading all necessary data
                    row.Close();

                    string query = $"INSERT INTO forum VALUES ('{ID}', '{fname + " " + lname}', '{messagebox.Text}', NOW())";
                    MySqlCommand insertCommand = new MySqlCommand(query, connection);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Posted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    connection.Close();
                }
            }
            else
            {
                string query = $"INSERT INTO forum VALUES ('01', 'ADMIN', '{messagebox.Text}', NOW())";
                connection.Open();
                MySqlCommand insertCommand = new MySqlCommand(query, connection);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Posted");
                connection.Close();
            }

        }




    }
}
