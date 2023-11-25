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
                //Student Type
                listBox1.Items.Add("STUDENT TYPE");
                listBox1.Items.Add(Backend.BEStudentEnroll.listtype);

                //Required Field
                listBox1.Items.Add("");
                listBox1.Items.Add("REQUIRED FIELDS");
                listBox1.Items.Add(Backend.BEStudentEnroll.listrequiredadmit);
                listBox1.Items.Add(Backend.BEStudentEnroll.listrequiredyearlevel);
                listBox1.Items.Add(Backend.BEStudentEnroll.listrequiredschoolyear);
                listBox1.Items.Add(Backend.BEStudentEnroll.listrequiredterm);

                //Strand
                listBox1.Items.Add("");
                listBox1.Items.Add("STRAND");
                listBox1.Items.Add(Backend.BEStudentEnroll.strandchoice);

                //Students Information
                listBox1.Items.Add("");
                listBox1.Items.Add("STUDENT INFORMATION");
                listBox1.Items.Add(Backend.BEStudentEnroll.listfname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listmname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listlname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listsuffix);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgender);
                listBox1.Items.Add(Backend.BEStudentEnroll.liststatus);
                listBox1.Items.Add(Backend.BEStudentEnroll.listCitizenship);
                listBox1.Items.Add(Backend.BEStudentEnroll.listbirth);
                listBox1.Items.Add(Backend.BEStudentEnroll.listbirthplace);
                listBox1.Items.Add(Backend.BEStudentEnroll.listreligion);
                listBox1.Items.Add(Backend.BEStudentEnroll.listaddress);
                listBox1.Items.Add(Backend.BEStudentEnroll.listemail);
                listBox1.Items.Add(Backend.BEStudentEnroll.listmobile);
                listBox1.Items.Add(Backend.BEStudentEnroll.listtelephone);

                //Guardian Information
                listBox1.Items.Add("");
                listBox1.Items.Add("GUARDIAN INFORMATION");
                listBox1.Items.Add(Backend.BEStudentEnroll.listgfname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgmname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listglname);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgsuffix);
                listBox1.Items.Add(Backend.BEStudentEnroll.listggender);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgstatus);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgCitizenship);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgbirth);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgbirthplace);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgreligion);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgaddress);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgemail);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgmobile);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgtelephone);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgrelationship);
                listBox1.Items.Add(Backend.BEStudentEnroll.listgoccupation);
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
            Backend.BEStudentEnroll.closeform = true; //close FERegisterAdmin or current form.
            
            Backend.BEAdregister.confirm = true; //Throw the data to database.
            Backend.BEAdregister.resetform = true; //reset FERegisterAdmin or current form.

            this.Close();
        }
    }
}
