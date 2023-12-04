﻿using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd.Message;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SMARTLEARN.Database
{
    public class DBFAForgotpass
    {
        MySqlConnection connection = Host.connection;

        public void forgot(Guna2TextBox ID, ErrorProvider error)
        {
            string searchID = $"SELECT userID, first_name, last_name FROM facultyaccount WHERE userid = '{ID.Text}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(searchID, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                row.Read(); // Move to the first row
                string fname = row["first_name"].ToString();
                string lname = row["last_name"].ToString();

                row.Close(); // Close the reader after retrieving data

                //Insert Query
                string InsertStudent = $"INSERT INTO reset_password VALUES ('{ID.Text}', '{fname}', '{lname}', 'FACULTY')";
                MySqlCommand cmd1 = new MySqlCommand(InsertStudent, connection);

                try
                {
                    int rowsAffected = cmd1.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                        FrontEnd.ProcessMessage.firstmessage = "REQUEST";
                        FrontEnd.ProcessMessage.secondmessage = "SUBMITTED! \n\rTHANK YOU!";
                        pm.Show();
                    }
                    else
                    {
                        FrontEnd.Message.ProcessDeclineMessage PDM = new FrontEnd.Message.ProcessDeclineMessage();
                        ProcessDeclineMessage.message = "FACULTY CANNOT\r\nBE PROCESSED!";
                        PDM.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("REQUEST ALREADY BEEN SUBMITTED!\nAfter ADMIN Confirmed your submission, your password will set as default (1234).", "WAIT FOR ADMIN TO RESET YOUR PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                error.SetError(ID, "Cannot find USERID");
            }

            connection.Close(); // Close the connection outside the conditional block
        }


    }
}
