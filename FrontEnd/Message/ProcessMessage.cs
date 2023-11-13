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
        public static string message;
        public ProcessMessage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //restore to default settings
            Backend.BEStudentEnroll.confirm = false;
            Backend.BEStudentEnroll.closeform = false;

            Backend.BEAdregister.confirm = false;
            Backend.BEAdregister.closeform = false;

            this.Close();

            FEHome home = new FEHome();
            home.Show();
        }

        private void ProcessMessage_Load(object sender, EventArgs e)
        {
            lblmessage.Text = message;
        }
    }
}
