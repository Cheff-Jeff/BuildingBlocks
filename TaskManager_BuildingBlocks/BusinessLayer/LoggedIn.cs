﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public static class LoggedIn
    {
        private static string _email = "";

        public static string User
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
