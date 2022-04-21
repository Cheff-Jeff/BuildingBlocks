using System;
using System.Collections.Generic;
using System.Text;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class User
    {
        public int UserId { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] salt { get; set; }
        public bool IsAdmin { get; set; }

        public User()
        {

        }

        public User(UserDTO user)
        {
            this.UserId = user.UserId;
            this.Email = user.Email;
            this.Password = user.Password;
            this.salt = user.salt;
            this.IsAdmin = user.IsAdmin;
        }

        //methode om een account met bijbehorende gegevens aan te passen.
        public void EditOneUser(byte[] salt, int Id, string Email, string Password, bool IsAdmin)
        {
            UserDAL dal = new UserDAL();
            dal.EditOne(salt, Id, Email, Password, IsAdmin);
        }
    }
}
