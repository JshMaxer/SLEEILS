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
    public partial class Login : Form
    {
        public static bool showlog = true;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*TO MAKE THE BUTTON AND PANEL OPACITY > TRANSPARENT
            logpanel.BackColor = Color.FromArgb(100, 0,0,0);
            btnlogin.FillColor = Color.FromArgb(100, 0, 0, 0);
            btnloginadmin.FillColor = Color.FromArgb(100, 0, 0, 0);
            */
        }


        private void btnloginadmin_Click_1(object sender, EventArgs e)
        {
            LoginAdmin logadmin = new LoginAdmin();
            logadmin.TopMost = true;
            logadmin.Show();

            this.Close();
        }

        private void lblforgot_Click_1(object sender, EventArgs e)
        {
            FrontEnd.LoadingForm load = new FrontEnd.LoadingForm();
            load.TopMost = true;
            load.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            showlog = true;
            LoginAdmin.showlog = true;
            this.Close();
        }
    }
}
