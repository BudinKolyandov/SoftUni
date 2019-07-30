using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Engine
    {
        private Smartphone smartphone;
        public Engine()
        {
            this.smartphone = new Smartphone();
        }

        public void Run()
        {
            string[] numbers = Console.ReadLine()
                .Split(" ").ToArray();
            string[] sites = Console.ReadLine()
                .Split(" ").ToArray();

            try
            {
                foreach (var number in numbers)
                {
                    Console.WriteLine(this.smartphone.Call(number));
                }
            }
            catch (NumberException ne)
            {
                Console.WriteLine(ne.Message);
            }

            try
            {
                foreach (var site in sites)
                {
                    Console.WriteLine(this.smartphone.Browse(site));
                }
            }
            catch (SiteException se)
            {
                Console.WriteLine(se.Message);
            }


        }
    }
}
