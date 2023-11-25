using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEHome : Form
    {
        //Set a flag to close the home page after the login is made
        public static bool timetoclose = false;

        public FEHome()
        {
            InitializeComponent();
        }

        private void btnshowlog_Click(object sender, EventArgs e)
        {
            FrontEnd.FELogin logstu = new FELogin();
            logstu.TopMost = true;
            logstu.Show();

            FrontEnd.FELogin.showlog = false; //Set to false the flag in FELogin to Disabled the button
            FELoginAdmin.showlog = false; //Set to false the flag in FELoginAdmin to Disabled the button
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0); //add a timer 
            }
            catch (Exception)
            {
                MessageBox.Show("Please wait while the window is opening!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timertoshow_Tick(object sender, EventArgs e)
        {
            btnshowlog.Enabled = FrontEnd.FELogin.showlog;
            btnshowlog.Enabled = FELoginAdmin.showlog;

            btnenrolll.Enabled = FrontEnd.FELogin.showlog;
            btnenrolll.Enabled = FELoginAdmin.showlog;

            btnregisterad.Enabled = FELoginAdmin.showlog;
        }

        private void btnenroll_Click(object sender, EventArgs e)
        {
            FEStudentEnroll enroll = new FEStudentEnroll();
            enroll.Show();
            this.Hide();
        }

        private void timerbeforeexit_Tick(object sender, EventArgs e)
        {
            btnexit.Enabled = true;
        }

        private void timertoclose_Tick(object sender, EventArgs e)
        {
            if (timetoclose == true)
            {
                this.Hide();
            }
        }
    }
}
