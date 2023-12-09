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
    public partial class FEForumMessage : Form
    {
        Database.DBForumMessage forummess = new Database.DBForumMessage();
        public FEForumMessage()
        {
            InitializeComponent();
        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            forummess.message(richTextBox1, MessageDialog1);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
