using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd.Message;
using SMARTLEARN.Model;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SMARTLEARN.Database
{
    //DATABASE
    public class DBStudentEnroll
    {
        MySqlConnection connection = Host.connection;

        public void USERID(Guna2TextBox secondid)
        {
            connection.Close();
            connection.Open();

            Random ran = new Random();
            secondid.Text = ran.Next(100000, 999999).ToString();

            //Check if the ID is existing
            string USERID = $"SELECT ID FROM studentaccount where ID = '{secondid.Text}'";
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

        public void subjects(Guna2TextBox firstid, Guna2TextBox secondid, Guna2TextBox fname, Guna2TextBox lname, Guna2ComboBox strand, Guna2ComboBox yearlevel)
        {
            string Prog = $"INSERT INTO programmingforbeginners (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
            string Web = $"INSERT INTO webdevelopmentdesign (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
            string IT = $"INSERT INTO itessentials (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
            string Com = $"INSERT INTO computerhardwareservicing (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
            
            MySqlCommand cmd1 = new MySqlCommand(Prog, connection);
            MySqlCommand cmd2 = new MySqlCommand(Web, connection);
            MySqlCommand cmd3 = new MySqlCommand(IT, connection);
            MySqlCommand cmd4 = new MySqlCommand(Com, connection);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
        }


        public void term(Guna2TextBox firstid, Guna2TextBox secondid, Guna2TextBox fname, Guna2TextBox lname)
        {
            string InsertTerm = $"INSERT INTO studentterm VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '0', '0')";

            MySqlCommand cmd1 = new MySqlCommand(InsertTerm, connection);
            cmd1.ExecuteNonQuery();
        }


        //Insert Query
        public void insertinfo(Guna2TextBox firstid, Guna2TextBox secondid,Guna2ComboBox yearlevel, Guna2ComboBox strand, Guna2ComboBox schoolyear, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2ComboBox gender, Guna2DateTimePicker birth, Guna2TextBox email, Guna2TextBox mobile, Guna2TextBox password)
        {
            connection.Close();
            connection.Open(); // Open the connection

            if (strand.SelectedIndex == 0)
            {
                string InsertQuery = $"INSERT INTO studentaccount VALUES ({firstid.Text + secondid.Text}, '{yearlevel.Text}', '{strand.Text}', {schoolyear.Text}, '{fname.Text}', '{mname.Text}', '{lname.Text}', '{gender.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{email.Text}', '{mobile.Text}', '{password.Text}')";
                subjects(firstid, secondid, fname, lname, strand, yearlevel); // Execute the insertion
                term(firstid, secondid, fname, lname);

                MySqlCommand cmd1 = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (cmd1.ExecuteNonQuery() == 1)
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
            }

            connection.Close(); // Close the connection
        }


    }
}
