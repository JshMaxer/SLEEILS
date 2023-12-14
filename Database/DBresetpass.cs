using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.Model;
using System.Data;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBresetpass
    {
        MySqlConnection connection = Host.connection;

        public static string role;

        public void searchAccount(Guna2DataGridView list)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM reset_password";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                list.DataSource = dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();
        }

        public void ClickDGV(Guna2DataGridView list, Guna2TextBox ID, Guna2TextBox fname, Guna2TextBox lname)
        {
            if (list.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = list.SelectedRows[0];

                // Assuming the columns are in order: Name, LastName
                string SelectedID = selectedRow.Cells[0].Value.ToString();
                string Firstname = selectedRow.Cells[1].Value.ToString();
                string lastName = selectedRow.Cells[2].Value.ToString();
                role = selectedRow.Cells[3].Value.ToString();

                ID.Text = SelectedID;
                fname.Text = Firstname;
                lname.Text = lastName;
            }

        }

        public void updatePass(Guna2DataGridView list, Guna2TextBox ID, Guna2TextBox fname, Guna2TextBox lname)
        {
            if (role == "STUDENT")
            {
                try
                {
                    connection.Open();

                    string query = $"UPDATE studentaccount_section1 SET password = '1234' WHERE ID = {ID.Text};" +
                                   $"UPDATE studentaccount_section2 SET password = '1234' WHERE ID = {ID.Text};" +
                                   $"UPDATE studentaccount_section3 SET password = '1234' WHERE ID = {ID.Text};";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //Delete the studentListed
                        string deleteStudent = $"DELETE FROM reset_password WHERE ID = ('{ID.Text}')";
                        MySqlCommand cmd2 = new MySqlCommand(deleteStudent, connection);
                        cmd2.ExecuteNonQuery();
                        ID.Text = null;
                        fname.Text = null;
                        lname.Text = null;

                        ProcessMessage.firstmessage = "Password reset successful!";
                        //ProcessMessage.secondmessage = "\n\rThank you!";
                        ProcessMessage pm = new ProcessMessage();
                        pm.Show();

                        connection.Close();
                        searchAccount(list);
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
            else
            {
                try
                {
                    connection.Open();

                    string query = $"UPDATE facultyaccount SET password = '1234' WHERE userid = {ID.Text}";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //Delete the studentListed
                        string deleteStudent = $"DELETE FROM reset_password WHERE ID = ('{ID.Text}')";
                        MySqlCommand cmd2 = new MySqlCommand(deleteStudent, connection);
                        cmd2.ExecuteNonQuery();
                        ID.Text = null;
                        fname.Text = null;
                        lname.Text = null;

                        ProcessMessage.firstmessage = "Password reset successful!";
                        //ProcessMessage.secondmessage = "\n\rThank you!";
                        ProcessMessage pm = new ProcessMessage();
                        pm.Show();

                        connection.Close();
                        searchAccount(list);
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

    }
}
