﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions
{
    public class LoginFailedException:Exception
    {
        public LoginFailedException(string message):base(message)
        {

        }
    }
}
