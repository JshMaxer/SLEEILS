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
            if (firstmessage == "YOU'RE NOW" && secondmessage == "REGISTERED!")
            {
                //restore to default settings
                Backend.BEAdregister.confirm = false;
                Backend.BEAdregister.resetform = false;

                this.Close();
            }
            else if(firstmessage == "DATABASE NOT FOUND!" && secondmessage == "Check if it's imported or turned off.")
            {
                FELoginAdmin.showlog = false;
                FELogin.showlog = false;

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
            lblfirstmeeage.Text = firstmessage;
            lblsecondmessage.Text = secondmessage;
        }
    }
}
