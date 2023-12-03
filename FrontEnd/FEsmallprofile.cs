using SMARTLEARN.FrontEnd.MainForm.FacultyForms;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEsmallprofile : Form
    {
        public FEsmallprofile()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FEHome.timetoclose = false; //Home timer to close set to false
            FEHome.showlog = true;

            FELoginAdminFaculty.closethis = false; //Set to false the 'closethis' flag in loginAdmin
            FEStudentLogin.closethis = false; //Set to false the 'closethis' flag in login

            Model.Accounts.user = null; //Restore to null the user in Student form

            Model.Accounts.role = null; //Restore role to default

            //restore to default settings
            Backend.BEAdregister.confirm = false; //Restore the confirm flag for database
            Backend.BEAdregister.resetform = false; //Restore resetform flag to not reset the form auto

            Backend.BEStudentEnroll.confirm = false; //Restore the confirm flag for database
            Backend.BEStudentEnroll.resetform = false; //Restore resetform flag to not reset the form auto

            FrontEnd.FEDashboard.timertoclose = true; //Close the Dashboard

            FrontEnd.FESTProfile.closeform = true; //Close the Profile
            FrontEnd.MainForm.FacultyForms.FEFAProfile.closeform = true; //Close the Profile

            //Show hiding form
            FEHome.Instance.Show();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            if (Model.Accounts.role == "STUDENT")
            {
                FESTProfile profile = new FESTProfile();
                profile.ShowDialog();
                this.Close();
            }
            else if (Model.Accounts.role == "FACULTY")
            {
                FEFAProfile FAprofile = new FEFAProfile();
                FAprofile.ShowDialog();
                this.Close();
            }

        }

        private void FEsmallprofile_Load(object sender, EventArgs e)
        {
            if (Model.Accounts.role == "STUDENT")
            {
                btnprofile.Visible = true;
            }
            else if (Model.Accounts.role == "FACULTY")
            {
                btnprofile.Visible = true;
            }
            else
            {
                btnprofile.Visible = false;
            }
        }
    }
}
