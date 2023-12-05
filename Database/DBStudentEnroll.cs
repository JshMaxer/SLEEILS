﻿using Guna.UI2.WinForms;
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
            if (strand.SelectedItem.Equals("Information Communication Technology (ICT)"))
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

        }

        public void sched(Guna2TextBox firstid, Guna2TextBox secondid, Guna2ComboBox strand)
        {
            if (strand.SelectedItem.Equals("Information Communication Technology (ICT)"))
            {
                string InsertTime1 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '7:00 - 7:30', '-', '-', '-', '-', '-')";
                string InsertTime2 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '7:30 - 8:30', '-', '-', '-', '-', '-')";
                string InsertTime3= $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '8:30 - 9:00', '-', '-', '-', '-', '-')";
                string InsertTime4 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '9:00 - 9:30', '-', '-', '-', '-', '-')";
                string InsertTime5 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '9:30 - 10:00', '-', '-', '-', '-', '-')";
                string InsertTime6 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '10:00 - 10:30', '-', '-', '-', '-', '-')";
                string InsertTime7 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '10:30 - 11:00', '-', '-', '-', '-', '-')";
                string InsertTime8 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '11:00 - 11:30', '-', '-', '-', '-', '-')";
                string InsertTime9 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '11:30 - 12:00', '-', '-', '-', '-', '-')";
                string InsertTime10 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '12:00 - 12:30', '-', '-', '-', '-', '-')";
                string InsertTime11 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '12:30 - 1:00', '-', '-', '-', '-', '-')";
                string InsertTime12 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '1:00 - 1:30', '-', '-', '-', '-', '-')";
                string InsertTime13 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '1:30 - 2:00', '-', '-', '-', '-', '-')";
                string InsertTime14 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '2:00 - 2:30', '-', '-', '-', '-', '-')";
                string InsertTime15 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '2:30 - 3:00', '-', '-', '-', '-', '-')";
                string InsertTime16 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '3:00 - 3:30', '-', '-', '-', '-', '-')";
                string InsertTime17 = $"INSERT INTO schedule VALUES ('{firstid.Text + secondid.Text}', '3:30 - 4:00', '-', '-', '-', '-', '-')";

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
        }


        public void term(Guna2TextBox firstid, Guna2TextBox secondid, Guna2TextBox fname, Guna2TextBox lname)
        {
            string InsertTerm = $"INSERT INTO studentterm VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '0', '0')";

            MySqlCommand cmd1 = new MySqlCommand(InsertTerm, connection);
            cmd1.ExecuteNonQuery();
        }


        //Insert Query
        public void insertinfo(Guna2TextBox firstid, Guna2TextBox secondid, Guna2ComboBox yearlevel, Guna2ComboBox strand, Guna2ComboBox schoolyear, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2ComboBox gender, Guna2DateTimePicker birth, Guna2TextBox email, Guna2TextBox mobile, Guna2TextBox password)
        {
            connection.Close();
            connection.Open(); // Open the connection

            if (strand.SelectedIndex == 0)
            {
                string InsertQuery = $"INSERT INTO studentaccount VALUES ({firstid.Text + secondid.Text}, '{yearlevel.Text}', '{strand.Text}', {schoolyear.Text}, '{fname.Text}', '{mname.Text}', '{lname.Text}', '{gender.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{email.Text}', '{mobile.Text}', '{password.Text}')";
                MySqlCommand cmd1 = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        subjects(firstid, secondid, fname, lname, strand, yearlevel); // Execute the insertion
                        term(firstid, secondid, fname, lname);
                        sched(firstid, secondid, strand);

                        FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                        FrontEnd.ProcessMessage.firstmessage = "Student has been registered!";
                        FrontEnd.ProcessMessage.secondmessage = "\n\rThank you!";
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
