using SMARTLEARN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.MainForm.AdminForms
{
    public partial class FEADResetpass : Form
    {
        DBresetpass chng = new DBresetpass();
        public FEADResetpass()
        {
            InitializeComponent();
        }

        private void DGVlist_SelectionChanged(object sender, EventArgs e)
        {
            chng.ClickDGV(DGVlist, txtID, txtfname, txtlname);
        }

        private void FEADChangepass_Load(object sender, EventArgs e)
        {
            chng.searchAccount(DGVlist, MessageDialog1);
        }

        private void btnshowlog_Click(object sender, EventArgs e)
        {
            chng.updatePass(DGVlist, txtID, txtfname, txtlname, MessageDialog1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtfname.Text) && string.IsNullOrEmpty(txtlname.Text) && string.IsNullOrEmpty(txtID.Text))
            {
                btnreset.Enabled = false;
            }
            else
            {
                btnreset.Enabled = true;
            }
        }

    }
}
