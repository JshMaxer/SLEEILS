using SMARTLEARN.Model;
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
    public partial class FEFASTSchedule : Form
    {
        public FEFASTSchedule()
        {
            InitializeComponent();
        }

        private void FESTSchedule_Load(object sender, EventArgs e)
        {
            txtname.Text = Accounts.user;

            Database.DBSTSchedule dBSTSchedule = new Database.DBSTSchedule();
            dBSTSchedule.showsched(DGVschedule, MessageDialog1);
        }
    }
}
