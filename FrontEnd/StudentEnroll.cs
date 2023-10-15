using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class StudentEnroll : Form
    {
        public StudentEnroll()
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
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void rbexistingstudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Backend.StudentEnroll stuenroll = new Backend.StudentEnroll();

            stuenroll.typeofstu(rbnewstudent, rbexistingstudent);
            stuenroll.requiredfields(cbadmittype, cbyearlevel, cbschoolyear, cbterm);
            stuenroll.strand(rbict);
            stuenroll.studentInfo(txtfname, txtmname, txtlname, txtsuffix, cbgender, cbstatus, txtcitizenship, dateofbirth, txtbirthplace, txtreligion, txtaddress, txtemail, txtmobilenum, txttelephone);
            stuenroll.guardianInfo(txtgfname, txtgmiddlename, txtglastname, txtgsuffix, txtggender, txtgstatus, txtgcitizenship, txtgdateofbirth, txtgbirthplace, txtgreligion, txtgmobile, txtgemail, txtgmobile, txtgtelephone, txtgrelationship, txtgoccupation);

            FrontEnd.InformationList info = new InformationList();
            info.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool enableButton = true; // Set a flag to enable the button by default

            // Check Student Type
            if (!rbnewstudent.Checked && !rbexistingstudent.Checked)
            {
                enableButton = false;
            }

            // Check Required Fields
            else if(rbnewstudent.Checked)
            {
                if (cbadmittype.SelectedItem == null ||
                cbyearlevel.SelectedItem == null ||
                cbschoolyear.SelectedItem == null ||
                cbterm.SelectedItem == null ||
                cbadmittype.SelectedItem.Equals("") ||
                cbyearlevel.SelectedItem.Equals("") ||
                cbschoolyear.SelectedItem.Equals("") ||
                cbterm.SelectedItem.Equals(""))
                {
                    enableButton = false;
                }
            }

            // Check Strand
            else if (!rbict.Checked)
            {
                enableButton = false;
            }

            // Check Student Information
            else if (string.IsNullOrWhiteSpace(txtfname.Text) ||
                string.IsNullOrWhiteSpace(txtmname.Text) ||
                string.IsNullOrWhiteSpace(txtlname.Text) ||
                cbgender.SelectedItem == null ||
                cbstatus.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtcitizenship.Text) ||
                string.IsNullOrWhiteSpace(txtbirthplace.Text) ||
                string.IsNullOrWhiteSpace(txtreligion.Text) ||
                string.IsNullOrWhiteSpace(txtaddress.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtmobilenum.Text) ||
                string.IsNullOrWhiteSpace(txttelephone.Text))
            {
                enableButton = false;
            }

            // Check Guardian Information
            else if (string.IsNullOrWhiteSpace(txtgfname.Text) ||
                string.IsNullOrWhiteSpace(txtgmiddlename.Text) ||
                string.IsNullOrWhiteSpace(txtglastname.Text) ||
                string.IsNullOrWhiteSpace(txtggender.Text) ||
                string.IsNullOrWhiteSpace(txtgstatus.Text) ||
                string.IsNullOrWhiteSpace(txtgcitizenship.Text) ||
                string.IsNullOrWhiteSpace(txtgbirthplace.Text) ||
                string.IsNullOrWhiteSpace(txtgreligion.Text) ||
                string.IsNullOrWhiteSpace(txtgaddress.Text) ||
                string.IsNullOrWhiteSpace(txtgemail.Text) ||
                string.IsNullOrWhiteSpace(txtgmobile.Text) ||
                string.IsNullOrWhiteSpace(txtgtelephone.Text) ||
                string.IsNullOrWhiteSpace(txtgrelationship.Text) ||
                string.IsNullOrWhiteSpace(txtgoccupation.Text))
            {
                enableButton = false;
            }

            // Enable or disable the button
            btnnext.Enabled = enableButton;
        }

    }
}
