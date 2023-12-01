using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBStudentProfile
    {
        MySqlConnection connection = Host.connection;

        public void searchbalance(System.Windows.Forms.Label username, System.Windows.Forms.Label rolse, System.Windows.Forms.Label email, System.Windows.Forms.Label mobile, Guna2TextBox firstbalance, Guna2TextBox secondbalance)
        {
            string logadQuery = $"SELECT FirstSemBalance, SecondSemBalance FROM studentterm WHERE ID = '{Model.Accounts.UserID}'";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand(logadQuery, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    username.Text = Model.Accounts.user;
                    rolse.Text = Model.Accounts.role;

                    email.Text = Model.Accounts.email;
                    mobile.Text = Model.Accounts.mobile;

                    firstbalance.Text = row["FirstSemBalance"].ToString();
                    secondbalance.Text = row["SecondSemBalance"].ToString();
                }
            }
            else
            {
                // Handle case where no data is found
                MessageBox.Show("No balance");
            }

            connection.Close();
        }

    }
}
