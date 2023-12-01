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

namespace SMARTLEARN.FrontEnd.MainForm.FacultyForms
{
    public partial class FEFAHandout : Form
    {
        public FEFAHandout()
        {
            InitializeComponent();
        }

        private void FEFAHandout_Load(object sender, EventArgs e)
        {
            DBHandouts handout = new DBHandouts();
            handout.showhandout(lbhandouts);
        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            DBFASTGHandoutDownload dl = new DBFASTGHandoutDownload();
            dl.downloadSelectedHandout(lbhandouts);
        }
    }
}
