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
    public partial class FESTCustom : Form
    {
        public FESTCustom()
        {
            InitializeComponent();
        }

        private void btndownload_Click_1(object sender, EventArgs e)
        {
            DBSTCustomDownload dl = new DBSTCustomDownload();
            dl.DownloadSelectedHandout(lbcustom, MessageDialog1);
        }

        private void FESTCustom_Load(object sender, EventArgs e)
        {
            DBFACustom custom = new DBFACustom();
            custom.ShowCustom(lbcustom, MessageDialog1);
        }
    }
}
