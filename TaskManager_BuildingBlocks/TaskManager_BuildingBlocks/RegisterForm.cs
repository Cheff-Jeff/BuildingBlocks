using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager_BuildingBlocks
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            CreateUser();
            this.Close();
        }

        private void CreateUser()
        {
            byte[] salt = AddSalt();

            string email = emailTxb.Text;
            string password = hash(passTxb.Text, salt);
            string rePass = rePassTxb.Text;
            bool isAdmin = isAdminCbx.Checked;

            if (passTxb.Text != rePass && !Regex.IsMatch(emailTxb.Text, @"^[a-z\.\-]+@[a-z0-9]+\.[a-z]{2,3}$")) 
            { MessageBox.Show("Passwords do not match"); return; }
            else { Register(salt, email, password, isAdmin); }
            /// TODO 
            ///     Make inputs red if not correct
        }

        private void Register(byte[] salt, string email, string password, bool isAdmin)
        {
            if (CheckUserExist(email))
            { MessageBox.Show("This user already exists."); }
            else
            {
                DbConnection conn = new DbConnection();
                string query = "INSERT INTO Users (Email, Password, Salt, IsAdmin) VALUES (@email, @pass, @salt, @admin)";
                SqlCommand cmd;

                try
                {
                    string sSalt = Convert.ToBase64String(salt);
                    byte admin = 0;

                    if (isAdmin) { admin = 1; }

                    DbConnection.OpenDbConnenction();
                    cmd = new SqlCommand(query, DbConnection.cnn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@salt", sSalt);
                    cmd.Parameters.AddWithValue("@admin", admin);

                    cmd.ExecuteNonQuery();
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

        private bool CheckUserExist(string email)
        {
            DbConnection conn = new DbConnection();
            string query = "SELECT Email FROM Users WHERE Email = (@email)";
            SqlCommand cmd;

            try
            {
                DbConnection.OpenDbConnenction();
                cmd = new SqlCommand(query, DbConnection.cnn);
                cmd.Parameters.AddWithValue("@email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return true;
                    }
                }

                return false;
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

        private string hash(string pass, byte[] salt)
        {
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(pass, salt, 10000);           
            string hashed = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
            return hashed;
        }

        private byte[] AddSalt()
        {
            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            return salt;
        }
    }
}
