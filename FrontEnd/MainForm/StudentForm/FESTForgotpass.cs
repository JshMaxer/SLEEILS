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

namespace SMARTLEARN.FrontEnd.MainForm.StudentForm
{
    public partial class FESTForgotpass : Form
    {
        public FESTForgotpass()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            DBSTForgotpass forgot = new DBSTForgotpass();
            forgot.forgot(txtstudentid, errorProvider1, MessageDialog1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
