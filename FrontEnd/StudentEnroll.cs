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
    public partial class StudentEnroll : Form
    {
        public StudentEnroll()
        {
            InitializeComponent();
        }

        private void rbnewstudent_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnewstudent.Checked)
            {
                requiredfields.Visible = true;
            }
            else
            {
                
                requiredfields.Visible = false;
            }
        }

        private void dbschoolyear_DropDown(object sender, EventArgs e)
        {
            cbschoolyear.Items.Clear();
            int currentYear = DateTime.Now.Year;
            cbschoolyear.Items.Add(currentYear);

        }

        private void cbxothers_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxothers.Checked)
            {
                txtothers.Enabled = true;
            }
            else
            {
                txtothers.Enabled = false;
            }
        }
    }
}
