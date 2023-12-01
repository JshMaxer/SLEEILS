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
    public partial class FEADHandoutForm : Form
    {
        Database.DBHandouts handouts = new Database.DBHandouts();
        public FEADHandoutForm()
        {
            InitializeComponent();
        }

        private void btnuploadhandout_Click(object sender, EventArgs e)
        {
            handouts.inserthandout(lbhandouts);
        }

        private void FEADHandoutForm_Load(object sender, EventArgs e)
        {
            handouts.showhandout(lbhandouts);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            handouts.deleteSelectedHandout(lbhandouts);
        }
    }
}
