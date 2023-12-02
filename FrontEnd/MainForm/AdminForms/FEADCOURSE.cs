using SMARTLEARN.Database;
using SMARTLEARN.FrontEnd.MainForm.AdminForms;
using SMARTLEARN.FrontEnd.MainForm.FacultyForms;
using SMARTLEARN.FrontEnd.MainForm.StudentForm;
using SMARTLEARN.Model;
using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.AdminForms
{
    public partial class FEADCOURSE : Form
    {
        public FEADCOURSE()
        {
            InitializeComponent();
        }

        private void btnhandout_Click(object sender, EventArgs e)
        {
            if (Accounts.role == "ADMIN")
            {
                coursepanel.Controls.Clear();
                FEADHandoutForm FEHandout = new FEADHandoutForm();
                FEHandout.TopLevel = false;

                // Set the form to dock within the panel
                FEHandout.Dock = System.Windows.Forms.DockStyle.Fill;

                coursepanel.Controls.Add(FEHandout);
                FEHandout.Show();
            }
            else
            {
                coursepanel.Controls.Clear();
                FrontEnd.MainForm.FacultyForms.FEFAHandout FACSTUHandout = new MainForm.FacultyForms.FEFAHandout();
                FACSTUHandout.TopLevel = false;

                // Set the form to dock within the panel
                FACSTUHandout.Dock = System.Windows.Forms.DockStyle.Fill;

                coursepanel.Controls.Add(FACSTUHandout);
                FACSTUHandout.Show();
            }
        }

        private void btncustom_Click(object sender, EventArgs e)
        {
            if (Accounts.role == "FACULTY" || Accounts.role == "ADMIN")
            {
                coursepanel.Controls.Clear();
                FAFACustomForm customform = new FAFACustomForm();
                customform.TopLevel = false;

                // Set the form to dock within the panel
                customform.Dock = System.Windows.Forms.DockStyle.Fill;

                coursepanel.Controls.Add(customform);
                customform.Show();
            }
            else
            {
                coursepanel.Controls.Clear();
                FESTCustom Studentcustom = new FESTCustom();
                Studentcustom.TopLevel = false;

                // Set the form to dock within the panel
                Studentcustom.Dock = System.Windows.Forms.DockStyle.Fill;

                coursepanel.Controls.Add(Studentcustom);
                Studentcustom.Show();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            DBHandouts.whatweek = "Week1";
            btnhandout.Enabled = true;
            btncustom.Enabled = true;
        }

        private void btnweek2_Click(object sender, EventArgs e)
        {
            DBHandouts.whatweek = "Week2";
            btnhandout.Enabled = true;
            btncustom.Enabled = true;
        }

        private void btnweek3_Click(object sender, EventArgs e)
        {
            DBHandouts.whatweek = "Week3";
            btnhandout.Enabled = true;
            btncustom.Enabled = true;
        }

        private void btnweek4_Click(object sender, EventArgs e)
        {
            DBHandouts.whatweek = "Week4";
            btnhandout.Enabled = true;
            btncustom.Enabled = true;
        }

        private void btnweek5_Click(object sender, EventArgs e)
        {
            DBHandouts.whatweek = "Week5";
            btnhandout.Enabled = true;
            btncustom.Enabled = true;
        }
    }
}
