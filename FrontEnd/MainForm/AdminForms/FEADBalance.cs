using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.AdminForms
{
    public partial class FEADBalance : Form
    {
        Database.DBBalance balance = new Database.DBBalance();
        public FEADBalance()
        {
            InitializeComponent();
        }

        private void FEADBalance_Load(object sender, EventArgs e)
        {

            balance.loaddgv(DGVStudentlist, MessageDialog1);
        }

        private void DGVStudentlist_SelectionChanged(object sender, EventArgs e)
        {
            balance.selection(DGVStudentlist, lblname);
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            balance.save(DGVStudentlist, txtfirstmisc, txtfirstpta, txtfirstother, txtfirstsemester, txtsecondmisc, txtsecondpta, txtsecondother, txtsecondsemester, MessageDialog1);
        }

        private void TimerDisable_Tick(object sender, EventArgs e)
        {
            bool enableButton = false; // Set a flag to disable the button by default

            // Check First sem
            if (!string.IsNullOrWhiteSpace(txtfirstmisc.Text) &&
                !string.IsNullOrWhiteSpace(txtfirstpta.Text) &&
                !string.IsNullOrWhiteSpace(txtfirstother.Text) &&
                !string.IsNullOrWhiteSpace(txtfirstsemester.Text))
            {
                if (// Check Second sem
                !string.IsNullOrWhiteSpace(txtsecondmisc.Text) &&
                !string.IsNullOrWhiteSpace(txtsecondpta.Text) &&
                !string.IsNullOrWhiteSpace(txtsecondother.Text) &&
                !string.IsNullOrWhiteSpace(txtsecondsemester.Text))
                {
                    enableButton = true;
                }
                else
                {
                    enableButton = false;
                }
            }
            else
            {
                enableButton = false;
            }
            // Enable or disable the button
            btnsave.Enabled = enableButton;

        }

        private void txtfirstsemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComputeFirstSem(object sender, EventArgs e)
        {
            int value1, value2, value3;
            int.TryParse(txtfirstmisc.Text, out value1);
            int.TryParse(txtfirstpta.Text, out value2);
            int.TryParse(txtfirstother.Text, out value3);

            // Calculate the total
            int total = value1 + value2 + value3;

            // Display the total in the total textbox
            txtfirstsemester.Text = total.ToString();
        }

        private void txtsecondmisc_TextChanged(object sender, EventArgs e)
        {
            int value1, value2, value3;
            int.TryParse(txtsecondmisc.Text, out value1);
            int.TryParse(txtsecondpta.Text, out value2);
            int.TryParse(txtsecondother.Text, out value3);

            // Calculate the total
            int total = value1 + value2 + value3;

            // Display the total in the total textbox
            txtsecondsemester.Text = total.ToString();
        }
    }
}
