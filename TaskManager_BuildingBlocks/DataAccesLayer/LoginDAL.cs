using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccesLayer
{
    public class LoginDAL : SqlConnect
    {
        public bool userexists = false;
        public LoginDAL()
        {
            Initialize();
        }

        public List<LoginDTO> GetUserByEmail(string email)
        {

            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = "SELECT Email, Password, Salt FROM Users WHERE Email = (@email)";
                cmd.Parameters.AddWithValue("@Email", email);

                using SqlDataReader rdr = cmd.ExecuteReader();

                List<LoginDTO> listone = new List<LoginDTO>();
                
                if (rdr.HasRows)
                {
                    userexists = true;

                    rdr.Read();
                    LoginDTO user = new LoginDTO()
                    {
                        Email = (rdr["Email"].ToString()),
                        Password = (rdr["Password"].ToString()),
                        Salt = (rdr["Salt"].ToString()),
                    };
                    listone.Add(user);
                }
                CloseConnect();
                return listone;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                throw;
            }
        }
    }
}
