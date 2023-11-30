﻿using SMARTLEARN.FrontEnd.AdminForms;
using SMARTLEARN.FrontEnd.MainForm.StudentForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEDashboard : Form
    {
        public static FEDashboard Instance; //An existing instance of a form.

        private bool isPanelVisible = false;

        //set a flag to the timer to close the current form.
        public static bool timertoclose = false;

        //Set a flag to know what is the current size of the paneldash so the form can resize too.
        public static int dashpanelWidth; //width of the form
        public static int dashpanelHeight; //height of the form


        //Set a flag to know what is the current size of the screen so the other form can resize too.
        public static int formWidth; //width of the form
        public static int formHeight; //height of the form
        public static bool windowStates; //window state of the form


        public FEDashboard()
        {
            InitializeComponent();
            Instance = this;
        }

        void hide() // the panel will hide if you click somewhere!
        {
            // Check if the click event happened outside of the panel
            Point point = this.PointToClient(Cursor.Position);
            if (!panelsmall.Bounds.Contains(point))
            {
                panelsmall.Visible = false; // Hide the panel
                panelsmall.Controls.Clear(); // Clear any controls within panelsmall
            }
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

        private void dragpanel_Click(object sender, EventArgs e)
        {
            hide(); //always on top
        }

        private void paneldash_Click(object sender, EventArgs e)
        {
            hide(); //always on top
        }

        private void timetoclose_Tick(object sender, EventArgs e)
        {
            if (timertoclose == true)
            {
                this.Close();
            }
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.mortarboard; //Active color
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentregistration.Image = Properties.Resources.online_registration;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            btnbalance.Image = Properties.Resources.bill;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEADCOURSE feadcourse = new FrontEnd.AdminForms.FEADCOURSE();
            feadcourse.TopLevel = false;

            dashpanelWidth = paneldash.Width;
            dashpanelHeight = paneldash.Height;

            // Set the form size to fit within the panel
            feadcourse.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            feadcourse.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(feadcourse);
            feadcourse.Show();

        }

        private void btnschedule_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnschedule.Image = Properties.Resources.schedule1; //Active color
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentregistration.Image = Properties.Resources.online_registration;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            btnbalance.Image = Properties.Resources.bill;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEADSchedule fEADSchedule = new AdminForms.FEADSchedule();
            fEADSchedule.TopLevel = false;

            // Set the form size to fit within the panel
            fEADSchedule.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            fEADSchedule.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(fEADSchedule);
            fEADSchedule.Show();
        }

        private void btnstudentconfirmation_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentregistration.Image = Properties.Resources.online_registration__2_; //Active color
            btnfacultyregistration.Image = Properties.Resources.profile1;
            btnbalance.Image = Properties.Resources.bill;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.FEEDStudentEnroll fEEDStudentEnroll = new FEEDStudentEnroll();
            fEEDStudentEnroll.TopLevel = false;

            // Set the form size to fit within the panel
            fEEDStudentEnroll.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            fEEDStudentEnroll.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(fEEDStudentEnroll);
            fEEDStudentEnroll.Show();
        }

        private void btnviewgrades_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam1; //Active color
            btnstudentregistration.Image = Properties.Resources.online_registration;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            btnstudentregistration.Image = Properties.Resources.online_registration;
            btnbalance.Image = Properties.Resources.bill;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEFAGrades fEADViewGrades = new AdminForms.FEFAGrades();
            fEADViewGrades.TopLevel = false;

            // Set the form size to fit within the panel
            fEADViewGrades.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            fEADViewGrades.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(fEADViewGrades);
            fEADViewGrades.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home1; //Active color
            btncourse.Image = Properties.Resources.learning;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentregistration.Image = Properties.Resources.online_registration;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            btnbalance.Image = Properties.Resources.bill;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.FEWelcomeDashboard fEWelcomeDashboard = new FEWelcomeDashboard();
            fEWelcomeDashboard.TopLevel = false;

            dashpanelWidth = paneldash.Width;
            dashpanelHeight = paneldash.Height;

            // Set the form size to fit within the panel
            fEWelcomeDashboard.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            fEWelcomeDashboard.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(fEWelcomeDashboard);
            fEWelcomeDashboard.Show();

        }

        private void btnfacultyregistration_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentregistration.Image = Properties.Resources.online_registration;
            btnfacultyregistration.Image = Properties.Resources.profile3; //Active color
            btnbalance.Image = Properties.Resources.bill;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.FEADRegisterAdmin regad = new FEADRegisterAdmin();
            regad.TopLevel = false;

            dashpanelWidth = paneldash.Width;
            dashpanelHeight = paneldash.Height;

            // Set the form size to fit within the panel
            regad.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            regad.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(regad);
            regad.Show();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentregistration.Image = Properties.Resources.online_registration;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            btnbalance.Image = Properties.Resources.bill__1_; //Active color
            //________________________________________________________________

            paneldash.Controls.Clear();
            FEADBalance balance = new FEADBalance();
            balance.TopLevel = false;

            dashpanelWidth = paneldash.Width;
            dashpanelHeight = paneldash.Height;

            // Set the form size to fit within the panel
            balance.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            balance.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(balance);
            balance.Show();
        }

        private void FEDashboard_Load(object sender, EventArgs e)
        {
            FEHome.showlog = true; //btnshowlog enable = true

            Screen currentScreen = Screen.PrimaryScreen;

            if (currentScreen.Bounds.Width == 1920 && currentScreen.Bounds.Height == 1080)
            {
                //Original Ratio of the system.
            }
            else
            {
                //Size of the form based on the last form
                this.Width = FEHome.formWidth;
                this.Height = FEHome.formHeight;
            }

            //Size of the panel
            dashpanelWidth = paneldash.Width;
            dashpanelHeight = paneldash.Height;

            //Save the data size;
            formWidth = this.Width;
            formHeight = this.Height;


            if (FEHome.windowStates == true)
            {
                this.WindowState = FormWindowState.Maximized;
                windowStates = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                windowStates = false;
            }


            if (Database.DBFacultyProfile.role == "FACULTY")
            {
                btnstudentregistration.Visible = false;
                btnfacultyregistration.Visible = false;
                btnbalance.Visible = false;
                btnviewgrades.Visible = true;
                btnschedule.Visible = true;
            }
            else if (Database.DBFacultyProfile.role == "ADMIN")
            {
                btnstudentregistration.Visible = true;
                btnfacultyregistration.Visible = true;
                btnbalance.Visible = true;
                btnviewgrades.Visible = false;
                btnschedule.Visible = false;
            }
           
            if (Database.DBStudentProfile.role == "STUDENT")
            {
                btnstudentregistration.Visible = false;
                btnfacultyregistration.Visible = false;
                btnbalance.Visible = false;
                btnviewgrades.Visible = false;
                btnschedule.Visible = true;
            }

            btnhome.Image = Properties.Resources.home1; //Active color
            paneldash.Controls.Clear();
            FrontEnd.FEWelcomeDashboard fEWelcomeDashboard = new FEWelcomeDashboard();
            fEWelcomeDashboard.TopLevel = false;

            // Set the form size to fit within the panel
            fEWelcomeDashboard.Size = new System.Drawing.Size(dashpanelWidth, dashpanelHeight);

            // Set the form to dock within the panel
            fEWelcomeDashboard.Dock = System.Windows.Forms.DockStyle.Fill;

            paneldash.Controls.Add(fEWelcomeDashboard);
            fEWelcomeDashboard.Show();

            //Restore settings to true for access in profile
            FrontEnd.FESTProfile.closeform = false; //Close the Profile
            FrontEnd.MainForm.FacultyForms.FEFAProfile.closeform = false; //Close the Profile
        }

        
    }
}
