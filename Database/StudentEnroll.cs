using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;

namespace SMARTLEARN.Database
{
    //DATABASE
    public class StudentEnroll
    {
        MySqlConnection connection = Host.connection;

        //Insert Query
        public void insertinfo(Guna2ComboBox admittype, Guna2ComboBox yearlevel, Guna2ComboBox schoolyear, Guna2ComboBox term, Guna2RadioButton ICT, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2TextBox suffix, Guna2ComboBox gender, Guna2ComboBox status, Guna2TextBox Citizenship, Guna2DateTimePicker birth, Guna2TextBox birthplace, Guna2TextBox religion, Guna2TextBox address, Guna2TextBox email, Guna2TextBox mobile, Guna2TextBox telephone, Guna2TextBox gfname, Guna2TextBox gmname, Guna2TextBox glname, Guna2TextBox gsuffix, Guna2ComboBox ggender, Guna2ComboBox gstatus, Guna2TextBox gCitizenship, Guna2DateTimePicker gbirth, Guna2TextBox gbirthplace, Guna2TextBox greligion, Guna2TextBox gaddress, Guna2TextBox gemail, Guna2TextBox gmobile, Guna2TextBox gtelephone, Guna2TextBox grelationship, Guna2TextBox goccupation)
        {
            string InsertQuery = $"INSERT INTO studentaccount VALUES ('{Backend.StudentEnroll.listtype}', '{admittype.Text}', '{yearlevel.Text}', '{schoolyear.Text}', '{term.Text}', '{ICT.Text}', '{fname.Text}', '{mname.Text}', '{lname.Text}', '{suffix.Text}', '{gender.Text}', '{status.Text}', '{Citizenship.Text}', '{birth.Value.ToString("yyyy-MM-dd")}', '{birthplace.Text}', '{religion.Text}', '{address.Text}', '{email.Text}', '{mobile.Text}', '{telephone.Text}', '{gfname.Text}', '{gmname.Text}', '{glname.Text}', '{gsuffix.Text}', '{ggender.Text}', '{gstatus.Text}', '{gCitizenship.Text}', '{gbirth.Value.ToString("yyyy-MM-dd")}', '{gbirthplace.Text}', '{gaddress.Text}', '{gemail.Text}', '{gmobile.Text}', '{gtelephone.Text}', '{grelationship.Text}', '{goccupation.Text}')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);
        

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    FrontEnd.ProcessMessage pm = new FrontEnd.ProcessMessage();
                    pm.Show();

                }
                else
                {
                    FrontEnd.Message.ProcessDeclineMessage PDM = new FrontEnd.Message.ProcessDeclineMessage();
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
