using SMARTLEARN.Backend;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEEDStudentEnroll : Form
    {
        //FRONT END
        public FEEDStudentEnroll()
        {
            InitializeComponent();
        }

        private void FEStudentEnroll_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            txtsecondid.Text = ran.Next(100000, 999999).ToString();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Backend.BEStudentEnroll stuenroll = new BEStudentEnroll();

            stuenroll.studentinfo(txtfirstid, txtsecondid, cbyearlevel, cbstrand, txtpassword, txtfname, txtmname, txtlname, cbgender, dtmdateofbirth, txtemail, txtmobilenum);

            FrontEnd.FEInformationList info = new FEInformationList();
            FrontEnd.FEInformationList.whatforms = "Student";
            info.ShowDialog();

            //Database
            if (Backend.BEStudentEnroll.confirm == true) //Check the flag in FEInformation if the confirm flag is true.
            {
                Database.DBStudentEnroll regad = new Database.DBStudentEnroll();
                regad.insertinfo(txtfirstid, txtsecondid, cbyearlevel, cbstrand, cbschoolyear, txtfname, txtmname, txtlname, cbgender, dtmdateofbirth, txtemail, txtmobilenum, txtpassword, cbsection);
            }
            else
            {
                //
            }
        }

        private void ResetTimer_Tick(object sender, EventArgs e)
        {
            if (Backend.BEAdregister.resetform == true) //reset current form
            {
                txtfirstid.Text = null;
                txtsecondid.Text = null;
                cbgender.SelectedItem = null;
                cbyearlevel.SelectedItem = null;
                cbstrand.SelectedItem = null;
                cbschoolyear.SelectedItem = null;
                cbsection.SelectedIndex = 0;
                txtpassword.Text = null;

                txtfname.Text = null;
                txtmname.Text = null;
                txtlname.Text = null;
                txtemail.Text = null;
                txtmobilenum.Text = null;
                dtmdateofbirth.Value = new DateTime(2003, 6, 22);

            }
        }

        private void Timertoproceed_Tick(object sender, EventArgs e)
        {
            bool enableButton = false; // Set a flag to disable the button by default

            // Check Role Information
            if (!string.IsNullOrWhiteSpace(txtfirstid.Text) &&
                cbgender.SelectedItem != null &&
                cbyearlevel.SelectedItem != null &&
                cbstrand.SelectedItem != null &&
                cbschoolyear.SelectedItem != null)
            {
                if (//check personal Information
                !string.IsNullOrWhiteSpace(txtpassword.Text) &&
                !string.IsNullOrWhiteSpace(txtfname.Text) &&
                !string.IsNullOrWhiteSpace(txtmname.Text) &&
                !string.IsNullOrWhiteSpace(txtlname.Text) &&
                !string.IsNullOrWhiteSpace(txtemail.Text) &&
                !string.IsNullOrWhiteSpace(txtmobilenum.Text))
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
            btnnext.Enabled = enableButton;
        }

        private void txtfirstid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbschoolyear_DropDown(object sender, EventArgs e)
        {
            cbschoolyear.Items.Clear();
            // Get the current year
            int currentYear = DateTime.Now.Year;

            // Calculate the year from a year before the current year
            int lastYear = currentYear - 1;

            // Create the text string in the format "yyyy-yyyy"
            string yearRange = $"{lastYear}-{currentYear}";

            // Add the generated yearRange string to your ComboBox
            cbschoolyear.Items.Add(yearRange);

        }
    }
}
