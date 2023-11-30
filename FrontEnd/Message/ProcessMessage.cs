using System;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class ProcessMessage : Form
    {
        //Set a flag for messages
        public static string firstmessage;
        public static string secondmessage;


        public ProcessMessage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FEInformationList.whatforms == "Faculty" || FEInformationList.whatforms == "Student")
            {
                //restore to default settings
                Backend.BEAdregister.confirm = false;
                Backend.BEAdregister.resetform = false;

                Backend.BEStudentEnroll.confirm = false;
                Backend.BEStudentEnroll.resetform = false;

                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void ProcessMessage_Load(object sender, EventArgs e)
        {
            lblfirstmeeage.Text = firstmessage;
            lblsecondmessage.Text = secondmessage;
        }
    }
}
