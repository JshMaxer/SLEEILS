using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Data;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBSTSchedule
    {
        MySqlConnection connection = Host.connection;

        public void showsched(Guna2DataGridView schedlist, Guna2MessageDialog messageDialog)
        {
            if (Accounts.role == "STUDENT" && Accounts.section == "Section 1")
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    string query = $"SELECT PFB_Monday, PFB_Tuesday, PFB_Wednesday, PFB_Thursday, PFB_Friday, WDD_Monday, WDD_Tuesday, WDD_Wednesday, WDD_Thursday, WDD_Friday, ITe_Monday, ITe_Tuesday, ITe_Wednesday, ITe_Thursday, ITe_Friday, CHS_Monday, CHS_Tuesday, CHS_Wednesday, CHS_Thursday, CHS_Friday FROM schedule_section1 WHERE ID = '{Accounts.UserID}'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    schedlist.DataSource = dataTable;


                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }

                connection.Close();
            }
            //------------------------------------------
            else if (Accounts.role == "STUDENT" && Accounts.section == "Section 2")
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    string query = $"SELECT PFB_Monday, PFB_Tuesday, PFB_Wednesday, PFB_Thursday, PFB_Friday, WDD_Monday, WDD_Tuesday, WDD_Wednesday, WDD_Thursday, WDD_Friday, ITe_Monday, ITe_Tuesday, ITe_Wednesday, ITe_Thursday, ITe_Friday, CHS_Monday, CHS_Tuesday, CHS_Wednesday, CHS_Thursday, CHS_Friday FROM schedule_section2 WHERE ID = '{Accounts.UserID}'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    schedlist.DataSource = dataTable;


                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }

                connection.Close();
            }
            //------------------------------------------
            else if (Accounts.role == "STUDENT" && Accounts.section == "Section 3")
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    string query = $"SELECT PFB_Monday, PFB_Tuesday, PFB_Wednesday, PFB_Thursday, PFB_Friday, WDD_Monday, WDD_Tuesday, WDD_Wednesday, WDD_Thursday, WDD_Friday, ITe_Monday, ITe_Tuesday, ITe_Wednesday, ITe_Thursday, ITe_Friday, CHS_Monday, CHS_Tuesday, CHS_Wednesday, CHS_Thursday, CHS_Friday FROM schedule_section3 WHERE ID = '{Accounts.UserID}'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    schedlist.DataSource = dataTable;


                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }

                connection.Close();
            }


            else if (Accounts.role == "FACULTY")
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    string query = $"SELECT PFB_Monday, PFB_Tuesday, PFB_Wednesday, PFB_Thursday, PFB_Friday, WDD_Monday, WDD_Tuesday, WDD_Wednesday, WDD_Thursday, WDD_Friday, ITe_Monday, ITe_Tuesday, ITe_Wednesday, ITe_Thursday, ITe_Friday, CHS_Monday, CHS_Tuesday, CHS_Wednesday, CHS_Thursday, CHS_Friday FROM schedule_faculty WHERE ID = '{Accounts.UserID}'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    schedlist.DataSource = dataTable;


                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
                connection.Close();

            }
        }

    }
}
