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
    public partial class FAFACustomForm : Form
    {
        Database.DBFACustom custom = new Database.DBFACustom();

        public FAFACustomForm()
        {
            InitializeComponent();
        }

        private void FACustomForm_Load(object sender, EventArgs e)
        {
            custom.ShowCustom(lbcustom);
        }

        private void btnuploadhandout_Click(object sender, EventArgs e)
        {
            custom.InsertCustom(lbcustom);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            custom.DeleteSelectedCustom(lbcustom);
        }
    }
}
