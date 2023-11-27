using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.Message
{

    public partial class ProcessDeclineMessage : Form
    {
        public static string message;
        public ProcessDeclineMessage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //restore to default settings
            Backend.BEStudentEnroll.confirm = false;
            Backend.BEStudentEnroll.resetform = false;

            Backend.BEAdregister.confirm = false;
            Backend.BEAdregister.resetform = false;

            this.Close();

            FEHome home = new FEHome();
            home.Show();
        }

        private void ProcessDeclineMessage_Load(object sender, EventArgs e)
        {
            lblmessage.Text = message;
        }
    }
}
