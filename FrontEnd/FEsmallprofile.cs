using SMARTLEARN.Database;
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

        //Set a flag to know if the form is currently on profile form
        public static bool ifprofile = false;

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FEHome.timetoclose = false; //Home timer to close set to false

            FrontEnd.FELogin.showlog = true; //Enable the button inside the Home Form using the flag on FELogin
            FELoginAdminFaculty.showlog = true; //Enable the button inside the Home Form using the flag on FELoginAdmin

            FELoginAdminFaculty.closethis = false; //Set to false the 'closethis' flag in login
            FELogin.closethis = false;

            Database.DBStudentProfile.user = null; //Restore to null the user in Student form
            Database.DBFacultyProfile.user = null; //Restore to null the user in Faculty form

            Database.DBFacultyProfile.role = null; //Restore role to default
            Database.DBStudentProfile.role = null; //Restore role to default

            //restore to default settings
            Backend.BEAdregister.confirm = false;
            Backend.BEAdregister.resetform = false;

            Backend.BEStudentEnroll.confirm = false;
            Backend.BEStudentEnroll.resetform = false;

            FrontEnd.FEDashboard.timertoclose = true; //Close the Dashboard
            FrontEnd.FESTProfile.closeform = true; //Close the Profile
            FrontEnd.MainForm.FacultyForms.FEFAProfile.closeform = true; //Close the Profile
            FrontEnd.FEDashboard.timertoclose = false; //Close the Dashboard

            FrontEnd.FEHome home = new FEHome();
            home.Show();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            if (Database.DBStudentProfile.role == "STUDENT")
            {
                FESTProfile profile = new FESTProfile();
                this.Close();
                profile.Show();
                FrontEnd.FEDashboard.timertoclose = true; //Close the Dashboard
            }
            
            if (Database.DBFacultyProfile.role == "ADMIN" || Database.DBFacultyProfile.role == "FACULTY")
            {
                FEFAProfile FAprofile = new FEFAProfile();
                this.Close();
                FAprofile.Show();
                FrontEnd.FEDashboard.timertoclose = true; //Close the Dashboard
            }

        }

        private void FEsmallprofile_Load(object sender, EventArgs e)
        {
            if (ifprofile == true)
            {
                btnprofile.Enabled = true;
            }
            else
            {
                btnprofile.Enabled = false;
            }

        }
    }
}
