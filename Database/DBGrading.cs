using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Data;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBGrading
    {
        MySqlConnection connection = Host.connection;

        public static string IDs;

        public void DisplayStudents(Guna2DataGridView dgvstudent, Guna2ComboBox semester)
        {
            if (semester.SelectedItem == null)
            {
                //
            }
            else if (semester.SelectedIndex == 0)
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades FROM studenttable";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvstudent.DataSource = dataTable;

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (semester.SelectedIndex == 1)
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades FROM studenttable";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvstudent.DataSource = dataTable;

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            connection.Close();
        }

        public void insertGrade(Guna2DataGridView dgvstudent, Guna2TextBox firstquarter, Guna2TextBox secondquarter, Guna2ComboBox semester, Guna2ComboBox schoolyear, Guna2TextBox avg)
        {
            if (semester.SelectedItem == null)
            {
                //
            }
            else if (semester.SelectedIndex == 0)
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string updatequery = $"UPDATE studenttable SET firstperiodgrades = '{firstquarter.Text}', secondperiodgrades = '{secondquarter.Text}', firstsemaverage = '{avg.Text}' WHERE id = '{IDs}'";
                    MySqlCommand cmd = new MySqlCommand(updatequery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data updated successfully!");
                        DisplayStudents(dgvstudent, semester); // Reload data to refresh the DataGridView after update
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

            }
            else if (semester.SelectedIndex == 1)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    string updatequery = $"UPDATE studenttable SET thirdperiodgrades = '{firstquarter.Text}', fourthperiodgrades = '{secondquarter.Text}', secondsemaverage = '{avg.Text}' WHERE id = '{IDs}'";
                    MySqlCommand cmd = new MySqlCommand(updatequery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data updated successfully!");
                        DisplayStudents(dgvstudent, semester); // Reload data to refresh the DataGridView after update
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
            }

            connection.Close();
        }

        public void selection(Guna2DataGridView dgvstudent, Guna2TextBox firstquarter, Guna2TextBox secondquarter, Guna2ComboBox semester, Guna2ComboBox schoolyear)
        {
            
            if (semester.SelectedItem == null)
            {
                //
            }
            else if (semester.SelectedIndex == 0)
            {
                if (dgvstudent.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvstudent.SelectedRows[0];

                    // Assuming the columns are in order: Name, LastName
                    string first = selectedRow.Cells[4].Value.ToString();
                    string second = selectedRow.Cells[5].Value.ToString();

                    firstquarter.Text = first;
                    secondquarter.Text = second;
                }
            }
            else if (semester.SelectedIndex == 1)
            {
                if (dgvstudent.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvstudent.SelectedRows[0];

                    // Assuming the columns are in order: Name, LastName
                    string first = selectedRow.Cells[4].Value.ToString();
                    string second = selectedRow.Cells[5].Value.ToString();

                    firstquarter.Text = first;
                    secondquarter.Text = second;
                }
            }


        }
    }
}
