using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class SiteException : Exception
    {
        private const string excMessage = "Invalid URL!";

        public SiteException()
            :base(excMessage)
        {

        }

        public SiteException(string message)
            :base(message)
        {

        }

    }
}
