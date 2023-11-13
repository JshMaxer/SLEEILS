using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SMARTLEARN.Backend
{
    public class BEAdregister
    {
        //Set a flag to know if the information is corrected or ready to next.
        public static bool confirm = false;

        //Set a flag for timer to close the form of StudenEnroll
        public static bool closeform;

        //Student Type
        public static string listtype;

        //Role
        public static string listuserid;
        public static string listgender = "";
        public static string listdepartment = "";
        public static string listrole = "";

        //Personal Information
        public static string listfirstname = "";
        public static string listmiddlename = "";
        public static string listlastname = "";
        public static string listemail = "";
        public static string listmobilenumber;
        public static string listbirthdate = "";
        public static string listpassword = "";

        public void grouprole(Guna2TextBox userid, Guna2ComboBox gender, Guna2ComboBox department)
        {
            listuserid = ($"User ID = {userid.Text}");
            listgender = $"Gender = {gender.Text}";
            listdepartment = $"Department = {department.Text}";
        }

        public void personal(Guna2TextBox fname, Guna2TextBox mname, Guna2TextBox lname, Guna2TextBox email, Guna2TextBox mobile, Guna2DateTimePicker birthdate, Guna2TextBox password)
        {
            listfirstname = ($"First Name = {fname.Text}");
            listmiddlename = $"Middle Name = {mname.Text}";
            listlastname = $"Last Name = {lname.Text}";
            listemail = $"Email = {email.Text}";
            listmobilenumber = $"Mobile Number = {mobile.Text}";
            listbirthdate = ($"Date of birth: {birthdate.Value.ToString("MM-dd-yyyy")}");
            listpassword = $"Password: {password.Text}";
        }
    }
}
