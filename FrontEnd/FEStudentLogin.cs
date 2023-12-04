using SMARTLEARN.FrontEnd.MainForm.StudentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEStudentLogin : Form
    {
        //set a flag to the timer to close the current form.
        public static bool closethis = false;

        public FEStudentLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*TO MAKE THE BUTTON AND PANEL OPACITY > TRANSPARENT
            logpanel.BackColor = Color.FromArgb(100, 0,0,0);
            btnlogin.FillColor = Color.FromArgb(100, 0, 0, 0);
            btnloginadmin.FillColor = Color.FromArgb(100, 0, 0, 0);
            */
        }


        private void btnloginadmin_Click_1(object sender, EventArgs e)
        {
            FELoginAdminFaculty logadmin = new FELoginAdminFaculty();
            logadmin.TopMost = true;
            this.Close();
            logadmin.Show();
        }

        private void lblforgot_Click_1(object sender, EventArgs e)
        {
            FrontEnd.LoadingForm load = new FrontEnd.LoadingForm();
            load.TopMost = true;
            load.ShowDialog();

            FESTForgotpass forgot = new FESTForgotpass();
            forgot.TopMost = true;
            forgot.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            FEHome.showlog = true; FEHome.showlog = true; //btnshowlog enable = true
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Database.DBLoginStudent Logstudent = new Database.DBLoginStudent();
            Logstudent.logstu(txtstudentid, txtpassword, errorProvider1);
        }

        private void timertoclose_Tick(object sender, EventArgs e)
        {
            if (closethis == true)
            {
                this.Close();
            }
        }
    }
}
