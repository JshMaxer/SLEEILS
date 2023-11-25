using System;
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
            if (message == "YOU'RE NOW\r\nREGISTERED!")
            {
                //restore to default settings
                Backend.BEAdregister.confirm = false;
                Backend.BEAdregister.resetform = false;

                this.Close();
            }
            else
            {
                //restore to default settings
                Backend.BEStudentEnroll.confirm = false;
                Backend.BEStudentEnroll.closeform = false;

                this.Close();

                FEHome home = new FEHome();
                home.Show();
            }
        }

        private void ProcessMessage_Load(object sender, EventArgs e)
        {
            lblmessage.Text = message;
        }
    }
}
