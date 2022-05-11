using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class LoginDAL : SqlConnect, ILogin
    {
        public LoginDAL()
        {
            Initialize();
        }

        public List<LoginDTO> GetUserByEmail(LoginDTO dto)
        {

            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = "SELECT Email, Password, Salt FROM Users WHERE Email = (@email)";
                cmd.Parameters.AddWithValue("@Email", dto.Email);

                using SqlDataReader rdr = cmd.ExecuteReader();

                List<LoginDTO> listone = new List<LoginDTO>();
                
                if (rdr.HasRows)
                {
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

        public bool LoginUserCheck(LoginDTO dto)
        {
            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = ("Select * from Users where Email = @Email");
                cmd.Parameters.AddWithValue("@Email", dto.Email);

                //reader om de row met matchend Email en password uit te lezen en te checken of het een user of een admin is.
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    CloseConnect();
                    return true;
                }
                else
                {
                    CloseConnect();
                    return false;
                }
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
