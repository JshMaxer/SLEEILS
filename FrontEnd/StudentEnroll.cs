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
                cbadmittype.SelectedItem = null;
                cbyearlevel.SelectedItem = null;
                cbschoolyear.SelectedItem = null;
                cbterm.SelectedItem = null;
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void rbexistingstudent_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
