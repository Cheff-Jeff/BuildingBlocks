using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TaskManager_BuildingBlocks
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            //TODO Check Password with email
            if (passwordTxb.Text == "" || emailTxb.Text == "") return; //password or email is empty
            if (!Regex.IsMatch(emailTxb.Text, @"^[a-z\.\-]+@[a-z0-9]+\.[a-z]{2,3}$")) return; //email is not an email
         

            LoggedIn.User = emailTxb.Text; //set user as email
            this.Close();
        }

        private void skipLoginBtn_Click(object sender, EventArgs e)
        {
            LoggedIn.User = "timmothy"; //set user as timmothy to skip login
            this.Close();
        }
    }
}
