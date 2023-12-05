﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.Excepions
{
    public class UserException : Exception
    {
        public UserException() { }
        public UserException(string message) : base(message)
        {

        }
        public UserException(string message, Exception innerException) : base(message, innerException) { }

    }
}
