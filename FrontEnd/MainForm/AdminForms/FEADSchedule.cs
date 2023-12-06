using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd.AdminForms
{
    public partial class FEADSchedule : Form
    {

        Database.DBADSchedule sched = new Database.DBADSchedule();

        public FEADSchedule()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //Database
            
            sched.UpdateMonday(monday1, monday2, monday3, monday4, monday5, monday6, monday7, monday8, monday9, monday10, monday11, monday12, monday13, monday14, monday15, monday16, monday17, cbstufac);
            sched.UpdateTuesday(tuesday1, tuesday2, tuesday3, tuesday4, tuesday5, tuesday6, tuesday7, tuesday8, tuesday9, tuesday10, tuesday11, tuesday12, tuesday13, tuesday14, tuesday15, tuesday16, tuesday17, cbstufac);
            sched.UpdateWednesday(wednesday1, wednesday2, wednesday3, wednesday4, wednesday5, wednesday6, wednesday7, wednesday8, wednesday9, wednesday10, wednesday11, wednesday12, wednesday13, wednesday14, wednesday15, wednesday16, wednesday17, cbstufac);
            sched.UpdateThursday(thursday1, thursday2, thursday3, thursday4, thursday5, thursday6, thursday7, thursday8, thursday9, thursday10, thursday11, thursday12, thursday13, thursday14, thursday15, thursday16, thursday17, cbstufac);
            sched.UpdateFriday(friday1, friday2, friday3, friday4, friday5, friday6, friday7, friday8, friday9, friday10, friday11, friday12, friday13, friday14, friday15, friday16, friday17, cbstufac);

        }

        private void FEADSchedule_Load(object sender, EventArgs e)
        {
            //Show the student name first in ComboBox.
            sched.showStudent(cbstudent, cbstufac);
        }

        private void cbstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the method with different time slots
          sched.ShowSchedule("7:00 - 7:30", monday1, tuesday1, wednesday1, thursday1, friday1, cbstufac);
          sched.ShowSchedule("7:30 - 8:30", monday2, tuesday2, wednesday2, thursday2, friday2, cbstufac);
          sched.ShowSchedule("8:30 - 9:00", monday3, tuesday3, wednesday3, thursday3, friday3, cbstufac);
          sched.ShowSchedule("9:00 - 9:30", monday4, tuesday4, wednesday4, thursday4, friday4, cbstufac);
          sched.ShowSchedule("9:30 - 10:00", monday5, tuesday5, wednesday5, thursday5, friday5, cbstufac);
          sched.ShowSchedule("10:00 - 10:30", monday6, tuesday6, wednesday6, thursday6, friday6, cbstufac);
          sched.ShowSchedule("10:30 - 11:00", monday7, tuesday7, wednesday7, thursday7, friday7, cbstufac);
          sched.ShowSchedule("11:00 - 11:30", monday8, tuesday8, wednesday8, thursday8, friday8, cbstufac);
          sched.ShowSchedule("11:30 - 12:00", monday9, tuesday9, wednesday9, thursday9, friday9, cbstufac);
          sched.ShowSchedule("12:00 - 12:30", monday10, tuesday10, wednesday10, thursday10, friday10, cbstufac);
          sched.ShowSchedule("12:30 - 1:00", monday11, tuesday11, wednesday11, thursday11, friday11, cbstufac);
          sched.ShowSchedule("1:00 - 1:30", monday12, tuesday12, wednesday12, thursday12, friday12, cbstufac);
          sched.ShowSchedule("1:30 - 2:00", monday13, tuesday13, wednesday13, thursday13, friday13, cbstufac);
          sched.ShowSchedule("2:00 - 2:30", monday14, tuesday14, wednesday14, thursday14, friday14, cbstufac);
          sched.ShowSchedule("2:30 - 3:00", monday15, tuesday15, wednesday15, thursday15, friday15, cbstufac);
          sched.ShowSchedule("3:00 - 3:30", monday16, tuesday16, wednesday16, thursday16, friday16, cbstufac);
          sched.ShowSchedule("3:30 - 4:00", monday17, tuesday17, wednesday17, thursday17, friday17, cbstufac);

            

        }

        private void cbstufac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show the student name first in ComboBox.
            cbstudent.Items.Clear();
            sched.showStudent(cbstudent, cbstufac);
        }
    }
}
