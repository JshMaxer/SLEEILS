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
            Database.DBStudentEnroll ID = new Database.DBStudentEnroll();
            ID.USERID(txtfirstid, txtsecondid);

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
                regad.insertinfo(txtfirstid, txtsecondid, cbyearlevel, cbstrand, txtpassword, txtfname, txtmname, txtlname, cbgender, dtmdateofbirth, txtemail, txtmobilenum);
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
                cbstrand.SelectedItem != null)
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
    }
}
