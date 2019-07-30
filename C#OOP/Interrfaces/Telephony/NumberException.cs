using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class NumberException : Exception
    {

        private const string excMessage = "Invalid number!";

        public NumberException()
            :base(excMessage)
        {

        }

        public NumberException(string message)
            :base(message)
        {

        }

    }
}
