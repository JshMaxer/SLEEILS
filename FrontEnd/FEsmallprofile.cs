﻿using System;
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
    public partial class FEsmallprofile : Form
    {
        public FEsmallprofile()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FEHome.timetoclose = false; //Home timer to close set to false
            FrontEnd.FELogin.showlog = true; //Enable the button inside the Home Form using the flag on FELogin
            FELoginAdmin.showlog = true; //Enable the button inside the Home Form using the flag on FELoginAdmin
            FELoginAdmin.closethis = false; //Set to false the 'closethis' flag in login
            FEProfile.user = null; //Restore to null the user


            FrontEnd.FEHome home = new FEHome();
            home.Show();

            FrontEnd.FEDashboard.timertoclose = true; //Close the Dashboard
            FrontEnd.FEProfile.closeform = true; //Close the Profile
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            FEProfile profile = new FEProfile();
            this.Close();
            profile.Show();
            FrontEnd.FEDashboard.timertoclose = true; //Close the Dashboard
        }

        private void FEsmallprofile_Load(object sender, EventArgs e)
        {
            if(FrontEnd.FEProfile.ifprofile == true)
            {
                btnprofile.Enabled = false;
            }
            else
            {
                btnprofile.Enabled = true;
            }

        }
    }
}
