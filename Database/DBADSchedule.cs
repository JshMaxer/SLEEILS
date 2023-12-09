using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBADSchedule
    {
        MySqlConnection connection = Host.connection;

        //Set a flag for ID that you will choose in combobox.
        public static string ID;

        //Load up of the form or Select in section
        public void showStudentID(Guna2ComboBox section, Guna2ComboBox IDS)
        {
            if (section.SelectedIndex == 0)
            {
                string showstudent = "SELECT ID FROM studentaccount_section1";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(showstudent, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                       // IDS.Items.Clear();
                        IDS.Items.Add(row["ID"].ToString());
                    }

                }
                else
                {
                    //
                }
                connection.Close();
            }
            else if (section.SelectedIndex == 1)
            {
                string showstudent = "SELECT ID FROM studentaccount_section2";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(showstudent, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        //IDS.Items.Clear();
                        IDS.Items.Add(row["ID"].ToString());
                    }

                }
                else
                {
                    //
                }
                connection.Close();
            }
            else if (section.SelectedIndex == 2)
            {
                string showstudent = "SELECT ID FROM studentaccount_section3";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(showstudent, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        IDS.Items.Clear();
                        IDS.Items.Add(row["ID"].ToString());
                    }

                }
                else
                {
                    //
                }
                connection.Close();
            }
        }

        //Show after id selected
        public void ShownamePassID(Guna2ComboBox section, Guna2ComboBox IDS, Guna2TextBox fname, Guna2TextBox lname)
        {
            if (section.SelectedIndex == 0)
            {
                string selectnames = $"SELECT ID, firstname, lastname FROM studentaccount_section1 WHERE ID = {IDS.Text}";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectnames, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        fname.Text = row["firstname"].ToString();
                        lname.Text = row["lastname"].ToString();
                        ID = row["ID"].ToString();

                    }
                }
                else
                {
                    // Handle no data
                }
                connection.Close();
            }
            else if (section.SelectedIndex == 1)
            {
                string selectnames = $"SELECT ID, firstname, lastname FROM studentaccount_section2 WHERE ID = {IDS.Text}";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectnames, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        fname.Text = row["firstname"].ToString();
                        lname.Text = row["lastname"].ToString();
                        ID = row["ID"].ToString();
                    }
                }
                else
                {
                    // Handle no data
                }
                connection.Close();
            }
            else if (section.SelectedIndex == 2)
            {
                string selectnames = $"SELECT ID, firstname, lastname FROM studentaccount_section3 WHERE ID = {IDS.Text}";
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectnames, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        fname.Text = row["firstname"].ToString();
                        lname.Text = row["lastname"].ToString();
                        ID = row["ID"].ToString();
                    }
                }
                else
                {
                    // Handle no data
                }
                connection.Close();
            }
        }

        //INSERT PFB SCHED
        public void InsertPFB(Guna2ComboBox section, Guna2ComboBox IDS, Guna2TextBox pfbmonday1, Guna2TextBox pfbmonday2, Guna2TextBox pfbtuesday1, Guna2TextBox pfbtuesday2, Guna2TextBox pfbwednesday1, Guna2TextBox pfbwednesday2, Guna2TextBox pfbthursday1, Guna2TextBox pfbthursday2, Guna2TextBox pfbfriday1, Guna2TextBox pfbfriday2, Guna2MessageDialog messageDialog)
        {
            if (section.SelectedIndex == 0)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section1 SET PFB_Monday = '{pfbmonday1.Text} - {pfbmonday2.Text}', PFB_Tuesday = '{pfbtuesday1.Text} - {pfbtuesday2.Text}', PFB_Wednesday = '{pfbwednesday1.Text} - {pfbwednesday2.Text}', PFB_Thursday = '{pfbthursday1.Text} - {pfbthursday2.Text}', PFB_Friday = '{pfbfriday1.Text} - {pfbfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("PFB Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if(section.SelectedIndex == 1)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section2 SET PFB_Monday = '{pfbmonday1.Text} - {pfbmonday2.Text}', PFB_Tuesday = '{pfbtuesday1.Text} - {pfbtuesday2.Text}', PFB_Wednesday = '{pfbwednesday1.Text} - {pfbwednesday2.Text}', PFB_Thursday = '{pfbthursday1.Text} - {pfbthursday2.Text}', PFB_Friday = '{pfbfriday1.Text} - {pfbfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("PFB Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if (section.SelectedIndex == 2)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section3 SET PFB_Monday = '{pfbmonday1.Text} - {pfbmonday2.Text}', PFB_Tuesday = '{pfbtuesday1.Text} - {pfbtuesday2.Text}', PFB_Wednesday = '{pfbwednesday1.Text} - {pfbwednesday2.Text}', PFB_Thursday = '{pfbthursday1.Text} - {pfbthursday2.Text}', PFB_Friday = '{pfbfriday1.Text} - {pfbfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("PFB Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            connection.Close();
        }


        //INSERT WDD SCHED
        public void InsertWDD(Guna2ComboBox section, Guna2ComboBox IDS, Guna2TextBox wddmonday1, Guna2TextBox wddmonday2, Guna2TextBox wddtuesday1, Guna2TextBox wddtuesday2, Guna2TextBox wddwednesday1, Guna2TextBox wddwednesday2, Guna2TextBox wddthursday1, Guna2TextBox wddthursday2, Guna2TextBox wddfriday1, Guna2TextBox wddfriday2, Guna2MessageDialog messageDialog)
        {
            if (section.SelectedIndex == 0)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section1 SET WDD_Monday = '{wddmonday1.Text} - {wddmonday2.Text}', wdd_Tuesday = '{wddtuesday1.Text} - {wddtuesday2.Text}', wdd_Wednesday = '{wddwednesday1.Text} - {wddwednesday2.Text}', wdd_Thursday = '{wddthursday1.Text} - {wddthursday2.Text}', wdd_Friday = '{wddfriday1.Text} - {wddfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("WDD Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if (section.SelectedIndex == 1)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section2 SET WDD_Monday = '{wddmonday1.Text} - {wddmonday2.Text}', wdd_Tuesday = '{wddtuesday1.Text} - {wddtuesday2.Text}', wdd_Wednesday = '{wddwednesday1.Text} - {wddwednesday2.Text}', wdd_Thursday = '{wddthursday1.Text} - {wddthursday2.Text}', wdd_Friday = '{wddfriday1.Text} - {wddfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("WDD Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if (section.SelectedIndex == 2)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section3 SET WDD_Monday = '{wddmonday1.Text} - {wddmonday2.Text}', wdd_Tuesday = '{wddtuesday1.Text} - {wddtuesday2.Text}', wdd_Wednesday = '{wddwednesday1.Text} - {wddwednesday2.Text}', wdd_Thursday = '{wddthursday1.Text} - {wddthursday2.Text}', wdd_Friday = '{wddfriday1.Text} - {wddfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("WDD Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            connection.Close();
        }

        //INSERT ITE SCHED
        public void InsertITE(Guna2ComboBox section, Guna2ComboBox IDS, Guna2TextBox itemonday1, Guna2TextBox itemonday2, Guna2TextBox itetuesday1, Guna2TextBox itetuesday2, Guna2TextBox itewednesday1, Guna2TextBox itewednesday2, Guna2TextBox itethursday1, Guna2TextBox itethursday2, Guna2TextBox itefriday1, Guna2TextBox itefriday2, Guna2MessageDialog messageDialog)
        {
            if (section.SelectedIndex == 0)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section1 SET ite_Monday = '{itemonday1.Text} - {itemonday2.Text}', ite_Tuesday = '{itetuesday1.Text} - {itetuesday2.Text}', ite_Wednesday = '{itewednesday1.Text} - {itewednesday2.Text}', ite_Thursday = '{itethursday1.Text} - {itethursday2.Text}', ite_Friday = '{itefriday1.Text} - {itefriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("ITE Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if (section.SelectedIndex == 1)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section2 SET ite_Monday = '{itemonday1.Text} - {itemonday2.Text}', ite_Tuesday = '{itetuesday1.Text} - {itetuesday2.Text}', ite_Wednesday = '{itewednesday1.Text} - {itewednesday2.Text}', ite_Thursday = '{itethursday1.Text} - {itethursday2.Text}', ite_Friday = '{itefriday1.Text} - {itefriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("ITE Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if (section.SelectedIndex == 2)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section3 SET ite_Monday = '{itemonday1.Text} - {itemonday2.Text}', ite_Tuesday = '{itetuesday1.Text} - {itetuesday2.Text}', ite_Wednesday = '{itewednesday1.Text} - {itewednesday2.Text}', ite_Thursday = '{itethursday1.Text} - {itethursday2.Text}', ite_Friday = '{itefriday1.Text} - {itefriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("ITE Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            connection.Close();
        }

        //INSERT CHS SCHED
        public void InsertCHS(Guna2ComboBox section, Guna2ComboBox IDS, Guna2TextBox chsmonday1, Guna2TextBox chsmonday2, Guna2TextBox chstuesday1, Guna2TextBox chstuesday2, Guna2TextBox chswednesday1, Guna2TextBox chswednesday2, Guna2TextBox chsthursday1, Guna2TextBox chsthursday2, Guna2TextBox chsfriday1, Guna2TextBox chsfriday2, Guna2MessageDialog messageDialog)
        {
            if (section.SelectedIndex == 0)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section1 SET chs_Monday = '{chsmonday1.Text} - {chsmonday2.Text}', chs_Tuesday = '{chstuesday1.Text} - {chstuesday2.Text}', chs_Wednesday = '{chswednesday1.Text} - {chswednesday2.Text}', chs_Thursday = '{chsthursday1.Text} - {chsthursday2.Text}', chs_Friday = '{chsfriday1.Text} - {chsfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("CHS Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if (section.SelectedIndex == 1)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section2 SET chs_Monday = '{chsmonday1.Text} - {chsmonday2.Text}', chs_Tuesday = '{chstuesday1.Text} - {chstuesday2.Text}', chs_Wednesday = '{chswednesday1.Text} - {chswednesday2.Text}', chs_Thursday = '{chsthursday1.Text} - {chsthursday2.Text}', chs_Friday = '{chsfriday1.Text} - {chsfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("CHS Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            else if (section.SelectedIndex == 2)
            {
                try
                {

                    string insertquery = $"UPDATE schedule_section3 SET chs_Monday = '{chsmonday1.Text} - {chsmonday2.Text}', chs_Tuesday = '{chstuesday1.Text} - {chstuesday2.Text}', chs_Wednesday = '{chswednesday1.Text} - {chswednesday2.Text}', chs_Thursday = '{chsthursday1.Text} - {chsthursday2.Text}', chs_Friday = '{chsfriday1.Text} - {chsfriday2.Text}' WHERE ID = '{IDS.Text}'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertquery, connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        messageDialog.Show("CHS Updated");
                    }
                    else
                    {
                        messageDialog.Show("No rows affected. Update failed.");
                    }
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
            }
            connection.Close();
        }

    }
}
