using Guna.UI2.WinForms;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SMARTLEARN.Backend
{
    //Backend
    public class BEStudentEnroll
    {
        //Set a flag to know if the information is corrected or ready to next. The database will automaticall insert this to table
        public static bool confirm = false;

        //Set a flag for timer to close the form of StudenEnroll
        public static bool closeform;

        //Student Type
        public static string listtype; 

        //Required Fields
        public static string listrequiredadmit = "";
        public static string listrequiredyearlevel = "";
        public static string listrequiredschoolyear = "";
        public static string listrequiredterm = "";

        //Strand
        public static string strandchoice;

        //Students Information
        public static string listfname;
        public static string listmname;
        public static string listlname;
        public static string listsuffix;
        public static string listgender;
        public static string liststatus;
        public static string listCitizenship;
        public static string listbirth;
        public static string listbirthplace;
        public static string listreligion;
        public static string listaddress;
        public static string listemail;
        public static string listmobile;
        public static string listtelephone;

        //Guardian Information
        public static string listgfname;
        public static string listgmname;
        public static string listglname;
        public static string listgsuffix;
        public static string listggender;
        public static string listgstatus;
        public static string listgCitizenship;
        public static string listgbirth;
        public static string listgbirthplace;
        public static string listgreligion;
        public static string listgaddress;
        public static string listgemail;
        public static string listgmobile;
        public static string listgtelephone;
        public static string listgrelationship;
        public static string listgoccupation;

        public void typeofstu(Guna2RadioButton newstu, Guna2RadioButton existstu)
        {
            if (newstu.Checked == true && existstu.Checked == false)
            {
                listtype = ($"Type of Student: {newstu.Text}");
            }
            else if (newstu.Checked == false && existstu.Checked == true)
            {
                listtype = ($"Type of Student: {existstu.Text}");
            }

        }

        public void requiredfields(Guna2ComboBox admittype, Guna2ComboBox yearlevel, Guna2ComboBox schoolyear, Guna2ComboBox term)
        {
            listrequiredadmit = ($"Admit Type:          {admittype.Text}");
            listrequiredyearlevel = ($"Year Level:          {yearlevel.Text}");
            listrequiredschoolyear = ($"Admit Type:          {schoolyear.Text}");
            listrequiredterm = ($"Term Type:           {term.Text}");
        }

        public void strand(Guna2RadioButton ICT)
        {
            if(ICT.Checked == true)
            {
                strandchoice = ($"Strand: {ICT.Text}");
            }
        }

        public void studentInfo(Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2TextBox suffix, Guna2ComboBox gender, Guna2ComboBox status, Guna2TextBox Citizenship, Guna2DateTimePicker birth, Guna2TextBox birthplace, Guna2TextBox religion, Guna2TextBox address, Guna2TextBox email, Guna2TextBox mobile, Guna2TextBox telephone)
        {
            listfname = ($"First Name: {fname.Text}");
            listmname = ($"Middle Name: {mname.Text}");
            listlname = ($"Last Name: {lname.Text}");
            listsuffix = ($"Suffix: {suffix.Text}");
            listgender = ($"Gender: {gender.Text}");
            liststatus = ($"Status: {status.Text}");
            listCitizenship = ($"Citizenship: {Citizenship.Text}");
            listbirth = ($"Date of birth: {birth.Value.ToString("MM-dd-yyyy")}");
            listbirthplace = ($"Birthplace: {birthplace.Text}");
            listreligion = ($"Religion: {religion.Text}");
            listaddress = ($"Address: {address.Text}");
            listemail = ($"Email: {email.Text}");
            listmobile = ($"Mobile Number: {mobile.Text}");
            listtelephone = ($"Telephone Number: {telephone.Text}");
        }

        public void guardianInfo(Guna2TextBox gfname, Guna2TextBox gmname, Guna2TextBox glname, Guna2TextBox gsuffix, Guna2ComboBox ggender, Guna2ComboBox gstatus, Guna2TextBox gCitizenship, Guna2DateTimePicker gbirth, Guna2TextBox gbirthplace, Guna2TextBox greligion, Guna2TextBox gaddress, Guna2TextBox gemail, Guna2TextBox gmobile, Guna2TextBox gtelephone, Guna2TextBox grelationship, Guna2TextBox goccupation)
        {
            listgfname = ($"First Name: {gfname.Text}");
            listgmname = ($"Middle Name: {gmname.Text}");
            listglname = ($"Last Name: {glname.Text}");
            listgsuffix = ($"Suffix: {gsuffix.Text}");
            listggender = ($"Gender: {ggender.Text}");
            listgstatus = ($"Status: {gstatus.Text}");
            listgCitizenship = ($"Citizenship: {gCitizenship.Text}");
            listgbirth = ($"Date of birth: {gbirth.Value.ToString("MM-dd-yyyy")}");
            listgbirthplace = ($"Birthplace: {gbirthplace.Text}");
            listgreligion = ($"Religion: {greligion.Text}");
            listgaddress = ($"Address: {gaddress.Text}");
            listgemail = ($"Email: {gemail.Text}");
            listgmobile = ($"Mobile Number: {gmobile.Text}");
            listgtelephone = ($"Telephone Number: {gtelephone.Text}");
            listgrelationship = ($"Relationship: {grelationship.Text}");
            listgoccupation = ($"Occupation: {goccupation.Text}");
        }

    }
}
