using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_BuildingBlocks
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public User(string email, string password, string salt)
        {
            Email = email;
            Password = password;
            Salt = salt;
        }
    }
}
