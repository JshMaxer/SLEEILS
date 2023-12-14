using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.FrontEnd;
using SMARTLEARN.Model;
using System.Data;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBBalance
    {
        MySqlConnection connection = Host.connection;

        public static string StudentID;

        public void loaddgv(Guna2DataGridView Studentlist)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM studentbalance";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Studentlist.DataSource = dataTable;

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void selection(Guna2DataGridView Studentlist, System.Windows.Forms.Label name)
        {
            if (Studentlist.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Studentlist.SelectedRows[0];

                string StuID = selectedRow.Cells[0].Value.ToString();
                string firstname = selectedRow.Cells[1].Value.ToString();
                string lastName = selectedRow.Cells[2].Value.ToString();

                StudentID = StuID;
                name.Text = firstname + " " + lastName;
            }
        }

        public void save(Guna2DataGridView studentlist,Guna2TextBox firstMisc, Guna2TextBox firstPTA, Guna2TextBox firstother ,Guna2TextBox firstsem, Guna2TextBox secondMisc, Guna2TextBox secondPTA, Guna2TextBox secondother, Guna2TextBox secondsem)
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"UPDATE studentbalance SET firstsem_Miscellaneous = '{firstMisc.Text}', firstsem_PTA = '{firstPTA.Text}', firstsem_Other_school_fees = '{firstother.Text}', FirstSemBalance = '{firstsem.Text}', secondsem_Miscellaneous = '{secondMisc.Text}', secondsem_PTA = '{secondPTA.Text}', secondsem_Other_school_fees = '{secondother.Text}', SecondSemBalance = '{secondsem.Text}' WHERE id = '{StudentID}'";
                MySqlCommand command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    FrontEnd.ProcessMessage.firstmessage = "Balance updated";
                    FrontEnd.ProcessMessage.secondmessage = "Successfully!";

                    FrontEnd.ProcessMessage mess = new ProcessMessage();
                    mess.ShowDialog();

                    connection.Close();
                    loaddgv(studentlist);

                    firstMisc.Text = null;
                    firstPTA.Text = null;
                    firstother.Text = null;
                    firstsem.Text = null;

                    secondMisc.Text = null;
                    secondPTA.Text = null;
                    secondother.Text = null;
                    secondsem.Text = null;

                }
                else
                {
                    MessageBox.Show("No rows affected. Update failed.");
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
