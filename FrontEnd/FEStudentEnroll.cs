using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEStudentEnroll : Form
    {
        //FRONT END
        public FEStudentEnroll()
        {
            InitializeComponent();
        }

        private void rbnewstudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnewstudent.Checked)
            {
                requiredfields.Visible = true;
            }
            else
            {
                cbadmittype.SelectedItem = null;
                cbyearlevel.SelectedItem = null;
                cbschoolyear.SelectedItem = null;
                cbterm.SelectedItem = null;
                requiredfields.Visible = false;
            }
        }

        private void dbschoolyear_DropDown(object sender, EventArgs e)
        {
            cbschoolyear.Items.Clear();
            int currentYear = DateTime.Now.Year;
            cbschoolyear.Items.Add(currentYear);

        }

        private void cbxothers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxothers.Checked)
            {
                txtothers.Enabled = true;
            }
            else
            {
                txtothers.Enabled = false;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FEHome home = new FEHome();
            home.Show();
            this.Close();
        }

        private void rbexistingstudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Backend.BEStudentEnroll stuenroll = new Backend.BEStudentEnroll();

            stuenroll.typeofstu(rbnewstudent, rbexistingstudent);
            stuenroll.requiredfields(cbadmittype, cbyearlevel, cbschoolyear, cbterm);
            stuenroll.strand(rbict);
            stuenroll.studentInfo(txtfname, txtmname, txtlname, txtsuffix, cbgender, cbstatus, txtcitizenship, dateofbirth, txtbirthplace, txtreligion, txtaddress, txtemail, txtmobilenum, txttelephone);
            stuenroll.guardianInfo(txtgfname, txtgmiddlename, txtglastname, txtgsuffix, txtggender, txtgstatus, txtgcitizenship, txtgdateofbirth, txtgbirthplace, txtgreligion, txtgmobile, txtgemail, txtgmobile, txtgtelephone, txtgrelationship, txtgoccupation);

            FrontEnd.FEInformationList info = new FEInformationList();
            FrontEnd.FEInformationList.whatforms = "Student";
            info.ShowDialog();

            //Database
            if (Backend.BEStudentEnroll.confirm == true)
            {
                Database.DBStudentEnroll stuquery = new Database.DBStudentEnroll();
                stuquery.insertinfo(cbadmittype, cbyearlevel, cbschoolyear, cbterm, rbict, txtfname, txtmname, txtlname, txtsuffix, cbgender, cbstatus, txtcitizenship, dateofbirth, txtbirthplace, txtreligion, txtaddress, txtemail, txtmobilenum, txttelephone, txtgfname, txtgmiddlename, txtglastname, txtgsuffix, txtggender, txtgstatus, txtgcitizenship, txtgdateofbirth, txtgbirthplace, txtgreligion, txtgmobile, txtgemail, txtgmobile, txtgtelephone, txtgrelationship, txtgoccupation);
            }
            else
            {
                //
            }

        }

        private void timer1_Tick(object sender, EventArgs e) // Real-time button enable/disable
        {
            bool enableButton = false; // Set a flag to disable the button by default

            // Check Student Type
            if (rbnewstudent.Checked || rbexistingstudent.Checked)
            {
                // Check Required Fields for new students
                if (rbnewstudent.Checked &&
                    cbadmittype.SelectedItem != null &&
                    cbyearlevel.SelectedItem != null &&
                    cbschoolyear.SelectedItem != null &&
                    cbterm.SelectedItem != null)
                {
                    enableButton = true;
                }
                // Check Strand for existing students
                else if (rbexistingstudent.Checked && rbict.Checked)
                {
                    enableButton = true;
                }

                // Check Student Information
                if (enableButton &&
                    !string.IsNullOrWhiteSpace(txtfname.Text) &&
                    !string.IsNullOrWhiteSpace(txtmname.Text) &&
                    !string.IsNullOrWhiteSpace(txtlname.Text) &&
                    cbgender.SelectedItem != null &&
                    cbstatus.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(txtcitizenship.Text) &&
                    !string.IsNullOrWhiteSpace(txtbirthplace.Text) &&
                    !string.IsNullOrWhiteSpace(txtreligion.Text) &&
                    !string.IsNullOrWhiteSpace(txtaddress.Text) &&
                    !string.IsNullOrWhiteSpace(txtemail.Text) &&
                    !string.IsNullOrWhiteSpace(txtmobilenum.Text))
                {
                    // Check Guardian Information
                    if (!string.IsNullOrWhiteSpace(txtgfname.Text) &&
                        !string.IsNullOrWhiteSpace(txtgmiddlename.Text) &&
                        !string.IsNullOrWhiteSpace(txtglastname.Text) &&
                        !string.IsNullOrWhiteSpace(txtggender.Text) &&
                        !string.IsNullOrWhiteSpace(txtgstatus.Text) &&
                        !string.IsNullOrWhiteSpace(txtgcitizenship.Text) &&
                        !string.IsNullOrWhiteSpace(txtgbirthplace.Text) &&
                        !string.IsNullOrWhiteSpace(txtgreligion.Text) &&
                        !string.IsNullOrWhiteSpace(txtgaddress.Text) &&
                        !string.IsNullOrWhiteSpace(txtgemail.Text) &&
                        !string.IsNullOrWhiteSpace(txtgmobile.Text) &&
                        !string.IsNullOrWhiteSpace(txtgrelationship.Text) &&
                        !string.IsNullOrWhiteSpace(txtgoccupation.Text))
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
            }

            // Enable or disable the button
            btnnext.Enabled = enableButton;
        }

        private void timertoclose_Tick(object sender, EventArgs e)
        {
            if (Backend.BEStudentEnroll.closeform == true)
            {
                this.Close();
            }

        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmobilenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
