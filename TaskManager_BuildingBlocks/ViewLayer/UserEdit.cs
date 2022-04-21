using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace ViewLayer
{
    public partial class UserEdit : Form
    {
        UserContainer userContainer;
        User user;

        public UserEdit()
        {
            InitializeComponent();
            user = new User();
            userContainer = new UserContainer();

            tbEmail.Text = UserManagerForm.Email;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbEmail.Text = "";
            tbPassword.Text = "";
            tbRetypepassword.Text = "";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text == "" || tbPassword.Text == "" || tbRetypepassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Edit user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var res = MessageBox.Show("Are you sure you want to edit user", "Edit user", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    byte[] salt = userContainer.AddSalt();

                    string Email = tbEmail.Text.ToLower();
                    var Password = userContainer.hash(tbPassword.Text, salt);
                    string rePass = tbRetypepassword.Text;
                    bool isAdmin = rbIsadmin.Checked;

                    if (tbPassword.Text != rePass)
                    { 
                        MessageBox.Show("Passwords do not match"); 
                    }

                    else if (!Regex.IsMatch(tbEmail.Text.ToLower(), @"^[a-z0-9\.\-]+@[a-z0-9]+\.[a-z]{2,3}$")) 
                    {
                        //email is not an email
                        MessageBox.Show("Email is not an Email adress");
                    }

                    else
                    {
                        user.EditOneUser(salt, UserManagerForm.Id, Email, Password, isAdmin);
                        MessageBox.Show(string.Format("User has been edited new userinfo: " + Environment.NewLine + "Email: {0}" + Environment.NewLine + "Password: ******" + Environment.NewLine + " IsAdmin: {1}", Email, isAdmin, "Edit user", MessageBoxButtons.OK, MessageBoxIcon.Information));
                        this.Hide();
                    }
                }
            } 
        }

        private void btSaveCreate_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "" || tbRetypepassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Create user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var res = MessageBox.Show("Are you sure you want to create user", "Create user", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    byte[] salt = userContainer.AddSalt();

                    string Email = tbEmail.Text.ToLower();
                    var Password = userContainer.hash(tbPassword.Text, salt);
                    string rePass = tbRetypepassword.Text;
                    bool isAdmin = rbIsadmin.Checked;

                    if (tbPassword.Text != rePass)
                    {
                        MessageBox.Show("Passwords do not match");
                    }

                    else if (!Regex.IsMatch(tbEmail.Text.ToLower(), @"^[a-z0-9\.\-]+@[a-z0-9]+\.[a-z]{2,3}$"))
                    {
                        //email is not an email
                        MessageBox.Show("Email is not an valid Email adress");
                    }

                    else
                    {
                        userContainer.CheckUserExists(Email);
                        if(userContainer.check == true)
                        {
                            MessageBox.Show("User (Email) already exists", "Create user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if(userContainer.check == false)
                        {
                            userContainer.UserRegister(salt, Email, Password, isAdmin);

                            MessageBox.Show(string.Format("User has been created userinfo: " + Environment.NewLine + "Email: {0}" + Environment.NewLine + "Password: ******" + Environment.NewLine + " IsAdmin: {1}", Email, isAdmin, "Create user", MessageBoxButtons.OK, MessageBoxIcon.Information));
                            this.Hide();
                        }
                        
                    }
                }
            }
        }
    }
}
