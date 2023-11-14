using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEDashboard : Form
    {
        private bool isPanelVisible = false;

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
    }
}
