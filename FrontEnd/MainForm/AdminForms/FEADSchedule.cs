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

namespace SMARTLEARN.FrontEnd.AdminForms
{
    public partial class FEADSchedule : Form
    {

        Database.DBADSchedule sched = new Database.DBADSchedule();

        public FEADSchedule()
        {
            InitializeComponent();
        }

        private void FEADSchedule_Load(object sender, EventArgs e)
        {
            sched.showStudentID(cbsection, cbids);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            sched.InsertPFB(cbsection, cbids, pfbmonday1, pfbmonday2, pfbtuesday1, pfbtuesday2, pfbwednesday1, pfbwednesday2, pfbthursday1, pfbthursday2, pfbfriday1, pfbfriday2, MessageDialog1);
            sched.InsertWDD(cbsection, cbids, wddmonday1, wddmonday2, wddtuesday1, wddtuesday2, wddwednesday1, wddwednesday2, wddthursday1, wddthursday2, wddfriday1, wddfriday2, MessageDialog1);
            sched.InsertITE(cbsection, cbids, itemonday1, itemonday2, itetuesday1, itetuesday2, itewednesday1, itewednesday2, itethursday1, itethursday2, itefriday1, itefriday2, MessageDialog1);
            sched.InsertCHS(cbsection, cbids, chsmonday1, chsmonday2, chstuesday1, chstuesday2, chswednesday1, chswednesday2, chsthursday1, chsthursday2, chsfriday1, chsfriday2, MessageDialog1);
        }

        private void cbsection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbids.Items.Clear();
            txtfname.Text = null;
            txtlname.Text = null;
            sched.showStudentID(cbsection, cbids);
        }

        private void cbids_SelectedIndexChanged(object sender, EventArgs e)
        {
            sched.ShownamePassID(cbsection, cbids, txtfname, txtlname);
        }

    }
}
