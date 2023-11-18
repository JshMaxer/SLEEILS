using System;
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
            
            FrontEnd.FEHome home = new FEHome();
            home.Show();

            FrontEnd.FEDashboard.timertoclose = true; //Close the Dashboard
            //this.Close();
        }
    }
}
