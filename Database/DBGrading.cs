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
                    connection.Close();
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
                    connection.Close();
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
            try
            {
                if (semester.SelectedItem == null)
                {
                    // Handle when no semester is selected
                }
                else
                {
                    string updatequery = "";
                    if (semester.SelectedIndex == 0)
                    {
                        updatequery = "UPDATE studenttable SET FirstPeriodGrades = @FirstPeriodGrades, SecondPeriodGrades = @SecondPeriodGrades, FirstSemAverage = @FirstSemAverage WHERE id = @ID";
                    }
                    else if (semester.SelectedIndex == 1)
                    {
                        updatequery = "UPDATE studenttable SET ThirdPeriodGrades = @ThirdPeriodGrades, FourthPeriodGrades = @FourthPeriodGrades, SecondSemAverage = @SecondSemAverage WHERE id = @ID";
                    }

                    using (MySqlConnection connection = Host.connection)
                    {
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);
                        cmd.Parameters.AddWithValue("@FirstPeriodGrades", firstquarter.Text);
                        cmd.Parameters.AddWithValue("@SecondPeriodGrades", secondquarter.Text);
                        cmd.Parameters.AddWithValue("@ThirdPeriodGrades", firstquarter.Text); // Change to appropriate value
                        cmd.Parameters.AddWithValue("@FourthPeriodGrades", secondquarter.Text); // Change to appropriate value
                        cmd.Parameters.AddWithValue("@FirstSemAverage", avg.Text);
                        cmd.Parameters.AddWithValue("@SecondSemAverage", avg.Text); // Change to appropriate value
                        cmd.Parameters.AddWithValue("@ID", IDs); // Ensure IDs contains the correct value

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            DisplayStudents(dgvstudent, semester); // Reload data to refresh the DataGridView after update
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Update failed. The provided ID may not match any rows in the table.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                    string studentids = selectedRow.Cells[0].Value.ToString();

                    IDs = studentids;
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
                    string studentids = selectedRow.Cells[0].Value.ToString();

                    IDs = studentids;
                    firstquarter.Text = first;
                    secondquarter.Text = second;
                }
            }


        }
    }
}
