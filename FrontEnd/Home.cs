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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnshowlog_Click(object sender, EventArgs e)
        {
            FrontEnd.Login logstu = new Login();
            logstu.TopMost = true;
            logstu.Show();

            FrontEnd.Login.showlog = false;
            LoginAdmin.showlog = false;
            //btnshowlog.Enabled = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void timertoshow_Tick(object sender, EventArgs e)
        {
            btnshowlog.Enabled = FrontEnd.Login.showlog;
            btnshowlog.Enabled = LoginAdmin.showlog;
        }
    }
}
