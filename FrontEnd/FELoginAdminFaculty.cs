using SMARTLEARN.FrontEnd;
using SMARTLEARN.FrontEnd.MainForm.FacultyForms;
using SMARTLEARN.FrontEnd.MainForm.StudentForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN
{
    //FrontEnd
    public partial class FELoginAdminFaculty : Form
    {
        //set a flag to the timer to close the current form.
        public static bool closethis = false;

        public FELoginAdminFaculty()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*TO MAKE THE BUTTON AND PANEL OPCAITY > TRANSPARENT
            logpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            btnlogin.FillColor = Color.FromArgb(100, 0, 0, 0);
            btnloginadmin.FillColor = Color.FromArgb(100, 0, 0, 0);
            */
        }

        private void btnloginadmin_Click_1(object sender, EventArgs e)
        {
            FrontEnd.FEStudentLogin logstu = new FrontEnd.FEStudentLogin();
            logstu.TopMost = true;
            logstu.Show();
            this.Close();
        }

        private void lblforgot_Click(object sender, EventArgs e)
        {
            FrontEnd.LoadingForm load = new FrontEnd.LoadingForm();
            load.TopMost = true;
            load.ShowDialog();

            FEFAForgotpass forgot = new FEFAForgotpass();
            forgot.TopMost = true;
            forgot.ShowDialog();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            FEHome.showlog = true;
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text == Model.ConsAcc.userID && txtpassword.Text == Model.ConsAcc.pass)
            {
                FrontEnd.FEDashboard dash = new FEDashboard();

                //Role
                Model.Accounts.role = "ADMIN";
                
                dash.Show();
                FELoginAdminFaculty.closethis = true; // make this false on log out!
                FEHome.timetoclose = true; //To hide the home form
            }
            else
            {
                Database.DBLoginFaculty Logadmin = new Database.DBLoginFaculty();
                Logadmin.logad(txtuserid, txtpassword, errorProvider1);
            }
        }

        private void timertoclose_Tick(object sender, EventArgs e)
        {
            if(closethis == true)
            {
                this.Close();
            }
        }

    }
}
