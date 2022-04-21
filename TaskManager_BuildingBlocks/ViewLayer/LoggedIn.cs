using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace ViewLayer
{
    static class LoggedIn
    {
        private static string _email = "";

        public static string User
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
