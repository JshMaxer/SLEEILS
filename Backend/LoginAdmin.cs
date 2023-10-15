using Guna.UI2.WinForms;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.Backend
{
    //Backend
    public class LoginAdmin
    {
        public void Login(Guna2TextBox userid, Guna2TextBox pass)
        {

            if (userid.Text.Equals(ConsAcc.userID) && pass.Text.Equals(ConsAcc.pass))
            {
                MessageBox.Show("Log-in Succesful!");
            }
            else
            {
                MessageBox.Show("Log-in UnSuccesful!");
            }
        }
    }
}
