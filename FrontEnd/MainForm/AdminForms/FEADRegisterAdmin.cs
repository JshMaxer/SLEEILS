using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEADRegisterAdmin : Form
    {
        public FEADRegisterAdmin()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Backend.BEAdregister adminregister = new Backend.BEAdregister();

            adminregister.grouprole(txtfirstid, txtuserid, cbgender, cbdepartment);
            adminregister.personal(txtfname, txtmname, txtlname, txtemail, txtmobilenum, dateofbirth, txtpassword);

            FrontEnd.FEInformationList info = new FEInformationList();
            FrontEnd.FEInformationList.whatforms = "Admin";
            info.ShowDialog();

            //Database
            if (Backend.BEAdregister.confirm == true) //Check the flag in FEInformation if the confirm flag is true.
            {
                Database.DBRegisterFaculty regad = new Database.DBRegisterFaculty();
                regad.insertinfo(txtfirstid, txtuserid, cbgender, txtfname, txtmname, txtlname, cbdepartment, dateofbirth, txtmobilenum, txtemail, txtpassword);
            }
            else
            {
                //
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool enableButton = false; // Set a flag to disable the button by default

            // Check Role Information
            if (!string.IsNullOrWhiteSpace(txtuserid.Text) &&
                cbgender.SelectedItem != null &&
                cbdepartment.SelectedItem != null)
            {
                if (//check personal Information
                !string.IsNullOrWhiteSpace(txtfirstid.Text) &&
                !string.IsNullOrWhiteSpace(txtfname.Text) &&
                !string.IsNullOrWhiteSpace(txtmname.Text) &&
                !string.IsNullOrWhiteSpace(txtlname.Text) &&
                !string.IsNullOrWhiteSpace(txtemail.Text) &&
                !string.IsNullOrWhiteSpace(txtpassword.Text) &&
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

        private void timertoclose_Tick(object sender, EventArgs e)
        {
            if (Backend.BEAdregister.resetform == true) //reset current form
            {
                txtfirstid.Text = null;
                txtuserid.Text = null;
                cbgender.SelectedItem = null;
                cbdepartment.SelectedItem = null;
                txtpassword.Text = null;

                txtfname.Text = null;
                txtmname.Text = null;
                txtlname.Text = null;
                txtemail.Text = null;
                txtmobilenum.Text = null;
                dateofbirth.Value = new DateTime(2003, 6, 22);

            }
        }

        private void FERegisterAdmin_Load(object sender, EventArgs e)
        {
            Database.DBRegisterFaculty regad = new Database.DBRegisterFaculty();
            regad.USERID(txtfirstid, txtuserid);
        }

        private void txtmobilenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

