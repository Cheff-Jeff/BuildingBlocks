using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class Login
    {
        public bool userexists;

        //Opslaan wie er is ingelogd.
        public static string useremail;
        public static string userpassword;
        public static string usersalt;

        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        ILogin ILogin;

        public Login(ILogin dal)
        {
            ILogin = dal;
        }
        public Login()
        {

        }
        public Login(string email)
        {
            this.Email = email;
        }

        public Login(string email, string password, string salt)
        {
            this.Email = email;
            this.Password = password;
            this.Salt = salt;
            usersalt = Salt;
            userpassword = Password;
            useremail = Email;
        }

        public LoginDTO ToDTO()
        {
            LoginDTO dto = new LoginDTO();
            dto.Email = Email;
            dto.Password = Password;
            dto.Salt = Salt;
            return dto;
        }

        //list aanmaken om alle accounts met bijbehorende gegevens op te halen.
        public List<Login> GetUserByEmail(Login login)
        {
            LoginDTO dto = login.ToDTO();

            //list aanmaken en vullen.
            List<Login> oneuser = new List<Login>();
            List<LoginDTO> list = ILogin.GetUserByEmail(dto);
            foreach (LoginDTO user in list)
            {
                Login newuser = new Login(user.Email, user.Password,user.Salt);
                oneuser.Add(newuser);
            }
            //userexists = dal.userexists;
            return oneuser;
        }

        //check if user exists in DB
        public bool LoginUserCheck(Login login)
        {
            LoginDTO dto = login.ToDTO();
            return ILogin.LoginUserCheck(dto);
        }

        //hash password input and check.
        public bool VerifyPassword(string password, string sSalt, string userPass)
        {
            var salt = Convert.FromBase64String(sSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 10000);

            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == userPass;
        }
    }
}
