using Guna.UI2.WinForms;
using SMARTLEARN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.MainForm.FacultyForms
{
    public partial class FEFAGrading : Form
    {
        Database.DBGrading grading = new Database.DBGrading();

        public FEFAGrading()
        {
            InitializeComponent();
        }

        private void FEGrading_Load(object sender, EventArgs e)
        {
            grading.DisplayStudents(DGVStudentlist, cbsemester);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            grading.insertGrade(DGVStudentlist, txtstudentfirst, txtstudentsecond, cbsemester, cbschoolyear, txtstudentaverage);
        }

        private void CalculateAverage()
        {
            if (!string.IsNullOrEmpty(txtstudentfirst.Text) && !string.IsNullOrEmpty(txtstudentsecond.Text))
            {
                if (double.TryParse(txtstudentfirst.Text, out double value1) && double.TryParse(txtstudentsecond.Text, out double value2))
                {
                    double average = (value1 + value2) / 2;
                    txtstudentaverage.Text = average.ToString(); // Display the calculated average in the third TextBox
                }
                else
                {
                    // Handle if the input values are not numeric
                    txtstudentaverage.Text = "Invalid input";
                }
            }
            else
            {
                // Handle if either TextBox is empty
                txtstudentaverage.Text = string.Empty;
            }
        }

        private void txtstudentfirst_TextChanged(object sender, EventArgs e)
        {
            CalculateAverage();
        }

        private void txtstudentsecond_TextChanged(object sender, EventArgs e)
        {
            CalculateAverage();
        }

        private void txtstudentfirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbsemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVStudentlist.ClearSelection();
            grading.DisplayStudents(DGVStudentlist, cbsemester);

            if (cbsemester.SelectedIndex == 0)
            {
                lblfirstsem.Text = "1st Quarter";
                lblsecondsem.Text = "2nd Quarter";
            }
            else if(cbsemester.SelectedIndex == 1)
            {
                lblfirstsem.Text = "3rd Quarter";
                lblsecondsem.Text = "4th Quarter";
            }

        }

        private void DGVStudentlist_SelectionChanged(object sender, EventArgs e)
        {
            grading.selection(DGVStudentlist, txtstudentfirst, txtstudentsecond, cbsemester, cbschoolyear);
        }
    }
}
