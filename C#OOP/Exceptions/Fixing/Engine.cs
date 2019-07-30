using System;
using System.Collections.Generic;
using System.Text;

namespace Fixing
{
    class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            try
            {
                string[] weekdays = new string[5];
                weekdays[0] = "Sunday";
                weekdays[1] = "Monnday";
                weekdays[2] = "Tuesday";
                weekdays[3] = "Wednesday";
                weekdays[4] = "Thursday";

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(weekdays[i].ToString());
                }
                Console.ReadLine();

            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine("Index of the array is out of range!", ioore);
            }

        }
    }
}
