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
using System.Security.Cryptography;
using System.Data.SqlClient;
using BusinessLayer;
using DataLayer;

namespace ViewLayer
{
    public partial class LoginForm : Form
    {
        Login login;

        public LoginForm()
        {
            InitializeComponent();
            login = new Login(new LoginDAL());

            passwordTxb.ForeColor = Color.Orange;
            passwordTxb.UseSystemPasswordChar = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //TODO
            //  Make inputs red if not correct
            if (passwordTxb.Text == "" || emailTxb.Text == "") return; //password or email is empty

            if (!Regex.IsMatch(emailTxb.Text.ToLower(), @"^[a-z0-9\.\-]+@[a-z0-9]+\.[a-z]{2,3}$")) 
            {
                // email is not an email
                MessageBox.Show("Email fout"); return; 
            }

            Login log = new Login(emailTxb.Text);
            if(login.LoginUserCheck(log) == false)
            {
                MessageBox.Show("Incorrect Email or Password"); return;
            }

            else
            {
                Login log1 = new Login(emailTxb.Text);
                login.GetUserByEmail(log1);
                bool validUser = login.VerifyPassword(passwordTxb.Text, Login.usersalt, Login.userpassword);
                if (!validUser) return;
                LoggedIn.User = Login.useremail;
                this.Close();
            }
            
        }

        private void skipLoginBtn_Click(object sender, EventArgs e)
        {
            LoggedIn.User = "timmothy"; //set user as timmothy to skip login
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpassword.Checked == true)
            {
                passwordTxb.ForeColor = Color.Orange;
                passwordTxb.UseSystemPasswordChar = false;
            }

            else
            {
                passwordTxb.ForeColor = Color.Orange;
                passwordTxb.UseSystemPasswordChar = true;
            }
        }
    }
}

