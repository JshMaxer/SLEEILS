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

        public void showsched(Guna2DataGridView schedlist, Guna2TextBox strands)
        {
            try
            {
                connection.Close();
                connection.Open();
                string query = $"SELECT time AS 'TIME', monday AS 'Monday', tuesday AS 'Tuesday', wednesday AS 'Wednesday', thursday AS 'Thursday' , friday AS 'Friday' FROM schedule WHERE ID = '{Accounts.UserID}'";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                schedlist.DataSource = dataTable;
                

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connection.Close();

            //------------------------------------------

            string strand = $"SELECT Strand FROM studentaccount WHERE ID = '{Accounts.UserID}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(strand, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    strands.Text = row["strand"].ToString();
                }

            }
            else
            {
                //
            }
            connection.Close(); 
        }

    }
}
