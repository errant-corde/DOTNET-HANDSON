﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm3
{
    class NegativeNumberException : ApplicationException
    {

        public override string Message
        {
            get
            {
                return "Attempted to input negative number";
            }
        }
    }
}
