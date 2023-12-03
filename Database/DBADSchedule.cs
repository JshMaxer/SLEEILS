using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBADSchedule
    {
        MySqlConnection connection = Host.connection;

        //Set a flag for studentID that you will choose in combobox.
        public static string StudentID;

        public void UpdateMonday(
    Guna2ComboBox monday1, Guna2ComboBox monday2, Guna2ComboBox monday3, Guna2ComboBox monday4, Guna2ComboBox monday5,
    Guna2ComboBox monday6, Guna2ComboBox monday7, Guna2ComboBox monday8, Guna2ComboBox monday9, Guna2ComboBox monday10,
    Guna2ComboBox monday11, Guna2ComboBox monday12, Guna2ComboBox monday13, Guna2ComboBox monday14, Guna2ComboBox monday15,
    Guna2ComboBox monday16, Guna2ComboBox monday17)
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"UPDATE Schedule SET Monday = " +
                    $"CASE " +
                    $"WHEN Time = '7:00 - 7:30' AND ID = '{StudentID}' THEN '{monday1.Text}' " +
                    $"WHEN Time = '7:30 - 8:30' AND ID = '{StudentID}' THEN '{monday2.Text}' " +
                    $"WHEN Time = '8:30 - 9:00' AND ID = '{StudentID}' THEN '{monday3.Text}' " +
                    $"WHEN Time = '9:00 - 9:30' AND ID = '{StudentID}' THEN '{monday4.Text}' " +
                    $"WHEN Time = '9:30 - 10:00' AND ID = '{StudentID}' THEN '{monday5.Text}' " +
                    $"WHEN Time = '10:00 - 10:30' AND ID = '{StudentID}' THEN '{monday6.Text}' " +
                    $"WHEN Time = '10:30 - 11:00' AND ID = '{StudentID}' THEN '{monday7.Text}' " +
                    $"WHEN Time = '11:00 - 11:30' AND ID = '{StudentID}' THEN '{monday8.Text}' " +
                    $"WHEN Time = '11:30 - 12:00' AND ID = '{StudentID}' THEN '{monday9.Text}' " +
                    $"WHEN Time = '12:00 - 12:30' AND ID = '{StudentID}' THEN '{monday10.Text}' " +
                    $"WHEN Time = '12:30 - 1:00' AND ID = '{StudentID}' THEN '{monday11.Text}' " +
                    $"WHEN Time = '1:00 - 1:30' AND ID = '{StudentID}' THEN '{monday12.Text}' " +
                    $"WHEN Time = '1:30 - 2:00' AND ID = '{StudentID}' THEN '{monday13.Text}' " +
                    $"WHEN Time = '2:00 - 2:30' AND ID = '{StudentID}' THEN '{monday14.Text}' " +
                    $"WHEN Time = '2:30 - 3:00' AND ID = '{StudentID}' THEN '{monday15.Text}' " +
                    $"WHEN Time = '3:00 - 3:30' AND ID = '{StudentID}' THEN '{monday16.Text}' " +
                    $"WHEN Time = '3:30 - 4:00'AND ID = '{StudentID}' THEN '{monday17.Text}' " +
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


        public void UpdateTuesday(
    Guna2ComboBox tuesday1, Guna2ComboBox tuesday2, Guna2ComboBox tuesday3, Guna2ComboBox tuesday4, Guna2ComboBox tuesday5,
    Guna2ComboBox tuesday6, Guna2ComboBox tuesday7, Guna2ComboBox tuesday8, Guna2ComboBox tuesday9, Guna2ComboBox tuesday10,
    Guna2ComboBox tuesday11, Guna2ComboBox tuesday12, Guna2ComboBox tuesday13, Guna2ComboBox tuesday14, Guna2ComboBox tuesday15,
    Guna2ComboBox tuesday16, Guna2ComboBox tuesday17)
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"UPDATE Schedule SET Tuesday = " +
                    $"CASE " +
                    $"WHEN Time = '7:00 - 7:30' AND ID = '{StudentID}' THEN '{tuesday1.Text}' " +
                    $"WHEN Time = '7:30 - 8:30' AND ID = '{StudentID}' THEN '{tuesday2.Text}' " +
                    $"WHEN Time = '8:30 - 9:00' AND ID = '{StudentID}' THEN '{tuesday3.Text}' " +
                    $"WHEN Time = '9:00 - 9:30' AND ID = '{StudentID}' THEN '{tuesday4.Text}' " +
                    $"WHEN Time = '9:30 - 10:00' AND ID = '{StudentID}' THEN '{tuesday5.Text}' " +
                    $"WHEN Time = '10:00 - 10:30' AND ID = '{StudentID}' THEN '{tuesday6.Text}' " +
                    $"WHEN Time = '10:30 - 11:00' AND ID = '{StudentID}' THEN '{tuesday7.Text}' " +
                    $"WHEN Time = '11:00 - 11:30' AND ID = '{StudentID}' THEN '{tuesday8.Text}' " +
                    $"WHEN Time = '11:30 - 12:00' AND ID = '{StudentID}' THEN '{tuesday9.Text}' " +
                    $"WHEN Time = '12:00 - 12:30' AND ID = '{StudentID}' THEN '{tuesday10.Text}' " +
                    $"WHEN Time = '12:30 - 1:00' AND ID = '{StudentID}' THEN '{tuesday11.Text}' " +
                    $"WHEN Time = '1:00 - 1:30' AND ID = '{StudentID}' THEN '{tuesday12.Text}' " +
                    $"WHEN Time = '1:30 - 2:00' AND ID = '{StudentID}' THEN '{tuesday13.Text}' " +
                    $"WHEN Time = '2:00 - 2:30' AND ID = '{StudentID}' THEN '{tuesday14.Text}' " +
                    $"WHEN Time = '2:30 - 3:00' AND ID = '{StudentID}' THEN '{tuesday15.Text}' " +
                    $"WHEN Time = '3:00 - 3:30' AND ID = '{StudentID}' THEN '{tuesday16.Text}' " +
                    $"WHEN Time = '3:30 - 4:00' AND ID = '{StudentID}' THEN '{tuesday17.Text}' " +
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

        public void UpdateWednesday(
    Guna2ComboBox wednesday1, Guna2ComboBox wednesday2, Guna2ComboBox wednesday3, Guna2ComboBox wednesday4, Guna2ComboBox wednesday5,
    Guna2ComboBox wednesday6, Guna2ComboBox wednesday7, Guna2ComboBox wednesday8, Guna2ComboBox wednesday9, Guna2ComboBox wednesday10,
    Guna2ComboBox wednesday11, Guna2ComboBox wednesday12, Guna2ComboBox wednesday13, Guna2ComboBox wednesday14, Guna2ComboBox wednesday15,
    Guna2ComboBox wednesday16, Guna2ComboBox wednesday17)
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"UPDATE Schedule SET Wednesday = " +
                    $"CASE " +
                    $"WHEN Time = '7:00 - 7:30' AND ID = '{StudentID}' THEN '{wednesday1.Text}' " +
                    $"WHEN Time = '7:30 - 8:30' AND ID = '{StudentID}' THEN '{wednesday2.Text}' " +
                    $"WHEN Time = '8:30 - 9:00' AND ID = '{StudentID}' THEN '{wednesday3.Text}' " +
                    $"WHEN Time = '9:00 - 9:30' AND ID = '{StudentID}' THEN '{wednesday4.Text}' " +
                    $"WHEN Time = '9:30 - 10:00' AND ID = '{StudentID}' THEN '{wednesday5.Text}' " +
                    $"WHEN Time = '10:00 - 10:30' AND ID = '{StudentID}' THEN '{wednesday6.Text}' " +
                    $"WHEN Time = '10:30 - 11:00' AND ID = '{StudentID}' THEN '{wednesday7.Text}' " +
                    $"WHEN Time = '11:00 - 11:30' AND ID = '{StudentID}' THEN '{wednesday8.Text}' " +
                    $"WHEN Time = '11:30 - 12:00' AND ID = '{StudentID}' THEN '{wednesday9.Text}' " +
                    $"WHEN Time = '12:00 - 12:30' AND ID = '{StudentID}' THEN '{wednesday10.Text}' " +
                    $"WHEN Time = '12:30 - 1:00' AND ID = '{StudentID}' THEN '{wednesday11.Text}' " +
                    $"WHEN Time = '1:00 - 1:30' AND ID = '{StudentID}' THEN '{wednesday12.Text}' " +
                    $"WHEN Time = '1:30 - 2:00' AND ID = '{StudentID}' THEN '{wednesday13.Text}' " +
                    $"WHEN Time = '2:00 - 2:30' AND ID = '{StudentID}' THEN '{wednesday14.Text}' " +
                    $"WHEN Time = '2:30 - 3:00' AND ID = '{StudentID}' THEN '{wednesday15.Text}' " +
                    $"WHEN Time = '3:00 - 3:30' AND ID = '{StudentID}' THEN '{wednesday16.Text}' " +
                    $"WHEN Time = '3:30 - 4:00' AND ID = '{StudentID}' THEN '{wednesday17.Text}' " +
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

        public void UpdateThursday(
    Guna2ComboBox thursday1, Guna2ComboBox thursday2, Guna2ComboBox thursday3, Guna2ComboBox thursday4, Guna2ComboBox thursday5,
    Guna2ComboBox thursday6, Guna2ComboBox thursday7, Guna2ComboBox thursday8, Guna2ComboBox thursday9, Guna2ComboBox thursday10,
    Guna2ComboBox thursday11, Guna2ComboBox thursday12, Guna2ComboBox thursday13, Guna2ComboBox thursday14, Guna2ComboBox thursday15,
    Guna2ComboBox thursday16, Guna2ComboBox thursday17)
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"UPDATE Schedule SET Thursday = " +
                    $"CASE " +
                    $"WHEN Time = '7:00 - 7:30' AND ID = '{StudentID}' THEN '{thursday1.Text}' " +
                    $"WHEN Time = '7:30 - 8:30' AND ID = '{StudentID}' THEN '{thursday2.Text}' " +
                    $"WHEN Time = '8:30 - 9:00' AND ID = '{StudentID}' THEN '{thursday3.Text}' " +
                    $"WHEN Time = '9:00 - 9:30' AND ID = '{StudentID}' THEN '{thursday4.Text}' " +
                    $"WHEN Time = '9:30 - 10:00' AND ID = '{StudentID}' THEN '{thursday5.Text}' " +
                    $"WHEN Time = '10:00 - 10:30' AND ID = '{StudentID}' THEN '{thursday6.Text}' " +
                    $"WHEN Time = '10:30 - 11:00' AND ID = '{StudentID}' THEN '{thursday7.Text}' " +
                    $"WHEN Time = '11:00 - 11:30' AND ID = '{StudentID}' THEN '{thursday8.Text}' " +
                    $"WHEN Time = '11:30 - 12:00' AND ID = '{StudentID}' THEN '{thursday9.Text}' " +
                    $"WHEN Time = '12:00 - 12:30' AND ID = '{StudentID}' THEN '{thursday10.Text}' " +
                    $"WHEN Time = '12:30 - 1:00' AND ID = '{StudentID}' THEN '{thursday11.Text}' " +
                    $"WHEN Time = '1:00 - 1:30' AND ID = '{StudentID}' THEN '{thursday12.Text}' " +
                    $"WHEN Time = '1:30 - 2:00' AND ID = '{StudentID}' THEN '{thursday13.Text}' " +
                    $"WHEN Time = '2:00 - 2:30' AND ID = '{StudentID}' THEN '{thursday14.Text}' " +
                    $"WHEN Time = '2:30 - 3:00' AND ID = '{StudentID}' THEN '{thursday15.Text}' " +
                    $"WHEN Time = '3:00 - 3:30' AND ID = '{StudentID}' THEN '{thursday16.Text}' " +
                    $"WHEN Time = '3:30 - 4:00' AND ID = '{StudentID}' THEN '{thursday17.Text}' " +
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

        public void UpdateFriday(
    Guna2ComboBox friday1, Guna2ComboBox friday2, Guna2ComboBox friday3, Guna2ComboBox friday4, Guna2ComboBox friday5,
    Guna2ComboBox friday6, Guna2ComboBox friday7, Guna2ComboBox friday8, Guna2ComboBox friday9, Guna2ComboBox friday10,
    Guna2ComboBox friday11, Guna2ComboBox friday12, Guna2ComboBox friday13, Guna2ComboBox friday14, Guna2ComboBox friday15,
    Guna2ComboBox friday16, Guna2ComboBox friday17)
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"UPDATE Schedule SET Friday = " +
                    $"CASE " +
                    $"WHEN Time = '7:00 - 7:30' AND ID = '{StudentID}' THEN '{friday1.Text}' " +
                    $"WHEN Time = '7:30 - 8:30' AND ID = '{StudentID}' THEN '{friday2.Text}' " +
                    $"WHEN Time = '8:30 - 9:00' AND ID = '{StudentID}' THEN '{friday3.Text}' " +
                    $"WHEN Time = '9:00 - 9:30' AND ID = '{StudentID}' THEN '{friday4.Text}' " +
                    $"WHEN Time = '9:30 - 10:00' AND ID = '{StudentID}' THEN '{friday5.Text}' " +
                    $"WHEN Time = '10:00 - 10:30' AND ID = '{StudentID}' THEN '{friday6.Text}' " +
                    $"WHEN Time = '10:30 - 11:00' AND ID = '{StudentID}' THEN '{friday7.Text}' " +
                    $"WHEN Time = '11:00 - 11:30' AND ID = '{StudentID}' THEN '{friday8.Text}' " +
                    $"WHEN Time = '11:30 - 12:00' AND ID = '{StudentID}' THEN '{friday9.Text}' " +
                    $"WHEN Time = '12:00 - 12:30' AND ID = '{StudentID}' THEN '{friday10.Text}' " +
                    $"WHEN Time = '12:30 - 1:00' AND ID = '{StudentID}' THEN '{friday11.Text}' " +
                    $"WHEN Time = '1:00 - 1:30' AND ID = '{StudentID}' THEN '{friday12.Text}' " +
                    $"WHEN Time = '1:30 - 2:00' AND ID = '{StudentID}' THEN '{friday13.Text}' " +
                    $"WHEN Time = '2:00 - 2:30' AND ID = '{StudentID}' THEN '{friday14.Text}' " +
                    $"WHEN Time = '2:30 - 3:00' AND ID = '{StudentID}' THEN '{friday15.Text}' " +
                    $"WHEN Time = '3:00 - 3:30' AND ID = '{StudentID}' THEN '{friday16.Text}' " +
                    $"WHEN Time = '3:30 - 4:00' AND ID = '{StudentID}' THEN '{friday17.Text}' " +
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

        public void showStudent(Guna2ComboBox Student)
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
                    Student.Items.Add(row["firstname"].ToString() + " " + row["lastname"].ToString());
                    StudentID = row["id"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }


        public void Show1(Guna2ComboBox monday1, Guna2ComboBox tuesday1, Guna2ComboBox wednesday1, Guna2ComboBox thursday1, Guna2ComboBox friday1)
        {
            string showsched1 = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '7:00 - 7:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched1, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday1.Text = row["Monday"].ToString();
                    tuesday1.Text = row["Tuesday"].ToString();
                    wednesday1.Text = row["Wednesday"].ToString();
                    thursday1.Text = row["Thursday"].ToString();
                    friday1.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }


        public void Show2(Guna2ComboBox monday2, Guna2ComboBox tuesday2, Guna2ComboBox wednesday2, Guna2ComboBox thursday2, Guna2ComboBox friday2)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '7:30 - 8:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday2.Text = row["Monday"].ToString();
                    tuesday2.Text = row["Tuesday"].ToString();
                    wednesday2.Text = row["Wednesday"].ToString();
                    thursday2.Text = row["Thursday"].ToString();
                    friday2.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show3(Guna2ComboBox monday3, Guna2ComboBox tuesday3, Guna2ComboBox wednesday3, Guna2ComboBox thursday3, Guna2ComboBox friday3)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '8:30 - 9:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday3.Text = row["Monday"].ToString();
                    tuesday3.Text = row["Tuesday"].ToString();
                    wednesday3.Text = row["Wednesday"].ToString();
                    thursday3.Text = row["Thursday"].ToString();
                    friday3.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show4(Guna2ComboBox monday4, Guna2ComboBox tuesday4, Guna2ComboBox wednesday4, Guna2ComboBox thursday4, Guna2ComboBox friday4)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '9:00 - 9:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday4.Text = row["Monday"].ToString();
                    tuesday4.Text = row["Tuesday"].ToString();
                    wednesday4.Text = row["Wednesday"].ToString();
                    thursday4.Text = row["Thursday"].ToString();
                    friday4.Text = row["Friday"].ToString();
                }

            }
            else
            {
               //
            }
            connection.Close();
        }

        public void Show5(Guna2ComboBox monday5, Guna2ComboBox tuesday5, Guna2ComboBox wednesday5, Guna2ComboBox thursday5, Guna2ComboBox friday5)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '9:30 - 10:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday5.Text = row["Monday"].ToString();
                    tuesday5.Text = row["Tuesday"].ToString();
                    wednesday5.Text = row["Wednesday"].ToString();
                    thursday5.Text = row["Thursday"].ToString();
                    friday5.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show6(Guna2ComboBox monday6, Guna2ComboBox tuesday6, Guna2ComboBox wednesday6, Guna2ComboBox thursday6, Guna2ComboBox friday6)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '10:00 - 10:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday6.Text = row["Monday"].ToString();
                    tuesday6.Text = row["Tuesday"].ToString();
                    wednesday6.Text = row["Wednesday"].ToString();
                    thursday6.Text = row["Thursday"].ToString();
                    friday6 .Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show7(Guna2ComboBox monday7, Guna2ComboBox tuesday7, Guna2ComboBox wednesday7, Guna2ComboBox thursday7, Guna2ComboBox friday7)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '10:30 - 11:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday7.Text = row["Monday"].ToString();
                    tuesday7.Text = row["Tuesday"].ToString();
                    wednesday7.Text = row["Wednesday"].ToString();
                    thursday7.Text = row["Thursday"].ToString();
                    friday7.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show8(Guna2ComboBox monday8, Guna2ComboBox tuesday8, Guna2ComboBox wednesday8, Guna2ComboBox thursday8, Guna2ComboBox friday8)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '11:00 - 11:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday8.Text = row["Monday"].ToString();
                    tuesday8.Text = row["Tuesday"].ToString();
                    wednesday8.Text = row["Wednesday"].ToString();
                    thursday8.Text = row["Thursday"].ToString();
                    friday8.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show9(Guna2ComboBox monday9, Guna2ComboBox tuesday9, Guna2ComboBox wednesday9, Guna2ComboBox thursday9, Guna2ComboBox friday9)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '11:30 - 12:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday9.Text = row["Monday"].ToString();
                    tuesday9.Text = row["Tuesday"].ToString();
                    wednesday9.Text = row["Wednesday"].ToString();
                    thursday9.Text = row["Thursday"].ToString();
                    friday9.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show10(Guna2ComboBox monday10, Guna2ComboBox tuesday10, Guna2ComboBox wednesday10, Guna2ComboBox thursday10, Guna2ComboBox friday10)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '12:00 - 12:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday10.Text = row["Monday"].ToString();
                    tuesday10.Text = row["Tuesday"].ToString();
                    wednesday10.Text = row["Wednesday"].ToString();
                    thursday10.Text = row["Thursday"].ToString();
                    friday10.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show11(Guna2ComboBox monday11, Guna2ComboBox tuesday11, Guna2ComboBox wednesday11, Guna2ComboBox thursday11, Guna2ComboBox friday11)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '12:30 - 1:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday11.Text = row["Monday"].ToString();
                    tuesday11.Text = row["Tuesday"].ToString();
                    wednesday11.Text = row["Wednesday"].ToString();
                    thursday11.Text = row["Thursday"].ToString();
                    friday11.Text = row["Friday"].ToString();
                }

            }
            else
            {
               //
            }
            connection.Close();

        }

        public void Show12(Guna2ComboBox monday12, Guna2ComboBox tuesday12, Guna2ComboBox wednesday12, Guna2ComboBox thursday12, Guna2ComboBox friday12)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '1:00 - 1:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday12.Text = row["Monday"].ToString();
                    tuesday12.Text = row["Tuesday"].ToString();
                    wednesday12.Text = row["Wednesday"].ToString();
                    thursday12.Text = row["Thursday"].ToString();
                    friday12.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show13(Guna2ComboBox monday13, Guna2ComboBox tuesday13, Guna2ComboBox wednesday13, Guna2ComboBox thursday13, Guna2ComboBox friday13)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '1:30 - 2:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday13.Text = row["Monday"].ToString();
                    tuesday13.Text = row["Tuesday"].ToString();
                    wednesday13.Text = row["Wednesday"].ToString();
                    thursday13.Text = row["Thursday"].ToString();
                    friday13.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show14(Guna2ComboBox monday14, Guna2ComboBox tuesday14, Guna2ComboBox wednesday14, Guna2ComboBox thursday14, Guna2ComboBox friday14)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '2:00 - 2:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday14.Text = row["Monday"].ToString();
                    tuesday14.Text = row["Tuesday"].ToString();
                    wednesday14.Text = row["Wednesday"].ToString();
                    thursday14.Text = row["Thursday"].ToString();
                    friday14.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show15(Guna2ComboBox monday15, Guna2ComboBox tuesday15, Guna2ComboBox wednesday15, Guna2ComboBox thursday15, Guna2ComboBox friday15)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '2:30 - 3:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday15.Text = row["Monday"].ToString();
                    tuesday15.Text = row["Tuesday"].ToString();
                    wednesday15.Text = row["Wednesday"].ToString();
                    thursday15.Text = row["Thursday"].ToString();
                    friday15.Text = row["Friday"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close();
        }

        public void Show16(Guna2ComboBox monday16, Guna2ComboBox tuesday16, Guna2ComboBox wednesday16, Guna2ComboBox thursday16, Guna2ComboBox friday16)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '3:00 - 3:30' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday16.Text = row["Monday"].ToString();
                    tuesday16.Text = row["Tuesday"].ToString();
                    wednesday16.Text = row["Wednesday"].ToString();
                    thursday16.Text = row["Thursday"].ToString();
                    friday16.Text = row["Friday"].ToString();
                }

            }
            else
            {
               //
            }

            connection.Close();
        }

        public void Show17(Guna2ComboBox monday17, Guna2ComboBox tuesday17, Guna2ComboBox wednesday17, Guna2ComboBox thursday17, Guna2ComboBox friday17)
        {
            string showsched = $"SELECT Monday, Tuesday, Wednesday, Thursday, Friday FROM Schedule WHERE Time = '3:30 - 4:00' AND ID = '{StudentID}'";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showsched, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    monday17.Text = row["Monday"].ToString();
                    tuesday17.Text = row["Tuesday"].ToString();
                    wednesday17.Text = row["Wednesday"].ToString();
                    thursday17.Text = row["Thursday"].ToString();
                    friday17.Text = row["Friday"].ToString();
                }

            }
            else
            {
                MessageBox.Show("No data");
            }
            connection.Close();

        }
    }
}
