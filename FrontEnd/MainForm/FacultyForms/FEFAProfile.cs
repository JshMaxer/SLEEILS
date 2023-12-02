using SMARTLEARN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.MainForm.FacultyForms
{
    public partial class FEFAProfile : Form
    {
        public FEFAProfile()
        {
            InitializeComponent();
        }


        public static bool closeform = false;


        private void timerclose_Tick(object sender, EventArgs e)
        {
            if (closeform == true)
            {
                this.Close();
            }
        }

        private void FEFAProfile_Load(object sender, EventArgs e)
        {
            Database.DBFacultyProfile Facprofile = new DBFacultyProfile();
            Facprofile.showinfo(lblname, lblemail, lblmobile, lbldepartment, lblrole, lbluserid);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
