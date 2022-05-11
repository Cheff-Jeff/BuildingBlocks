using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class User
    {
        public int UserId { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] salt { get; set; }
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

        public User(byte[]salt, string Email, string Password, bool isAdmin)
        {
            this.salt = salt;
            this.Email = Email;
            this.Password = Password;
            this.IsAdmin = isAdmin;
        }

        public User(byte[] salt, int userId, string Email, string Password, bool isAdmin)
        {
            this.salt = salt;
            this.UserId = userId;
            this.Email = Email;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
        }

        public User(UserDTO user)
        {
            this.UserId = user.UserId;
            this.Email = user.Email;
            this.Password = user.Password;
            this.salt = user.salt;
            this.IsAdmin = user.IsAdmin;
        }

        public UserDTO ToDTO()
        {
            UserDTO dto = new UserDTO();
            dto.UserId = UserId;
            dto.Email = Email;
            dto.Password = Password;
            dto.salt = salt;
            dto.IsAdmin = IsAdmin;

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
