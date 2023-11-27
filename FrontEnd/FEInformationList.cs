using System;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEInformationList : Form
    {
        //set a flag to know what form is using
        public static string whatforms;

        public FEInformationList()
        {
            InitializeComponent();
        }

        private void InformationList_Load(object sender, EventArgs e)
        {
            if(whatforms == "Student")
            {
                //Students Information
                listBox1.Items.Add("");
                listBox1.Items.Add("STUDENT INFORMATION");
                listBox1.Items.Add(Backend.BEStudentEnroll.listid);
                listBox1.Items.Add(Backend.BEStudentEnroll.listyearlevel);
                listBox1.Items.Add(Backend.BEStudentEnroll.liststrand);
                listBox1.Items.Add(Backend.BEStudentEnroll.listfname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listmname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listlname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgender);
                listBox1.Items.Add(Backend.BEStudentEnroll.listbirth);
                listBox1.Items.Add(Backend.BEStudentEnroll.listemail);
                listBox1.Items.Add(Backend.BEStudentEnroll.listmobile);
                listBox1.Items.Add(Backend.BEStudentEnroll.listpassword);
            }
            else 
            {
                //Role
                listBox1.Items.Add("ROLE INFORMATION");
                listBox1.Items.Add(Backend.BEAdregister.listuserid);
                listBox1.Items.Add(Backend.BEAdregister.listgender);
                listBox1.Items.Add(Backend.BEAdregister.listdepartment);
                listBox1.Items.Add(Backend.BEAdregister.listrole);

                //Personal
                listBox1.Items.Add("");
                listBox1.Items.Add("PERSONAL INFORMATION");
                listBox1.Items.Add(Backend.BEAdregister.listfirstname);
                listBox1.Items.Add(Backend.BEAdregister.listmiddlename);
                listBox1.Items.Add(Backend.BEAdregister.listlastname);
                listBox1.Items.Add(Backend.BEAdregister.listemail);
                listBox1.Items.Add(Backend.BEAdregister.listmobilenumber);
                listBox1.Items.Add(Backend.BEAdregister.listbirthdate);
                listBox1.Items.Add(Backend.BEAdregister.listpassword);
            }
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Backend.BEStudentEnroll.confirm = true; //Throw the data to database.
            Backend.BEStudentEnroll.resetform = true; //close FERegisterAdmin or current form.
            
            Backend.BEAdregister.confirm = true; //Throw the data to database.
            Backend.BEAdregister.resetform = true; //reset FERegisterAdmin or current form.

            this.Close();
        }
    }
}
