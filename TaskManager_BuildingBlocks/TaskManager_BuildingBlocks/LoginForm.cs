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
            Console.WriteLine("Tets1");
            //TODO
            //  Make inputs red if not correct
            if (passwordTxb.Text == "" || emailTxb.Text == "") return; //password or email is empty
            if (!Regex.IsMatch(emailTxb.Text.ToLower(), @"^[a-z0-9\.\-]+@[a-z0-9]+\.[a-z]{2,3}$")) { MessageBox.Show("Email fout"); return; }; //email is not an email
            
            Console.WriteLine("Tets");
            User user = GetUserByEmail(emailTxb.Text);
            bool validUser = VerifyPassword(passwordTxb.Text, user.Salt, user.Password);
            Console.WriteLine(validUser);

            if (!validUser) return;
            LoggedIn.User = user.Email;
            this.Close();
        }

        private void skipLoginBtn_Click(object sender, EventArgs e)
        {
            LoggedIn.User = "timmothy"; //set user as timmothy to skip login
            this.Close();
        }

        //hash password input and check.
        private bool VerifyPassword(string password, string sSalt, string userPass)
        {
            Console.WriteLine("in");
            var salt = Convert.FromBase64String(sSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 10000);
            
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == userPass;
        }

        /*
         * TOTO
         * return if user not found.
         */
        private User GetUserByEmail(string email)
        {
            Console.WriteLine("in2");

            DbConnection conn = new DbConnection();
            string query = "SELECT Email, Password, Salt FROM Users WHERE Email = (@email)";
            SqlCommand cmd;
            User user;

            try
            {
                DbConnection.OpenDbConnenction();
                cmd = new SqlCommand(query, DbConnection.cnn);
                cmd.Parameters.AddWithValue("@email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return user = new User(reader["Email"].ToString(), reader["Password"].ToString(), reader["Salt"].ToString());
                    }
                }

                return new User("" ,"", "");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
                throw;
            }
        }
    }
}
