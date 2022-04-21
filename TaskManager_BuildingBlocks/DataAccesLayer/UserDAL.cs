using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class UserDAL : SqlConnect
    {
        public bool check;

        public UserDAL()
        {
            Initialize();
        }

        public void CheckUserExist(string email)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            check = false;

            cmd.CommandText = "SELECT * FROM Users WHERE Email = @Email";
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Dataset aanmaken en controlleren of de ingevulde email al bestaat.
            DataSet ds = new DataSet();
            da.Fill(ds);

            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                check = true;
                ds.Clear();
            }
            cmd.ExecuteNonQuery();

            CloseConnect();
        }

        public void Register(byte[] salt, string email, string password, bool isAdmin)
        {
            try
            {
                OpenConnect();

                cmd.CommandText = "INSERT INTO Users (Email, Password, Salt, IsAdmin) VALUES (@email, @pass, @salt, @admin)";
                string sSalt = Convert.ToBase64String(salt);
                byte admin = 0;

                if (isAdmin) { admin = 1; }

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
                throw;
            }
        }

        //methode om account met bijbehorende gegevens te bewerken.
        public void EditOne(byte[] salt, int Id, string Email, string Password, bool isAdmin)
        {
            OpenConnect();

            cmd.Parameters.Clear();

            string sSalt = Convert.ToBase64String(salt);
            byte admin = 0;

            if (isAdmin) { admin = 1; }

            cmd.CommandText = "UPDATE Users SET Salt = @Salt, Email = @Email, Password = @Password, IsAdmin = @IsAdmin WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Salt", sSalt);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsAdmin", admin);

            cmd.ExecuteNonQuery();
        }

        //methode om account met bijbehorende gegevens te verwijderen.
        public void DeleteOne(int Id)
        {
            OpenConnect();

            cmd.CommandText = "DELETE FROM Users WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);

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
