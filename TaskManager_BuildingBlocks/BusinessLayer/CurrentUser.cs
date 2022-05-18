using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class CurrentUser
    {
        public bool userexists;

        //Opslaan wie er is ingelogd.
        public static string useremail;
        public static string userpassword;
        public static string usersalt;
        public static bool isadmin;

        public CurrentUser(User user)
        {
            useremail = user.Email;
            userpassword = user.Password;
            usersalt = user.Salt;
            isadmin = user.IsAdmin;
        }

    }
}
