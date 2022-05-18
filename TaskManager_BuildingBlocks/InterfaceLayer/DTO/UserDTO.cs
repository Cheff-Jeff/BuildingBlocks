using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLayer
{
    public class UserDTO
    {
        public int UserId;
        public string Email;
        public string Password;
        public string Salt;
        public bool IsAdmin;

        public UserDTO(int userId, string email, string password, string salt, bool isAdmin)
        {
            UserId = userId;
            Email = email;
            Password = password;
            Salt = salt;
            IsAdmin = isAdmin;
        }
    }
}
