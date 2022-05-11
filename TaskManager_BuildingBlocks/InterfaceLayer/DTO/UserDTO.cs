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
        public byte[] salt;
        public bool IsAdmin;
    }
}
