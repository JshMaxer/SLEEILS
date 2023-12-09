using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.MainForm.AdminForms
{
    public partial class FEADHandoutForm : Form
    {
        Database.DBHandouts handouts = new Database.DBHandouts();
        public FEADHandoutForm()
        {
            InitializeComponent();
        }

        private void btnuploadhandout_Click(object sender, EventArgs e)
        {
            handouts.inserthandout(lbhandouts, MessageDialog1);
        }

        private void FEADHandoutForm_Load(object sender, EventArgs e)
        {
            handouts.showhandout(lbhandouts);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            handouts.deleteSelectedHandout(lbhandouts);
        }

        private void lbhandouts_DoubleClick(object sender, EventArgs e)
        {
            //
        }



    }
}
