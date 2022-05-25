using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using InterfaceLayer;

namespace BusinessLayer
{
    public class UserContainer
    {
        IUserContainer IUserContainer;

        public UserContainer(IUserContainer dal)
        {
            IUserContainer = dal;
        }

        //methode om te checken of er al een account bestaat met email.
        public bool CheckUserExists(string email)
        {
            return IUserContainer.CheckUserExist(email);
        }

        //methode om een account met bijbehorende gegevens te verwijderen.
        public void UserRegister(User user)
        {
            UserDTO dto = user.ToDTO();
            IUserContainer.Register(dto);
        }

        //methode om een account met bijbehorende gegevens te verwijderen.
        public void DeleteOneAccount(User user)
        {
            UserDTO dto = user.ToDTO();
            IUserContainer.DeleteOne(dto);
        }

        public User GetUserById(int id)
        {
            return new User(IUserContainer.GetUserById(id));
        }

        public User GetUserByEmail(string email)
        {
            return new User(IUserContainer.GetUserByEmail(email));
        }

        //list aanmaken om alle accounts met bijbehorende gegevens op te halen.
        public List<User> GetAllUsers()
        {
            //list aanmaken en vullen.
            List<User> allusers = new List<User>();
            List<UserDTO> list = IUserContainer.GetAll();
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


        //hash password input and check.
        public bool VerifyPassword(string email, string userPass)
        {
            UserDTO user = IUserContainer.GetUserByEmail(email);
            var salt = Convert.FromBase64String(user.Salt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(userPass, salt, 10000);

            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == user.Password;
        }
    }
}
