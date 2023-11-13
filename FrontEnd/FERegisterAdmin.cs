using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FERegisterAdmin : Form
    {
        public FERegisterAdmin()
        {
            InitializeComponent();
        }
        
        private void btnnext_Click(object sender, EventArgs e)
        {
            Backend.BEAdregister adminregister = new Backend.BEAdregister();

            adminregister.grouprole(txtuserid, cbgender, cbdepartment);
            adminregister.personal(txtfname, txtmname, txtlname, txtemail, txtmobilenum, dateofbirth, txtpassword);

            FrontEnd.FEInformationList info = new FEInformationList();
            FrontEnd.FEInformationList.whatforms = "Admin";
            info.ShowDialog();

            //Database
            if (Backend.BEAdregister.confirm == true)
            {
                Database.DBRegisterAdmin regad = new Database.DBRegisterAdmin();
                regad.insertinfo(txtuserid, cbgender, txtfname, txtmname, txtlname, cbdepartment, dateofbirth, txtmobilenum, txtemail, txtpassword);
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
            if (Backend.BEAdregister.closeform == true)
            {
                this.Close();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FEHome home = new FEHome();
            home.Show();
            this.Close();
        }

        private void FERegisterAdmin_Load(object sender, EventArgs e)
        {
            Database.DBRegisterAdmin regad = new Database.DBRegisterAdmin();
            regad.USERID(txtuserid);
        }
    }
}

