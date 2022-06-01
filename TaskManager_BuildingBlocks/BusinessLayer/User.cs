using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class User
    {
        public int UserId { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool IsAdmin { get; set; }

        IUser IUser;

        public User(IUser dal)
        {
            IUser = dal;
        }
        public User()
        {

        }

        public User(int userId)
        {
            this.UserId = userId;
        }

        public User(string email)
        {
            this.Email = email;
        }

        public User(string salt, string Email, string Password, bool isAdmin)
        {
            this.Salt = salt;
            this.Email = Email;
            this.Password = Password;
            this.IsAdmin = isAdmin;
        }

        public User(string salt, int userId, string Email, string Password, bool isAdmin)
        {
            this.Salt = salt;
            this.UserId = userId;
            this.Email = Email;
            this.Password = Password;
            this.IsAdmin = isAdmin;
        }

        public User(UserDTO user)
        {
            this.UserId = user.UserId;
            this.Email = user.Email;
            this.Password = user.Password;
            this.Salt = user.Salt;
            this.IsAdmin = user.IsAdmin;
        }

        public UserDTO ToDTO()
        {
            UserDTO dto = new UserDTO(UserId, Email, Password, Salt, IsAdmin);
            return dto;
        }

        //methode om een account met bijbehorende gegevens aan te passen.
        public void EditOneUser(User user)
        {
            UserDTO dto = user.ToDTO();
            IUser.EditOne(dto);
        }


    }
}
