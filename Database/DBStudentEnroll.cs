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

        //Insert Query
        public void insertinfo(Guna2ComboBox admittype, Guna2ComboBox yearlevel, Guna2ComboBox schoolyear, Guna2ComboBox term, Guna2RadioButton ICT, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2TextBox suffix, Guna2ComboBox gender, Guna2ComboBox status, Guna2TextBox Citizenship, Guna2DateTimePicker birth, Guna2TextBox birthplace, Guna2TextBox religion, Guna2TextBox address, Guna2TextBox email, Guna2TextBox mobile, Guna2TextBox telephone, Guna2TextBox gfname, Guna2TextBox gmname, Guna2TextBox glname, Guna2TextBox gsuffix, Guna2ComboBox ggender, Guna2ComboBox gstatus, Guna2TextBox gCitizenship, Guna2DateTimePicker gbirth, Guna2TextBox gbirthplace, Guna2TextBox greligion, Guna2TextBox gaddress, Guna2TextBox gemail, Guna2TextBox gmobile, Guna2TextBox gtelephone, Guna2TextBox grelationship, Guna2TextBox goccupation)
        {
            //-----------------------------------------------------------------------------------
            //CHECK ID FOR UNIQUENESS

            Random ran = new Random();
            string iD = 2000 + ran.Next(100000, 999999).ToString();
            
            //Check if the ID is existing
            string USERID = $"SELECT ID FROM studentaccount WHERE ID = '{iD}'";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(USERID, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows) //If the ID is exist!
            {
                while (row.Read())
                {
                    iD = 2000 + ran.Next(100000, 999999).ToString();
                }
            }
            else
            {
                //No random will made
            }
            connection.Close();

            //-----------------------------------------------------------------------------------

            if (Backend.BEStudentEnroll.listtype == "Type of Student: New")
            {
                string InsertQuery = $"INSERT INTO studentaccount VALUES ({iD}, 'New', '{admittype.Text}', '{yearlevel.Text}', '{schoolyear.Text}', '{term.Text}', '{ICT.Text}', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{suffix.Text}', '{gender.Text}', '{status.Text}', '{Citizenship.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{birthplace.Text}', '{religion.Text}', '{address.Text}', '{email.Text}', '{mobile.Text}', '{telephone.Text}', '{gfname.Text}', '{gmname.Text}', '{glname.Text}', '{gsuffix.Text}', '{ggender.Text}', '{gstatus.Text}', '{gCitizenship.Text}', '{gbirth.Value.ToString("yyyy-MM-dd")}', '{gbirthplace.Text}', '{gaddress.Text}', '{gemail.Text}', '{gmobile.Text}', '{gtelephone.Text}', '{grelationship.Text}', '{goccupation.Text}', '1234', 'Not Activated')";
                connection.Open();
                MySqlCommand cmd1 = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                        FrontEnd.ProcessMessage.firstmessage = "YOUR ENROLLMENT IS";
                        FrontEnd.ProcessMessage.secondmessage = "BEING PROCESS! \n\rTHANK YOU!";
                        pm.Show();

                    }
                    else
                    {
                        FrontEnd.Message.ProcessDeclineMessage PDM = new FrontEnd.Message.ProcessDeclineMessage();
                        ProcessDeclineMessage.message = "YOUR ENROLLMENT CANNOT\r\nBE PROCESS!";
                        PDM.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string InsertQuery = $"INSERT INTO studentaccount VALUES ({iD}, 'Existing', '{admittype.Text}', '{yearlevel.Text}', '{schoolyear.Text}', '{term.Text}', '{ICT.Text}', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{suffix.Text}', '{gender.Text}', '{status.Text}', '{Citizenship.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{birthplace.Text}', '{religion.Text}', '{address.Text}', '{email.Text}', '{mobile.Text}', '{telephone.Text}', '{gfname.Text}', '{gmname.Text}', '{glname.Text}', '{gsuffix.Text}', '{ggender.Text}', '{gstatus.Text}', '{gCitizenship.Text}', '{gbirth.Value.ToString("yyyy-MM-dd")}', '{gbirthplace.Text}', '{gaddress.Text}', '{gemail.Text}', '{gmobile.Text}', '{gtelephone.Text}', '{grelationship.Text}', '{goccupation.Text}', '1234', 'Not Activated')";
                connection.Open();
                MySqlCommand cmd2 = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                        FrontEnd.ProcessMessage.firstmessage = "YOUR ENROLLMENT IS";
                        FrontEnd.ProcessMessage.secondmessage = "BEING PROCESS! \n\rTHANK YOU!";
                        pm.Show();

                    }
                    else
                    {
                        FrontEnd.Message.ProcessDeclineMessage PDM = new FrontEnd.Message.ProcessDeclineMessage();
                        ProcessDeclineMessage.message = "YOUR ENROLLMENT CANNOT\r\nBE PROCESS!";
                        PDM.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            connection.Close();

        }

    }
}
