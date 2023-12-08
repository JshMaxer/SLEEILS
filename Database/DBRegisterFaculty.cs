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

        public void sched(Guna2TextBox firstid, Guna2TextBox secondid)
        {
            string InsertTime1 = $"INSERT INTO schedule_faculty VALUES ('{firstid.Text + secondid.Text}', '-', '-', '-', '-')";
            MySqlCommand cmd1 = new MySqlCommand(InsertTime1, connection);
            cmd1.ExecuteNonQuery();
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
