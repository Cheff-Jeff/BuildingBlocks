using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccesLayer
{
    public class LoginDAL : SqlConnect
    {

        public void GetUserByEmail(string email)
        {

            try
            {
                OpenConnect();

                cmd.CommandText = "SELECT Email, Password, Salt FROM Users WHERE Email = (@email)";
                cmd.Parameters.AddWithValue("@email", email);

                List<LoginDTO> listall = new List<LoginDTO>();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        //Ema = rdr["Id"].ToString();
                        //p = rdr["Firstname"].ToString();
                        //userlastname = rdr["Lastname"].ToString();
                    }
                }

                //return new User("", "", "");
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
