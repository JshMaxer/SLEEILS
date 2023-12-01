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

        //Set a flag for a subjec click
        public static string sub;

        public static string IDs;

        public void DisplayStudents(Guna2DataGridView dgvstudent, Guna2ComboBox semester)
        {
            if (sub == "Programming for Beginners")
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
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades FROM ProgrammingForBeginners";
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
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades FROM ProgrammingForBeginners";
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
            else if (sub == "Web Development Design")
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
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades FROM WebDevelopmentDesign";
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
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades FROM WebDevelopmentDesign";
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
            else if (sub == "IT Essentials")
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
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades FROM ITEssentials";
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
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades FROM ITEssentials";
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
            else if (sub == "Computer Hardware Servicing")
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
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades FROM ComputerHardwareServicing";
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
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades FROM ComputerHardwareServicing";
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

        }


        //Programming For Beginners
        public void insertGrade(Guna2DataGridView dgvstudent, Guna2TextBox firstquarter, Guna2TextBox secondquarter, Guna2ComboBox semester, Guna2ComboBox schoolyear, Guna2TextBox avg)
        {
            if (sub == "Programming for Beginners")
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
                            updatequery = $"UPDATE ProgrammingForBeginners SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE ProgrammingForBeginners SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

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
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
            else if (sub == "Web Development Design")
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
                            updatequery = $"UPDATE WebDevelopmentDesign SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE WebDevelopmentDesign SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

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
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
            else if (sub == "IT Essentials")
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
                            updatequery = $"UPDATE ITEssentials SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE ITEssentials SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

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
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
            else if (sub == "Computer Hardware Servicing")
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
                            updatequery = $"UPDATE ComputerHardwareServicing SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE ComputerHardwareServicing SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

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
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
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