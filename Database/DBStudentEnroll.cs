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

        public void subjects(Guna2TextBox firstid, Guna2TextBox secondid, Guna2TextBox fname, Guna2TextBox lname, Guna2ComboBox strand, Guna2ComboBox yearlevel, Guna2ComboBox section)
        {
            if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 0)
            {
                string Prog = $"INSERT INTO pfb_section1 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string Web = $"INSERT INTO wdd_section1 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string IT = $"INSERT INTO ite_section1 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string Com = $"INSERT INTO chs_section1 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";

                MySqlCommand cmd1 = new MySqlCommand(Prog, connection);
                MySqlCommand cmd2 = new MySqlCommand(Web, connection);
                MySqlCommand cmd3 = new MySqlCommand(IT, connection);
                MySqlCommand cmd4 = new MySqlCommand(Com, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
            }
            else if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 1)
            {
                string Prog = $"INSERT INTO pfb_section2 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string Web = $"INSERT INTO wdd_section2 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string IT = $"INSERT INTO ite_section2 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string Com = $"INSERT INTO chs_section2 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";

                MySqlCommand cmd1 = new MySqlCommand(Prog, connection);
                MySqlCommand cmd2 = new MySqlCommand(Web, connection);
                MySqlCommand cmd3 = new MySqlCommand(IT, connection);
                MySqlCommand cmd4 = new MySqlCommand(Com, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
            }
            else if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 2)
            {
                string Prog = $"INSERT INTO pfb_section3 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string Web = $"INSERT INTO wdd_section3 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string IT = $"INSERT INTO ite_section3 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";
                string Com = $"INSERT INTO chs_section3 (id, firstname, lastname, course, yearlevel, firstperiodgrades, secondperiodgrades, firstsemaverage, thirdperiodgrades, fourthperiodgrades, secondsemaverage) VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '{strand.Text}', '{yearlevel.Text}', '0', '0', '0', '0', '0', '0')";

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

        public void sched(Guna2TextBox firstid, Guna2TextBox secondid, Guna2ComboBox strand, Guna2ComboBox section)
        {
            if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 0)
            {
                string InsertTime1 = $"INSERT INTO schedule_section1 VALUES ('{firstid.Text + secondid.Text}', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', '-')";
                MySqlCommand cmd1 = new MySqlCommand(InsertTime1, connection);
                cmd1.ExecuteNonQuery();
            }
            else if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 1)
            {
                string InsertTime1 = $"INSERT INTO schedule_section2 VALUES ('{firstid.Text + secondid.Text}', '-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', '-')";
                MySqlCommand cmd1 = new MySqlCommand(InsertTime1, connection);
                cmd1.ExecuteNonQuery();
            }
            else if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 2)
            {
                string InsertTime1 = $"INSERT INTO schedule_section3 VALUES ('{firstid.Text + secondid.Text}', '-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', '-')";
                MySqlCommand cmd1 = new MySqlCommand(InsertTime1, connection);
                cmd1.ExecuteNonQuery();
            }
        }


        public void balance(Guna2TextBox firstid, Guna2TextBox secondid, Guna2TextBox fname, Guna2TextBox lname)
        {
            string InsertTerm = $"INSERT INTO studentbalance VALUES ('{firstid.Text + secondid.Text}', '{fname.Text}', '{lname.Text}', '0', '0')";

            MySqlCommand cmd1 = new MySqlCommand(InsertTerm, connection);
            cmd1.ExecuteNonQuery();
        }


        //Insert Query
        public void insertinfo(Guna2TextBox firstid, Guna2TextBox secondid, Guna2ComboBox yearlevel, Guna2ComboBox strand, Guna2ComboBox schoolyear, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2ComboBox gender, Guna2DateTimePicker birth, Guna2TextBox email, Guna2TextBox mobile, Guna2TextBox password, Guna2ComboBox section, Guna2MessageDialog messageDialog)
        {
            connection.Close();
            connection.Open(); // Open the connection

            if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 0)
            {
                string InsertQuery = $"INSERT INTO studentaccount_section1 VALUES ({firstid.Text + secondid.Text}, '{yearlevel.Text}', '{strand.Text}', {schoolyear.Text}, 'Section 1', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{gender.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{email.Text}', '{mobile.Text}', '{password.Text}')";
                MySqlCommand cmd1 = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        subjects(firstid, secondid, fname, lname, strand, yearlevel, section); // Execute the insertion
                        balance(firstid, secondid, fname, lname);
                        sched(firstid, secondid, strand, section);

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
                    messageDialog.Show(ex.Message);
                }
            }
            else if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 1)
            {
                string InsertQuery = $"INSERT INTO studentaccount_section2 VALUES ({firstid.Text + secondid.Text}, '{yearlevel.Text}', '{strand.Text}', {schoolyear.Text}, 'Section 2', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{gender.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{email.Text}', '{mobile.Text}', '{password.Text}')";
                MySqlCommand cmd1 = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        subjects(firstid, secondid, fname, lname, strand, yearlevel, section); // Execute the insertion
                        balance(firstid, secondid, fname, lname);
                        sched(firstid, secondid, strand, section);

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
                    messageDialog.Show(ex.Message);
                }
            }
            else if (strand.SelectedItem.Equals("Information Communication Technology (ICT)") && section.SelectedIndex == 2)
            {
                string InsertQuery = $"INSERT INTO studentaccount_section3 VALUES ({firstid.Text + secondid.Text}, '{yearlevel.Text}', '{strand.Text}', {schoolyear.Text}, 'Section 3', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{gender.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{email.Text}', '{mobile.Text}', '{password.Text}')";
                MySqlCommand cmd1 = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        subjects(firstid, secondid, fname, lname, strand, yearlevel, section); // Execute the insertion
                        balance(firstid, secondid, fname, lname);
                        sched(firstid, secondid, strand, section);

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
                    messageDialog.Show(ex.Message);
                }
            }
            connection.Close(); // Close the connection
        }


    }
}
