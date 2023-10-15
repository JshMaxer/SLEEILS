using SMARTLEARN.FrontEnd;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMARTLEARN
{
    //FrontEnd
    public partial class LoginAdmin : Form
    {
        public static bool showlog = true;
        public LoginAdmin()
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
            FrontEnd.Login logstu = new FrontEnd.Login();
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
            FrontEnd.Login.showlog = true;
            showlog = true;
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Backend.LoginAdmin Logadmin = new Backend.LoginAdmin();
            Logadmin.Login(txtuserid, txtpassword);
        }
    }
}
