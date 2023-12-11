using Org.BouncyCastle.Asn1.Mozilla;
using SMARTLEARN.FrontEnd.AdminForms;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEHome : Form
    {
        public static FEHome Instance; //An existing instance of a form.

        //Set a flag for login button enable
        public static bool showlog = true;

        //Set a flag to close the home page after the login is made
        public static bool timetoclose = false;

        public FEHome()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnshowlog_Click(object sender, EventArgs e)
        {
            FrontEnd.FEDashboard.timertoclose = false; //Close form is false on the Dashboard
            FrontEnd.FESTProfile.closeform = false; //Close form is false on the profile

            FrontEnd.FEStudentLogin logstu = new FEStudentLogin();
            logstu.TopMost = true;

            showlog = false; //btnshowlog enable = false

            logstu.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception)
            {
                guna2MessageDialog1.Show("Please wait while the window is opening!");
            }
            finally
            {
                Environment.Exit(0);
            }
        }

        private void timerbeforeexit_Tick(object sender, EventArgs e)
        {
            btnexit.Enabled = true;
        }

        private void timertoclose_Tick(object sender, EventArgs e)
        {
            if (timetoclose == true)
            {
                FEHome.Instance.Hide();
            }
        }

        private void FEHome_Load(object sender, EventArgs e)
        {
            Database.DBCheckOnline check = new Database.DBCheckOnline();
            check.check(btnshowlog);
        }

        private void showlogtimer_Tick(object sender, EventArgs e)
        {
            btnshowlog.Enabled = showlog; 
        }
    }
}
