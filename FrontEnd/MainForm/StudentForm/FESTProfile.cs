using SMARTLEARN.Database;
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


            lblname.Text = DBStudentProfile.user; //The user first name and last name
            lblrole.Text = DBStudentProfile.role; //The user Role

            Database.DBStudentProfile stuprofile = new Database.DBStudentProfile();
            stuprofile.searchbalance(lblname, lblrole,lblemail, lblmobile, txtfirstbalance, txtsecondbalance);
        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            if (closeform == true)
            {
                this.Close();
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
