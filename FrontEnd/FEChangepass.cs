using SMARTLEARN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEChangepass : Form
    {

        public FEChangepass()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            DBChangepass dBChangepass = new DBChangepass();
            dBChangepass.changepass(txtcurrentpass, txtnewpass, txtconfirmpass, errorProvider1);
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
