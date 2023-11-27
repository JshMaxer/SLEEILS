using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd.Message;
using SMARTLEARN.Model;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBRegisterAdmin
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
                    FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                    FrontEnd.ProcessMessage.firstmessage = "YOU'RE NOW"; 
                    FrontEnd.ProcessMessage.secondmessage = "REGISTERED!\n\rTHANK YOU!";
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
