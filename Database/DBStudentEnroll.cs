using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd.Message;
using SMARTLEARN.Model;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    //DATABASE
    public class DBStudentEnroll
    {
        MySqlConnection connection = Host.connection;

        public void USERID(Guna2TextBox firstid, Guna2TextBox secondid)
        {
            Random ran = new Random();
            secondid.Text = ran.Next(100000, 999999).ToString();

            //Check if the ID is existing
            string USERID = $"SELECT ID FROM studentaccount where ID = '{secondid.Text}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(USERID, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows) //If the ID is exist!
            {
                while (row.Read())
                {
                    secondid.Text = ran.Next(100000, 999999).ToString();
                }
            }
            else
            {
                //No random will made
            }
            connection.Close();
        }


        //Insert Query
        public void insertinfo(Guna2TextBox firstID, Guna2TextBox secondID, Guna2ComboBox yearlevel, Guna2ComboBox strand, Guna2TextBox password, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2ComboBox gender, Guna2DateTimePicker birth, Guna2TextBox email, Guna2TextBox mobile)
        {
            string InsertQuery = $"INSERT INTO studentaccount VALUES ({firstID.Text + secondID.Text}, '{yearlevel.Text}', '{strand.Text}', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{gender.Text}', '{birth.Text}', '{email.Text}', '{mobile.Text}', '{password.Text}')";
            string InsertStudentTable = $"INSERT INTO studenttable VALUES ({firstID.Text + secondID.Text}, '{fname.Text}', '{lname.Text}', '{strand.Text}', '0', '0', '0', '0', '0', '0')";
            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand(InsertQuery, connection);
            MySqlCommand cmd2 = new MySqlCommand(InsertStudentTable, connection);

            try
            {
                if (cmd1.ExecuteNonQuery() == 1 && cmd2.ExecuteNonQuery() == 1)
                {
                    FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                    FrontEnd.ProcessMessage.firstmessage = "STUDENT HAS BEEN";
                    FrontEnd.ProcessMessage.secondmessage = "REGISTERED! \n\rTHANK YOU!";
                    pm.Show();

                }
                else
                {
                    FrontEnd.Message.ProcessDeclineMessage PDM = new FrontEnd.Message.ProcessDeclineMessage();
                    ProcessDeclineMessage.message = "STUDENT CANNOT\r\nBE PROCESS!";
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
