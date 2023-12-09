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
    public partial class FEForum : Form
    {
        public FEForum()
        {
            InitializeComponent();
        }

        private void FEForum_Load(object sender, EventArgs e)
        {
            Database.DBForum forum = new Database.DBForum();
            forum.forum(DGVforum, MessageDialog1);
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            FEForumMessage forumMessage = new FEForumMessage();
            forumMessage.ShowDialog();
        }

        private void DGVforum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
