using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;

namespace SMARTLEARN.Database
{
    public class DBStudentProfile
    {
        MySqlConnection connection = Host.connection;

        //Set a flag to give the current role to lblrole.txt
        public static string role;

        //Set a flag for user who's log-in
        public static string user;

        //Set a flag for userID
        public static string UserID;

        public void searchbalance(System.Windows.Forms.Label username, System.Windows.Forms.Label rolse, System.Windows.Forms.Label email, System.Windows.Forms.Label mobile, Guna2TextBox firstbalance, Guna2TextBox secondbalance)
        {
            string logadQuery = $"SELECT st.FirstSemesterBalance, st.SecondSemesterBalance, sa.email, sa.mobile FROM studenttable st JOIN studentaccount sa ON st.id = sa.id WHERE st.id = '{UserID}'";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand(logadQuery, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    username.Text = user;
                    rolse.Text = role;

                    email.Text = reader["email"].ToString();
                    mobile.Text = reader["mobile"].ToString();
                    firstbalance.Text = reader["FirstSemesterBalance"].ToString();
                    secondbalance.Text = reader["SecondSemesterBalance"].ToString();
                }
            }
            else
            {
                // Handle case where no data is found
            }

            connection.Close();
        }

    }
}
