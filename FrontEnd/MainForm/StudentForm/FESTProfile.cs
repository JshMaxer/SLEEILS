using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.AnimatorNS.Flags;

namespace SMARTLEARN.FrontEnd
{
    public partial class FESTProfile : Form
    {
        public FESTProfile()
        {
            InitializeComponent();
        }

        private bool isPanelVisible = false;

        //Set a flag to know if the form is currently on profile form
        public static bool ifprofile = false;

        //Set a flag to give the current role to lblrole.txt
        public static string role;

        //Set a flag for user who's log-in
        public static string user;

        //Set a flag for userID
        public static int userID;


        public static bool closeform = false;

        private void FEProfile_Load(object sender, EventArgs e)
        {
            Screen currentScreen = Screen.PrimaryScreen;

            if (currentScreen.Bounds.Width == 1920 && currentScreen.Bounds.Height == 1080)
            {
                //
            }
            else
            {
                //Size of the form based on the last form
                this.Width = FEDashboard.formWidth;
                this.Height = FEDashboard.formHeight;
            }

            if (FEDashboard.windowStates == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }


            lblname.Text = user; //The user first name and last name
            lblrole.Text = role; //The user Role

            ifprofile = true; //Make this true for the flag to know if we're on profile side


            //student prifle database
        }

        private void btnsmallprofile_Click(object sender, EventArgs e)
        {
            isPanelVisible = !isPanelVisible;
            panelsmall.Visible = isPanelVisible;

            if (isPanelVisible)
            {
                FEsmallprofile smallprofile = new FEsmallprofile() { TopLevel = false, TopMost = true };
                smallprofile.FormBorderStyle = FormBorderStyle.None;
                panelsmall.Controls.Add(smallprofile);
                smallprofile.Show();
            }
            else
            {
                panelsmall.Controls.Clear(); // Clear any controls within panelsmall
            }
        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            if (closeform == true)
            {
                this.Close();
            }

        }
    
    }
}
