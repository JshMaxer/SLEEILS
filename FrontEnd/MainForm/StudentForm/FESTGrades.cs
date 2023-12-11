using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.MainForm.StudentForm
{
    public partial class FESTGrades : Form
    {
        public FESTGrades()
        {
            InitializeComponent();
        }

        private void FESTGrades_Load(object sender, EventArgs e)
        {
            Database.DBStudentGrade grade = new Database.DBStudentGrade();
            grade.Display(DGVStudentlist, cbsemester, MessageDialog1);
        }

        private void cbsemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.DBStudentGrade grade = new Database.DBStudentGrade();
            grade.Display(DGVStudentlist, cbsemester, MessageDialog1);
        }
    }
}
