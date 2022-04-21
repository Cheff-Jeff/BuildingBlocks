using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public Login()
        {

        }

        public Login(LoginDTO login)
        {
            this.Email = login.Email;
            this.Password = login.Password;
            this.Salt = login.Salt;
        }

        public void GetUserById(string email)
        {
            LoginDAL dal = new LoginDAL();
            dal.GetUserByEmail(email);
        }
    }
}
