using SMARTLEARN.FrontEnd.MainForm.FacultyForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.AdminForms
{
    public partial class FEFAGrades : Form
    {
        private Dictionary<Control, Point> originalPositions = new Dictionary<Control, Point>();
        private Size defaultSize = new Size(1150, 775);

        public FEFAGrades()
        {
            InitializeComponent();
            this.Resize += FEFAGrades_Resize; // Attach the Resize event handler

            // Store original positions of controls
            StoreOriginalPositions();
        }

        private void FEFAGrades_Resize(object sender, EventArgs e)
        {
            AdjustControlPositions();
        }

        private void StoreOriginalPositions()
        {
            originalPositions.Add(btnprogramming, btnprogramming.Location);
            originalPositions.Add(btnwebdevelopment, btnwebdevelopment.Location);
            originalPositions.Add(btncomputerharware, btncomputerharware.Location);
            originalPositions.Add(btnitesssentials, btnitesssentials.Location);

            originalPositions.Add(lblprogramming, lblprogramming.Location);
            originalPositions.Add(lblwebdevelopment, lblwebdevelopment.Location);
            originalPositions.Add(lblcomputerharware, lblcomputerharware.Location);
            originalPositions.Add(lblitesssentials, lblitesssentials.Location);
        }

        private void AdjustControlPositions()
        {
            double widthRatio = (double)Width / defaultSize.Width;
            double heightRatio = (double)Height / defaultSize.Height;

            foreach (var control in originalPositions)
            {
                int newX = (int)(control.Value.X * widthRatio);
                int newY = (int)(control.Value.Y * heightRatio);
                control.Key.Location = new Point(newX, newY);
            }
        }

        private void btnprogramming_Click(object sender, EventArgs e)
        {
            Database.DBFAGrading.sub = "Programming for Beginners";
            FEFAGrading grading = new FEFAGrading();
            grading.ShowDialog();
        }

        private void btnwebdevelopment_Click(object sender, EventArgs e)
        {
            Database.DBFAGrading.sub = "Web Development Design";
            FEFAGrading grading = new FEFAGrading();
            grading.ShowDialog();
        }

        private void btnitesssentials_Click(object sender, EventArgs e)
        {
            Database.DBFAGrading.sub = "IT Essentials";
            FEFAGrading grading = new FEFAGrading();
            grading.ShowDialog();
        }

        private void btncomputerharware_Click(object sender, EventArgs e)
        {
            Database.DBFAGrading.sub = "Computer Hardware Servicing";
            FEFAGrading grading = new FEFAGrading();
            grading.ShowDialog();
        }
    }
}
