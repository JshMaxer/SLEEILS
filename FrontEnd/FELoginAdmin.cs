﻿using SMARTLEARN.FrontEnd;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN
{
    //FrontEnd
    public partial class FELoginAdmin : Form
    {
        //set a flag to the timer to know if the button is clicked.
        public static bool showlog = true;

        //set a flag to the timer to close the current form.
        public static bool closethis = false;

        public FELoginAdmin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CenterToScreen();
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
            FrontEnd.FELogin logstu = new FrontEnd.FELogin();
            logstu.Show();
            logstu.TopMost = true;

            this.Close();
        }

        private void lblforgot_Click(object sender, EventArgs e)
        {
            FrontEnd.LoadingForm load = new FrontEnd.LoadingForm();
            load.TopMost = true;
            load.ShowDialog();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            FrontEnd.FELogin.showlog = true;
            showlog = true;
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Database.DBLoginAdmin Logadmin = new Database.DBLoginAdmin();
            Logadmin.logad(txtuserid, txtpassword, errorProvider1);
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
