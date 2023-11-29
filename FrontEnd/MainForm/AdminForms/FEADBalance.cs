using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SMARTLEARN.FrontEnd.AdminForms
{
    public partial class FEADBalance : Form
    {
        Database.DBBalance balance = new Database.DBBalance();
        public FEADBalance()
        {
            InitializeComponent();
        }

        private void FEADBalance_Load(object sender, EventArgs e)
        {
            
            balance.loaddgv(DGVStudentlist);
        }

        private void DGVStudentlist_SelectionChanged(object sender, EventArgs e)
        {
            balance.selection(DGVStudentlist, lblname);
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            balance.save(txtfirstsemester, txtsecondsemester);
        }

        private void TimerDisable_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfirstsemester.Text) && string.IsNullOrEmpty(txtsecondsemester.Text))
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }

        private void txtfirstsemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
