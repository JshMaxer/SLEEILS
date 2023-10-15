using Org.BouncyCastle.Asn1.Tsp;
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
    public partial class InformationList : Form
    {
        public InformationList()
        {
            InitializeComponent();
        }

        private void InformationList_Load(object sender, EventArgs e)
        {
            //Student Type
            listBox1.Items.Add("STUDENT TYPE");
            listBox1.Items.Add(Backend.StudentEnroll.listtype);

            //Required Field
            listBox1.Items.Add("");
            listBox1.Items.Add("REQUIRED FIELDS");
            listBox1.Items.Add(Backend.StudentEnroll.listrequiredadmit);
            listBox1.Items.Add(Backend.StudentEnroll.listrequiredyearlevel);
            listBox1.Items.Add(Backend.StudentEnroll.listrequiredschoolyear);
            listBox1.Items.Add(Backend.StudentEnroll.listrequiredterm);

            //Strand
            listBox1.Items.Add("");
            listBox1.Items.Add("STRAND");
            listBox1.Items.Add(Backend.StudentEnroll.strandchoice);

            //Students Information
            listBox1.Items.Add("");
            listBox1.Items.Add("STUDENT INFORMATION");
            listBox1.Items.Add(Backend.StudentEnroll.listfname);
            listBox1.Items.Add(Backend.StudentEnroll.listmname);
            listBox1.Items.Add(Backend.StudentEnroll.listlname);
            listBox1.Items.Add(Backend.StudentEnroll.listsuffix);
            listBox1.Items.Add(Backend.StudentEnroll.listgender);
            listBox1.Items.Add(Backend.StudentEnroll.liststatus);
            listBox1.Items.Add(Backend.StudentEnroll.listCitizenship);
            listBox1.Items.Add(Backend.StudentEnroll.listbirth);
            listBox1.Items.Add(Backend.StudentEnroll.listbirthplace);
            listBox1.Items.Add(Backend.StudentEnroll.listreligion);
            listBox1.Items.Add(Backend.StudentEnroll.listaddress);
            listBox1.Items.Add(Backend.StudentEnroll.listemail);
            listBox1.Items.Add(Backend.StudentEnroll.listmobile);
            listBox1.Items.Add(Backend.StudentEnroll.listtelephone);

            //Guardian Information
            listBox1.Items.Add("");
            listBox1.Items.Add("GUARDIAN INFORMATION");
            listBox1.Items.Add(Backend.StudentEnroll.listgfname);
            listBox1.Items.Add(Backend.StudentEnroll.listgmname);
            listBox1.Items.Add(Backend.StudentEnroll.listglname);
            listBox1.Items.Add(Backend.StudentEnroll.listgsuffix);
            listBox1.Items.Add(Backend.StudentEnroll.listggender);
            listBox1.Items.Add(Backend.StudentEnroll.listgstatus);
            listBox1.Items.Add(Backend.StudentEnroll.listgCitizenship);
            listBox1.Items.Add(Backend.StudentEnroll.listgbirth);
            listBox1.Items.Add(Backend.StudentEnroll.listgbirthplace);
            listBox1.Items.Add(Backend.StudentEnroll.listgreligion);
            listBox1.Items.Add(Backend.StudentEnroll.listgaddress);
            listBox1.Items.Add(Backend.StudentEnroll.listgemail);
            listBox1.Items.Add(Backend.StudentEnroll.listgmobile);
            listBox1.Items.Add(Backend.StudentEnroll.listgtelephone);
            listBox1.Items.Add(Backend.StudentEnroll.listgrelationship);
            listBox1.Items.Add(Backend.StudentEnroll.listgoccupation);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
