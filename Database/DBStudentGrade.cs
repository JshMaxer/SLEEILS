using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBStudentGrade
    {
        MySqlConnection connection = Host.connection;

        public void Display(Guna2DataGridView dgvstudent, Guna2ComboBox semester)
        {
            if(semester.SelectedItem == null)
            {
                //
            }
            else if(semester.SelectedIndex == 0)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT " +
                                   "pb.FirstPeriodGrades AS 'First Period Grades (Programming for Beginners)', " +
                                   "pb.SecondPeriodGrades AS 'Second Period Grades (Programming for Beginners)', " +
                                   "wd.FirstPeriodGrades AS 'First Period Grades (Web Development Design)', " +
                                   "wd.SecondPeriodGrades AS 'Second Period Grades (Web Development Design)', " +
                                   "it.FirstPeriodGrades AS 'First Period Grades (IT Essentials)', " +
                                   "it.SecondPeriodGrades AS 'Second Period Grades (IT Essentials)', " +
                                   "chs.FirstPeriodGrades AS 'First Period Grades (Computer Hardware Servicing)', " +
                                   "chs.SecondPeriodGrades AS 'Second Period Grades (Computer Hardware Servicing)' " +
                                   "FROM programmingforbeginners pb " +
                                   "JOIN webdevelopmentdesign wd ON pb.id = wd.id " +
                                   "JOIN itessentials it ON pb.id = it.id " +
                                   "JOIN computerhardwareservicing chs ON pb.id = chs.id";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvstudent.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else if(semester.SelectedIndex == 1)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT " +
                                   "pb.ThirdPeriodGrades AS 'Third Period Grades (Programming for Beginners)', " +
                                   "pb.FourthPeriodGrades AS 'Fourth Period Grades (Programming for Beginners)', " +
                                   "wd.ThirdPeriodGrades AS 'Third Period Grades (Web Development Design)', " +
                                   "wd.FourthPeriodGrades AS 'Fourth Period Grades (Web Development Design)', " +
                                   "it.ThirdPeriodGrades AS 'Third Period Grades (IT Essentials)', " +
                                   "it.FourthPeriodGrades AS 'Fourth Period Grades (IT Essentials)', " +
                                   "chs.ThirdPeriodGrades AS 'Third Period Grades (Computer Hardware Servicing)', " +
                                   "chs.FourthPeriodGrades AS 'Fourth Period Grades (Computer Hardware Servicing)' " +
                                   "FROM programmingforbeginners pb " +
                                   "JOIN webdevelopmentdesign wd ON pb.id = wd.id " +
                                   "JOIN itessentials it ON pb.id = it.id " +
                                   "JOIN computerhardwareservicing chs ON pb.id = chs.id";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvstudent.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            
        }


    }
}
