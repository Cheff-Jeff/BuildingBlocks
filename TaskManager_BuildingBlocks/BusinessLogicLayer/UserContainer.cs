using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class UserContainer
    {
        public bool check;
        //methode om te checken of er al een account bestaat met email.
        public void CheckUserExists(string email)
        {
            UserDAL dal = new UserDAL();
            dal.CheckUserExist(email);
            check = dal.check;
        }

        //methode om een account met bijbehorende gegevens te verwijderen.
        public void UserRegister(byte[] salt, string email, string password, bool isAdmin)
        {
            UserDAL dal = new UserDAL();
            dal.Register(salt, email, password, isAdmin);
        }

        //methode om een account met bijbehorende gegevens te verwijderen.
        public void DeleteOneAccount(int Id)
        {
            UserDAL dal = new UserDAL();
            dal.DeleteOne(Id);
        }

        //list aanmaken om alle accounts met bijbehorende gegevens op te halen.
        public List<User> GetAllUsers()
        {
            UserDAL dal = new UserDAL();
            //list aanmaken en vullen.
            List<User> allusers = new List<User>();
            List<UserDTO> list = dal.GetAll();
            foreach (UserDTO users in list)
            {
                User newuser = new User(users);
                allusers.Add(newuser);
            }
            return allusers;
        }

        public byte[] AddSalt()
        {
            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            return salt;
        }

        public string hash(string pass, byte[] salt)
        {
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(pass, salt, 10000);
            string hashed = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
            return hashed;
        }
    }
}
