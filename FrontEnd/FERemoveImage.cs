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

namespace SMARTLEARN.FrontEnd
{
    public partial class FERemoveImage : Form
    {
        DBRemovepic bRemovepic = new DBRemovepic();
        public FERemoveImage()
        {
            InitializeComponent();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            bRemovepic.removepic(cbids);
        }

        private void FERemoveImage_Load(object sender, EventArgs e)
        {
            bRemovepic.showid(cbids);
        }

        private void cbcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbids_SelectedIndexChanged(object sender, EventArgs e)
        {
            bRemovepic.showimageinid(cbids, pictureboxremove);
        }
    }
}
