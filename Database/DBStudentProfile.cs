using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBStudentProfile
    {
        MySqlConnection connection = Host.connection;

        public void searchbalance(System.Windows.Forms.Label username, System.Windows.Forms.Label rolse, System.Windows.Forms.Label email, System.Windows.Forms.Label id, System.Windows.Forms.Label mobile, Guna2TextBox firstmisc, Guna2TextBox firstpta, Guna2TextBox firstother, Guna2TextBox firstbalance, Guna2TextBox secondmisc, Guna2TextBox secondpta, Guna2TextBox secondother, Guna2TextBox secondbalance, Guna2MessageDialog message)
        {
            string logadQuery = $"SELECT firstsem_Miscellaneous, firstsem_pta, firstsem_Other_school_fees, FirstSemBalance, secondsem_Miscellaneous, secondsem_pta, secondsem_Other_school_fees, SecondSemBalance FROM studentbalance WHERE ID = '{Model.Accounts.UserID}'";

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
                    id.Text = Model.Accounts.UserID;
                    mobile.Text = Model.Accounts.mobile;


                    firstmisc.Text = row["firstsem_Miscellaneous"].ToString();
                    firstpta.Text = row["firstsem_PTA"].ToString();
                    firstother.Text = row["firstsem_Other_school_fees"].ToString();
                    firstbalance.Text = row["FirstSemBalance"].ToString();


                    secondmisc.Text = row["secondsem_Miscellaneous"].ToString();
                    secondpta.Text = row["secondsem_PTA"].ToString();
                    secondother.Text = row["secondsem_Other_school_fees"].ToString();
                    secondbalance.Text = row["secondSemBalance"].ToString();
                }
            }
            else
            {
                message.Show("No balance");
            }

            connection.Close();
        }

    }
}
