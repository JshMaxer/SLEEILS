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
    public partial class ProcessMessage : Form
    {
        public ProcessMessage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();

            //restore to default settings
            Backend.StudentEnroll.closeform = false;
            Backend.StudentEnroll.confirm = "";

            Home home = new Home();
            home.Show();
        }
    }
}
