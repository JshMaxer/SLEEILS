using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBADSchedule
    {
        MySqlConnection connection = Host.connection;

        //Set a flag for ID that you will choose in combobox.
        public static string ID;

        public void UpdateMonday(
            
    Guna2ComboBox monday1, Guna2ComboBox monday2, Guna2ComboBox monday3, Guna2ComboBox monday4, Guna2ComboBox monday5,
    Guna2ComboBox monday6, Guna2ComboBox monday7, Guna2ComboBox monday8, Guna2ComboBox monday9, Guna2ComboBox monday10,
    Guna2ComboBox monday11, Guna2ComboBox monday12, Guna2ComboBox monday13, Guna2ComboBox monday14, Guna2ComboBox monday15,
    Guna2ComboBox monday16, Guna2ComboBox monday17, Guna2ComboBox STUFAC)
        {
            if (STUFAC.SelectedIndex == 0)
            {
                try
                {

                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule SET Monday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{monday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{monday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{monday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{monday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{monday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{monday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{monday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{monday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{monday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{monday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{monday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{monday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{monday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{monday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{monday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{monday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00'AND ID = '{ID}' THEN '{monday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Monday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule_Faculty SET Monday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{monday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{monday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{monday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{monday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{monday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{monday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{monday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{monday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{monday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{monday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{monday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{monday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{monday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{monday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{monday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{monday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00'AND ID = '{ID}' THEN '{monday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Monday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            
        }


        public void UpdateTuesday(
    Guna2ComboBox tuesday1, Guna2ComboBox tuesday2, Guna2ComboBox tuesday3, Guna2ComboBox tuesday4, Guna2ComboBox tuesday5,
    Guna2ComboBox tuesday6, Guna2ComboBox tuesday7, Guna2ComboBox tuesday8, Guna2ComboBox tuesday9, Guna2ComboBox tuesday10,
    Guna2ComboBox tuesday11, Guna2ComboBox tuesday12, Guna2ComboBox tuesday13, Guna2ComboBox tuesday14, Guna2ComboBox tuesday15,
    Guna2ComboBox tuesday16, Guna2ComboBox tuesday17, Guna2ComboBox STUFAC)
        {
            if (STUFAC.SelectedIndex == 0)
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule SET Tuesday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{tuesday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{tuesday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{tuesday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{tuesday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{tuesday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{tuesday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{tuesday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{tuesday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{tuesday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{tuesday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{tuesday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{tuesday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{tuesday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{tuesday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{tuesday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{tuesday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{tuesday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tuesday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule_Faculty SET Tuesday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{tuesday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{tuesday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{tuesday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{tuesday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{tuesday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{tuesday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{tuesday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{tuesday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{tuesday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{tuesday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{tuesday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{tuesday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{tuesday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{tuesday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{tuesday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{tuesday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{tuesday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tuesday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
           
        }

        public void UpdateWednesday(
    Guna2ComboBox wednesday1, Guna2ComboBox wednesday2, Guna2ComboBox wednesday3, Guna2ComboBox wednesday4, Guna2ComboBox wednesday5,
    Guna2ComboBox wednesday6, Guna2ComboBox wednesday7, Guna2ComboBox wednesday8, Guna2ComboBox wednesday9, Guna2ComboBox wednesday10,
    Guna2ComboBox wednesday11, Guna2ComboBox wednesday12, Guna2ComboBox wednesday13, Guna2ComboBox wednesday14, Guna2ComboBox wednesday15,
    Guna2ComboBox wednesday16, Guna2ComboBox wednesday17, Guna2ComboBox STUFAC)
        {
            if (STUFAC.SelectedIndex == 0)
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule SET Wednesday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{wednesday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{wednesday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{wednesday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{wednesday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{wednesday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{wednesday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{wednesday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{wednesday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{wednesday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{wednesday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{wednesday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{wednesday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{wednesday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{wednesday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{wednesday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{wednesday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{wednesday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Wednesday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule_Faculty SET Wednesday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{wednesday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{wednesday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{wednesday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{wednesday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{wednesday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{wednesday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{wednesday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{wednesday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{wednesday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{wednesday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{wednesday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{wednesday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{wednesday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{wednesday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{wednesday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{wednesday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{wednesday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Wednesday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
        }

        public void UpdateThursday(
    Guna2ComboBox thursday1, Guna2ComboBox thursday2, Guna2ComboBox thursday3, Guna2ComboBox thursday4, Guna2ComboBox thursday5,
    Guna2ComboBox thursday6, Guna2ComboBox thursday7, Guna2ComboBox thursday8, Guna2ComboBox thursday9, Guna2ComboBox thursday10,
    Guna2ComboBox thursday11, Guna2ComboBox thursday12, Guna2ComboBox thursday13, Guna2ComboBox thursday14, Guna2ComboBox thursday15,
    Guna2ComboBox thursday16, Guna2ComboBox thursday17, Guna2ComboBox STUFAC)
        {
            if (STUFAC.SelectedIndex == 0)
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule SET Thursday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{thursday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{thursday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{thursday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{thursday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{thursday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{thursday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{thursday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{thursday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{thursday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{thursday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{thursday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{thursday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{thursday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{thursday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{thursday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{thursday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{thursday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thursday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule_Faculty SET Thursday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{thursday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{thursday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{thursday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{thursday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{thursday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{thursday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{thursday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{thursday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{thursday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{thursday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{thursday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{thursday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{thursday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{thursday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{thursday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{thursday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{thursday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thursday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
        }

        public void UpdateFriday(
    Guna2ComboBox friday1, Guna2ComboBox friday2, Guna2ComboBox friday3, Guna2ComboBox friday4, Guna2ComboBox friday5,
    Guna2ComboBox friday6, Guna2ComboBox friday7, Guna2ComboBox friday8, Guna2ComboBox friday9, Guna2ComboBox friday10,
    Guna2ComboBox friday11, Guna2ComboBox friday12, Guna2ComboBox friday13, Guna2ComboBox friday14, Guna2ComboBox friday15,
    Guna2ComboBox friday16, Guna2ComboBox friday17, Guna2ComboBox STUFAC)
        {
            if (STUFAC.SelectedIndex == 0)
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule SET Friday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{friday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{friday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{friday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{friday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{friday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{friday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{friday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{friday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{friday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{friday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{friday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{friday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{friday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{friday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{friday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{friday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{friday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Friday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string query = $"UPDATE Schedule_Faculty SET Friday = " +
                        $"CASE " +
                        $"WHEN Time = '7:00 - 7:30' AND ID = '{ID}' THEN '{friday1.Text}' " +
                        $"WHEN Time = '7:30 - 8:30' AND ID = '{ID}' THEN '{friday2.Text}' " +
                        $"WHEN Time = '8:30 - 9:00' AND ID = '{ID}' THEN '{friday3.Text}' " +
                        $"WHEN Time = '9:00 - 9:30' AND ID = '{ID}' THEN '{friday4.Text}' " +
                        $"WHEN Time = '9:30 - 10:00' AND ID = '{ID}' THEN '{friday5.Text}' " +
                        $"WHEN Time = '10:00 - 10:30' AND ID = '{ID}' THEN '{friday6.Text}' " +
                        $"WHEN Time = '10:30 - 11:00' AND ID = '{ID}' THEN '{friday7.Text}' " +
                        $"WHEN Time = '11:00 - 11:30' AND ID = '{ID}' THEN '{friday8.Text}' " +
                        $"WHEN Time = '11:30 - 12:00' AND ID = '{ID}' THEN '{friday9.Text}' " +
                        $"WHEN Time = '12:00 - 12:30' AND ID = '{ID}' THEN '{friday10.Text}' " +
                        $"WHEN Time = '12:30 - 1:00' AND ID = '{ID}' THEN '{friday11.Text}' " +
                        $"WHEN Time = '1:00 - 1:30' AND ID = '{ID}' THEN '{friday12.Text}' " +
                        $"WHEN Time = '1:30 - 2:00' AND ID = '{ID}' THEN '{friday13.Text}' " +
                        $"WHEN Time = '2:00 - 2:30' AND ID = '{ID}' THEN '{friday14.Text}' " +
                        $"WHEN Time = '2:30 - 3:00' AND ID = '{ID}' THEN '{friday15.Text}' " +
                        $"WHEN Time = '3:00 - 3:30' AND ID = '{ID}' THEN '{friday16.Text}' " +
                        $"WHEN Time = '3:30 - 4:00' AND ID = '{ID}' THEN '{friday17.Text}' " +
                        $"END;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Friday schedule updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Update failed.");
                    }

                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void showStudent(Guna2ComboBox names, Guna2ComboBox STUFAC)
        {
            if (STUFAC.SelectedItem.Equals("STUDENT"))
            {
                string showstudent = "SELECT id, firstname, lastname FROM studentaccount";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(showstudent, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        names.Items.Clear();
                        names.Items.Add(row["firstname"].ToString() + " " + row["lastname"].ToString());
                        ID = row["id"].ToString();
                    }

                }
                else
                {
                    //
                }
                connection.Close();
            }
            else 
            {
                string showfaculty = "SELECT userid, first_name, last_name FROM facultyaccount";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(showfaculty, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        names.Items.Clear();
                        names.Items.Add(row["first_name"].ToString() + " " + row["last_name"].ToString());
                        ID = row["userid"].ToString();
                    }

                }
                else
                {
                    //
                }
                connection.Close();
            }
            
        }


        public void ShowSchedule(string time, Guna2ComboBox monday, Guna2ComboBox tuesday, Guna2ComboBox wednesday, Guna2ComboBox thursday, Guna2ComboBox friday, Guna2ComboBox stufac)
        {
            if (stufac.SelectedIndex == 0)
            {
                string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '{time}' AND ID = '{ID}'";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(showsched, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        monday.Text = row["Monday"].ToString();
                        tuesday.Text = row["Tuesday"].ToString();
                        wednesday.Text = row["Wednesday"].ToString();
                        thursday.Text = row["Thursday"].ToString();
                        friday.Text = row["Friday"].ToString();
                    }
                }
                else
                {
                    // Handle no data
                }
                connection.Close();
            }
            else
            {
                string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule_faculty WHERE Time = '{time}' AND ID = '{ID}'";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(showsched, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        monday.Text = row["Monday"].ToString();
                        tuesday.Text = row["Tuesday"].ToString();
                        wednesday.Text = row["Wednesday"].ToString();
                        thursday.Text = row["Thursday"].ToString();
                        friday.Text = row["Friday"].ToString();
                    }
                }
                else
                {
                    // Handle no data
                }
                connection.Close();
            }
        }

    }
}
