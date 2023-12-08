using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Data;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBFAGrading
    {
        MySqlConnection connection = Host.connection;

        //Set a flag for a subject click
        public static string sub;

        public static string IDs;

        public void DisplayStudents(Guna2DataGridView dgvstudent, Guna2ComboBox semester, Guna2ComboBox section)
        {
            if (sub == "Programming for Beginners")
            {
                if (semester.SelectedItem == null)
                {
                    //
                }
                //-------------------------------------------------------------------------------------------------
                //First sem Programming for Beginners
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM pfb_section1";
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
                else if(semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM pfb_section2";
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
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 2)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM pfb_section3";
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
                //-------------------------------------------------------------------------------------------------
                //Second sem Programming for Beginners
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM pfb_section1";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM pfb_section2";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM pfb_section3";
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


            //-------------------------------------------------------------------------------------------------
            //First sem Web Development Design
            else if (sub == "Web Development Design")
            {
                if (semester.SelectedItem == null)
                {
                    //
                }
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstperiodaverage FROM wdd_section1";
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
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstperiodaverage FROM wdd_section2";
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
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 2)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstperiodaverage FROM wdd_section3";
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
                //-------------------------------------------------------------------------------------------------
                //Second sem Web Development Design
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM wdd_section1";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM wdd_section2";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM wdd_section3";
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


            //-------------------------------------------------------------------------------------------------
            //First sem IT Essentials
            else if (sub == "IT Essentials")
            {
                if (semester.SelectedItem == null)
                {
                    //
                }
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM ite_section1";
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
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM ite_section2";
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
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 3)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM ite_section3";
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

                //-------------------------------------------------------------------------------------------------
                //Second sem IT Essentials
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM ite_section1";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM ite_section2";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM ite_section3";
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


            //-------------------------------------------------------------------------------------------------
            //First sem Computer Hardware Servicing
            else if (sub == "Computer Hardware Servicing")
            {
                if (semester.SelectedItem == null)
                {
                    //
                }
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM cte_section1";
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
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM cte_section2";
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
                else if (semester.SelectedIndex == 0 && section.SelectedIndex == 2)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, firstperiodgrades, secondperiodgrades, firstsemaverage FROM cte_section3";
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

                //-------------------------------------------------------------------------------------------------
                //Second sem Computer Hardware Servicing
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM cte_section1";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM cte_section2";
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
                else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                {
                    try
                    {
                        connection.Close();
                        connection.Open();
                        string query = $"SELECT ID, Firstname, Lastname, course, thirdperiodgrades, fourthperiodgrades, secondsemaverage FROM cte_section3";
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
        public void insertGrade(Guna2DataGridView dgvstudent, Guna2TextBox firstquarter, Guna2TextBox secondquarter, Guna2ComboBox semester, Guna2ComboBox schoolyear, Guna2TextBox avg, Guna2ComboBox section)
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
                        //-------------------------------------------------------------------------------------------------
                        //First sem ProgrammingForBeginners
                        string updatequery = "";
                        if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE pfb_section1 SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE pfb_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE pfb_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        //-------------------------------------------------------------------------------------------------
                        //Second sem ProgrammingForBeginners
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE pfb_section1 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE pfb_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE pfb_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            DisplayStudents(dgvstudent, semester, section); // Reload data to refresh the DataGridView after update
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
                        //-------------------------------------------------------------------------------------------------
                        //First sem Web Development Design
                        string updatequery = "";
                        if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE wdd_section1 SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE wdd_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE wdd_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        //-------------------------------------------------------------------------------------------------
                        //Second sem Web Development Design
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE wdd_section1 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE wdd_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE wdd_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            DisplayStudents(dgvstudent, semester, section); // Reload data to refresh the DataGridView after update
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
                        //-------------------------------------------------------------------------------------------------
                        //First sem IT Essentials
                        string updatequery = "";
                        if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE ite_section1 SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE ite_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE ite_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        //-------------------------------------------------------------------------------------------------
                        //Second sem IT Essentials
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE ite_section1 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE ite_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE ite_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            DisplayStudents(dgvstudent, semester, section); // Reload data to refresh the DataGridView after update
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
                        //-------------------------------------------------------------------------------------------------
                        //First sem Computer Hardware Servicing
                        string updatequery = "";
                        if (semester.SelectedIndex == 0 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE chs_section1 SET FirstPeriodGrades = '{firstquarter.Text}', SecondPeriodGrades = '{secondquarter.Text}', FirstSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE chs_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 0 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE chs_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        //-------------------------------------------------------------------------------------------------
                        //Second sem Computer Hardware Servicing
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 0)
                        {
                            updatequery = $"UPDATE chs_section1 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 1)
                        {
                            updatequery = $"UPDATE chs_section2 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }
                        else if (semester.SelectedIndex == 1 && section.SelectedIndex == 2)
                        {
                            updatequery = $"UPDATE chs_section3 SET ThirdPeriodGrades = '{firstquarter.Text}', FourthPeriodGrades = '{secondquarter.Text}', SecondSemAverage = '{avg.Text}' WHERE id = {IDs}";
                        }

                        connection.Close();
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand(updatequery, connection);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            DisplayStudents(dgvstudent, semester, section); // Reload data to refresh the DataGridView after update
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
            else
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