using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserDAL : SqlConnect, IUser, IUserContainer
    {
        public bool check;

        public UserDAL()
        {
            Initialize();
        }

        public bool CheckUserExist(UserDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT * FROM Users WHERE Email = @Email";
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Dataset aanmaken en controlleren of de ingevulde email al bestaat.
            DataSet ds = new DataSet();
            da.Fill(ds);

            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                ds.Clear();
                
                cmd.ExecuteNonQuery();

                CloseConnect();
                return true;
            }
            else
            {
                CloseConnect();
                return false;
            }
            
        }

        public void Register(UserDTO dto)
        {
            try
            {
                OpenConnect();

                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO Users (Email, Password, Salt, IsAdmin) VALUES (@email, @pass, @salt, @admin)";
                string sSalt = Convert.ToBase64String(dto.salt);
                byte admin = 0;

                if (dto.IsAdmin) { admin = 1; }
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@email", dto.Email);
                cmd.Parameters.AddWithValue("@pass", dto.Password);
                cmd.Parameters.AddWithValue("@salt", sSalt);
                cmd.Parameters.AddWithValue("@admin", admin);

                cmd.ExecuteNonQuery();

                CloseConnect();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                throw;
            }
        }

        //methode om account met bijbehorende gegevens te bewerken.
        public void EditOne(UserDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            string sSalt = Convert.ToBase64String(dto.salt);
            byte admin = 0;

            if (dto.IsAdmin) { admin = 1; }

            cmd.CommandText = "UPDATE Users SET Salt = @Salt, Email = @Email, Password = @Password, IsAdmin = @IsAdmin WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Salt", sSalt);
            cmd.Parameters.AddWithValue("@Id", dto.UserId);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Password", dto.Password);
            cmd.Parameters.AddWithValue("@IsAdmin", admin);

            cmd.ExecuteNonQuery();

            CloseConnect();
        }

        //methode om account met bijbehorende gegevens te verwijderen.
        public void DeleteOne(UserDTO dto)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            cmd.CommandText = "DELETE FROM Users WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", dto.UserId);

            cmd.ExecuteNonQuery();

            CloseConnect();
        }

        //list aanmaken die alle accounts met bijbehorende gegevens ophaalt.
        public List<UserDTO> GetAll()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Users";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<UserDTO> listall = new List<UserDTO>();

            while (rdr.Read())
            {
                UserDTO users = new UserDTO()
                {
                    UserId = Int32.Parse(rdr["Id"].ToString()),
                    Email = (rdr["Email"].ToString()),
                    Password = (rdr["Password"].ToString()),
                    IsAdmin = bool.Parse(rdr["IsAdmin"].ToString()),
                };
                listall.Add(users);
            }
            CloseConnect();

            return listall;
        }
    }
}
