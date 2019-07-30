using System;
using System.Collections.Generic;
using System.Text;

namespace SquareRoot
{
    class InvalidNumberException : Exception
    {
        private const string message = "Invalid number";

        public InvalidNumberException()
            :base(message)
        {

        }
        public InvalidNumberException(string message)
            :base(message)
        {

        }

    }
}
