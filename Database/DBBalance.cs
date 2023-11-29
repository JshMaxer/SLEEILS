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
        public static string firstname;
        public static string lastname;

        public void loaddgv(Guna2DataGridView Studentlist)
        {
            try
            {
                connection.Open();
                string query = "SELECT ID, FirstName, MiddleName, LastName, YearLevel, Strand FROM studentaccount"; // Replace with your table name and column name
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

                // Assuming the columns are in order: Name, LastName
                string StuID = selectedRow.Cells[0].Value.ToString();
                string firstname = selectedRow.Cells[1].Value.ToString();
                string lastName = selectedRow.Cells[3].Value.ToString();

                StudentID = StuID;
                name.Text = firstname + " " + lastName;
            }
        }

        public void save(Guna2TextBox firstsem, Guna2TextBox secondsem)
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"UPDATE studenttable SET FirstSemesterBalance = '{firstsem.Text}', SecondSemesterBalance = '{secondsem.Text}' WHERE id = '{StudentID}'";
                MySqlCommand command = new MySqlCommand(query, connection);


                if (command.ExecuteNonQuery() == 1)
                {
                    FrontEnd.ProcessMessage.firstmessage = "Balance updated";
                    FrontEnd.ProcessMessage.secondmessage = "Successfully!";

                    FrontEnd.ProcessMessage mess = new ProcessMessage();
                    mess.ShowDialog();

                    firstsem.Text = null;
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
