using SMARTLEARN.FrontEnd.MainForm.StudentForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEDashboard : Form
    {
        private bool isPanelVisible = false;

        //set a flag to the timer to close the current form.
        public static bool timertoclose = false;

        //Set a flag to give the current role to lblrole.txt
        public static string role;

        public FEDashboard()
        {
            InitializeComponent();
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
            btnbalance.Image = Properties.Resources.bill;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentconfirmation.Image = Properties.Resources.search;
            btnAssignments.Image = Properties.Resources.assignment;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEADCOURSE feadcourse = new FrontEnd.AdminForms.FEADCOURSE();
            feadcourse.TopLevel = false;
            paneldash.Controls.Add(feadcourse);
            feadcourse.Show();

        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnbalance.Image = Properties.Resources.bill1; //Active color
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentconfirmation.Image = Properties.Resources.search;
            btnAssignments.Image = Properties.Resources.assignment;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEADBalance feadbalance = new AdminForms.FEADBalance();
            feadbalance.TopLevel = false;
            paneldash.Controls.Add(feadbalance);
            feadbalance.Show();
        }

        private void btnschedule_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnbalance.Image = Properties.Resources.bill;
            btnschedule.Image = Properties.Resources.schedule1; //Active color
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentconfirmation.Image = Properties.Resources.search;
            btnAssignments.Image = Properties.Resources.assignment;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEADSchedule fEADSchedule = new AdminForms.FEADSchedule();
            fEADSchedule.TopLevel = false;
            paneldash.Controls.Add(fEADSchedule);
            fEADSchedule.Show();
        }

        private void btnstudentconfirmation_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnbalance.Image = Properties.Resources.bill;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentconfirmation.Image = Properties.Resources.search1; //Active color
            btnAssignments.Image = Properties.Resources.assignment;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEADStudentConfirmation fEADStudentConfirmation = new AdminForms.FEADStudentConfirmation();
            fEADStudentConfirmation.TopLevel = false;
            paneldash.Controls.Add(fEADStudentConfirmation);
            fEADStudentConfirmation.Show();
        }

        private void btnviewgrades_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnbalance.Image = Properties.Resources.bill;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam1; //Active color
            btnstudentconfirmation.Image = Properties.Resources.search;
            btnAssignments.Image = Properties.Resources.assignment;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.AdminForms.FEADViewGrades fEADViewGrades = new AdminForms.FEADViewGrades();
            fEADViewGrades.TopLevel = false;
            paneldash.Controls.Add(fEADViewGrades);
            fEADViewGrades.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home1; //Active color
            btncourse.Image = Properties.Resources.learning;
            btnbalance.Image = Properties.Resources.bill;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentconfirmation.Image = Properties.Resources.search;
            btnAssignments.Image = Properties.Resources.assignment;
            btnfacultyregistration.Image = Properties.Resources.profile1;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.FEWelcomeDashboard fEWelcomeDashboard = new FEWelcomeDashboard();
            fEWelcomeDashboard.TopLevel = false;
            paneldash.Controls.Add(fEWelcomeDashboard);
            fEWelcomeDashboard.Show();
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnbalance.Image = Properties.Resources.bill;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentconfirmation.Image = Properties.Resources.search;
            btnAssignments.Image = Properties.Resources.assignment__2_; //Active color
            btnfacultyregistration.Image = Properties.Resources.profile1;
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.MainForm.StudentForm.FESTAssignments fESTAssignments = new FESTAssignments();
            fESTAssignments.TopLevel = false;
            paneldash.Controls.Add(fESTAssignments);
            fESTAssignments.Show();
        }

        private void btnfacultyregistration_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            //Change the appearance of the button
            btnhome.Image = Properties.Resources.home;
            btncourse.Image = Properties.Resources.learning;
            btnbalance.Image = Properties.Resources.bill;
            btnschedule.Image = Properties.Resources.schedule;
            btnviewgrades.Image = Properties.Resources.exam;
            btnstudentconfirmation.Image = Properties.Resources.search;
            btnAssignments.Image = Properties.Resources.assignment; 
            btnfacultyregistration.Image = Properties.Resources.profile3; //Active color
            //________________________________________________________________

            paneldash.Controls.Clear();
            FrontEnd.FERegisterAdmin regad = new FERegisterAdmin();
            regad.TopLevel = false;
            paneldash.Controls.Add(regad);
            regad.Show();
        }

        private void FEDashboard_Load(object sender, EventArgs e)
        {
            //add db for select profile


            lblrole.Text = role;

            if(role == "Faculty")
            {
                btnstudentconfirmation.Visible = false;
                btnfacultyregistration.Visible = false;
                btnAssignments.Visible = false;
            }
            else if (role == "Admin")
            {
                btnstudentconfirmation.Visible = true;
                btnfacultyregistration.Visible = true;
                btnAssignments.Visible = false;
            }
            else if(role == "Student")
            {
                btnstudentconfirmation.Visible = false;
                btnfacultyregistration.Visible = false;
                btnAssignments.Visible = true;
            }

            btnhome.Image = Properties.Resources.home1; //Active color
            paneldash.Controls.Clear();
            FrontEnd.FEWelcomeDashboard fEWelcomeDashboard = new FEWelcomeDashboard();
            fEWelcomeDashboard.TopLevel = false;
            paneldash.Controls.Add(fEWelcomeDashboard);
            fEWelcomeDashboard.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            hide(); //always on top
            if (Sidebar.Width == 67) // OPEN
            {
                Sidebar.Width = 175;
                Sidebartop.Width = 175;
                paneldash.Width = 1114;

                paneldash.Location = new Point(180, 116);
                lbltitle.Location = new Point(175, 77);

                Sidebar.Visible = false;
                paneldash.Visible = false;
                Sidebartop.Visible = false;
                btnmenu.Visible = false;
                lbltitle.Visible = false;

                SidebarTransition.ShowSync(Sidebar);
                SidebarTransition.ShowSync(Sidebartop);
                LogoTransition.ShowSync(btnmenu);
                SidebarTransition.ShowSync(lbltitle);
                Dashboardtransition.ShowSync(paneldash);
            }
            else //CLOSE
            {
                Sidebar.Width = 67;
                Sidebartop.Width = 67;
                paneldash.Width = 1222;

                paneldash.Location = new Point(72, 116);
                lbltitle.Location = new Point(72, 77);

                Sidebar.Visible = false;
                paneldash.Visible = false;
                Sidebartop.Visible = false;
                btnmenu.Visible = false;
                lbltitle.Visible = false;

                SidebarTransition.ShowSync(Sidebar);
                SidebarTransition.ShowSync(Sidebartop);
                LogoTransition.ShowSync(btnmenu);
                SidebarTransition.ShowSync(lbltitle);
                Dashboardtransition.ShowSync(paneldash);
            }

        }

    }
}
