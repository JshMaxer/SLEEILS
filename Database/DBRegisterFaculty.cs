using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd.Message;
using SMARTLEARN.Model;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBRegisterFaculty
    {
        MySqlConnection connection = Host.connection;

        public void USERID(Guna2TextBox firstid, Guna2TextBox userid)
        {
            Random ran = new Random();
            userid.Text = ran.Next(100000, 999999).ToString();

            //Check if the ID is existing
            string USERID = $"SELECT UserID FROM facultyaccount where UserID = '{userid.Text}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(USERID, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows) //If the ID is exist!
            {
                while (row.Read())
                {
                    userid.Text = ran.Next(100000, 999999).ToString();
                }
            }
            else
            {
                //No random will made
            }
            connection.Close();
        }

        public void sched(Guna2TextBox firstid, Guna2TextBox secondid)
        {
            string InsertTime1 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '7:00 - 7:30', '-', '-', '-', '-', '-')";
            string InsertTime2 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '7:30 - 8:30', '-', '-', '-', '-', '-')";
            string InsertTime3 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '8:30 - 9:00', '-', '-', '-', '-', '-')";
            string InsertTime4 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '9:00 - 9:30', '-', '-', '-', '-', '-')";
            string InsertTime5 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '9:30 - 10:00', '-', '-', '-', '-', '-')";
            string InsertTime6 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '10:00 - 10:30', '-', '-', '-', '-', '-')";
            string InsertTime7 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '10:30 - 11:00', '-', '-', '-', '-', '-')";
            string InsertTime8 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '11:00 - 11:30', '-', '-', '-', '-', '-')";
            string InsertTime9 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '11:30 - 12:00', '-', '-', '-', '-', '-')";
            string InsertTime10 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '12:00 - 12:30', '-', '-', '-', '-', '-')";
            string InsertTime11 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '12:30 - 1:00', '-', '-', '-', '-', '-')";
            string InsertTime12 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '1:00 - 1:30', '-', '-', '-', '-', '-')";
            string InsertTime13 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '1:30 - 2:00', '-', '-', '-', '-', '-')";
            string InsertTime14 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '2:00 - 2:30', '-', '-', '-', '-', '-')";
            string InsertTime15 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '2:30 - 3:00', '-', '-', '-', '-', '-')";
            string InsertTime16 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '3:00 - 3:30', '-', '-', '-', '-', '-')";
            string InsertTime17 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '3:30 - 4:00', '-', '-', '-', '-', '-')";

            MySqlCommand cmd1 = new MySqlCommand(InsertTime1, connection);
            MySqlCommand cmd2 = new MySqlCommand(InsertTime2, connection);
            MySqlCommand cmd3 = new MySqlCommand(InsertTime3, connection);
            MySqlCommand cmd4 = new MySqlCommand(InsertTime4, connection);
            MySqlCommand cmd5 = new MySqlCommand(InsertTime5, connection);
            MySqlCommand cmd6 = new MySqlCommand(InsertTime6, connection);
            MySqlCommand cmd7 = new MySqlCommand(InsertTime7, connection);
            MySqlCommand cmd8 = new MySqlCommand(InsertTime8, connection);
            MySqlCommand cmd9 = new MySqlCommand(InsertTime9, connection);
            MySqlCommand cmd10 = new MySqlCommand(InsertTime10, connection);
            MySqlCommand cmd11 = new MySqlCommand(InsertTime11, connection);
            MySqlCommand cmd12 = new MySqlCommand(InsertTime12, connection);
            MySqlCommand cmd13 = new MySqlCommand(InsertTime13, connection);
            MySqlCommand cmd14 = new MySqlCommand(InsertTime14, connection);
            MySqlCommand cmd15 = new MySqlCommand(InsertTime15, connection);
            MySqlCommand cmd16 = new MySqlCommand(InsertTime16, connection);
            MySqlCommand cmd17 = new MySqlCommand(InsertTime17, connection);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            cmd7.ExecuteNonQuery();
            cmd8.ExecuteNonQuery();
            cmd9.ExecuteNonQuery();
            cmd10.ExecuteNonQuery();
            cmd11.ExecuteNonQuery();
            cmd12.ExecuteNonQuery();
            cmd13.ExecuteNonQuery();
            cmd14.ExecuteNonQuery();
            cmd15.ExecuteNonQuery();
            cmd16.ExecuteNonQuery();
            cmd17.ExecuteNonQuery();
        }

        //Insert Query
        public void insertinfo(Guna2TextBox firstid, Guna2TextBox userid, Guna2ComboBox gender, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2ComboBox department, Guna2DateTimePicker birthdate, Guna2TextBox mobile, Guna2TextBox email, Guna2TextBox password)
        {
            string InsertQuery = $"INSERT INTO facultyaccount VALUES ('{firstid.Text + userid.Text}', '{gender.Text}', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{department.Text}', '{birthdate.Value.ToString("yyyy-MM-dd")}', '{mobile.Text}', '{email.Text}', '{password.Text}')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    sched(firstid, userid);
                    FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                    FrontEnd.ProcessMessage.firstmessage = "Faculty has been registered!";
                    FrontEnd.ProcessMessage.secondmessage = "\n\rThank you!";
                    pm.Show();
                }
                else
                {
                    FrontEnd.Message.ProcessDeclineMessage PDM = new FrontEnd.Message.ProcessDeclineMessage();
                    ProcessDeclineMessage.message = "REGISTER CANNOT\r\nBE PROCESS!";
                    PDM.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

    }

}
