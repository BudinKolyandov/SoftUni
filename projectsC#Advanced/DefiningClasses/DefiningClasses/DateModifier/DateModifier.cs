using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
        public static double  DifferenceBetweenDates(string dateFirst, string dateSecond)
        {
            DateTime firstDate = DateTime.ParseExact(dateFirst, "yyyy MM dd", CultureInfo.CurrentCulture);
            DateTime secondDate = DateTime.ParseExact(dateSecond, "yyyy MM dd", CultureInfo.CurrentCulture);

            if (secondDate < firstDate)
            {
                return DifferenceBetweenDates(dateSecond, dateFirst);
            }

            return (secondDate - firstDate).Days;
            
        }


    }
}
