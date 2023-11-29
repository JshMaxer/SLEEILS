using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEHome : Form
    {
        //Set a flag to close the home page after the login is made
        public static bool timetoclose = false;

        //Set a flag to know what is the current size of the screen so the other form can resize too.
        public static int formWidth; //width of the form
        public static int formHeight; //height of the form
        public static bool windowStates; //window state of the form

        public FEHome()
        {
            InitializeComponent();
        }

        private void btnshowlog_Click(object sender, EventArgs e)
        {
            FrontEnd.FEDashboard.timertoclose = false; //Close form is false on the Dashboard
            FrontEnd.FESTProfile.closeform = false; //Close form is false on the profile

            FrontEnd.FELogin logstu = new FELogin();
            logstu.TopMost = true;
            logstu.Show();

            FrontEnd.FELogin.showlog = false; //Set to false the flag in FELogin to Disabled the button
            FELoginAdmin.showlog = false; //Set to false the flag in FELoginAdmin to Disabled the button

            //Size of the form
            formWidth = this.Width;
            formHeight = this.Height;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Please wait while the window is opening!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Environment.Exit(0);
            }
        }

        private void timertoshow_Tick(object sender, EventArgs e)
        {
            btnshowlog.Enabled = FrontEnd.FELogin.showlog;
            btnshowlog.Enabled = FELoginAdmin.showlog;
        }

        private void btnenroll_Click(object sender, EventArgs e)
        {
            FEEDStudentEnroll enroll = new FEEDStudentEnroll();
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

        private void FEHome_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                windowStates = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                windowStates = true;
            }
        }

        private void FEHome_Load(object sender, EventArgs e)
        {
            Screen currentScreen = Screen.PrimaryScreen;

            if (currentScreen.Bounds.Width == 1920 && currentScreen.Bounds.Height == 1080)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Width = currentScreen.Bounds.Width;
                this.Height = currentScreen.Bounds.Height;
            }

            Database.DBCheckOnline check = new Database.DBCheckOnline();
            check.check();
        }
    }
}
