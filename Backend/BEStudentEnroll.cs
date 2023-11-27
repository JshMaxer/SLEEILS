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
        public static bool resetform;

       

        //Students Information
        public static string listid;
        public static string listyearlevel;
        public static string liststrand;
        public static string listfname;
        public static string listmname;
        public static string listlname;
        public static string listgender;
        public static string listbirth;
        public static string listemail;
        public static string listmobile;
        public static string listpassword;

        public void studentinfo(Guna2TextBox firstID, Guna2TextBox secondID, Guna2ComboBox yearlevel, Guna2ComboBox strand, Guna2TextBox password, Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2ComboBox gender, Guna2DateTimePicker birth, Guna2TextBox email, Guna2TextBox mobile)
        {
            listid = ($"Student ID: {firstID.Text + secondID.Text}");
            listyearlevel = ($"Student Year Level: {yearlevel.Text}");
            liststrand = ($"Student Strand: {strand.Text}");
            listfname = ($"Student First name: {fname.Text}");
            listmname = ($"Student Middle name: {mname.Text}");
            listlname = ($"Student Last name: {lname.Text}");
            listgender = ($"Student Gender: {gender.Text}");
            listbirth = ($"Student birthday: {birth.Value.ToString("MM-dd-yyyy")}");
            listemail = ($"Student Email: {email.Text}");
            listmobile = ($"Student Mobile: {mobile.Text}");
            listpassword = ($"Student password: {password.Text}");
        }

    }
}
