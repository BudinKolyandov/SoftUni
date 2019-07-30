using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    class Engine
    {
        public Engine()
        {
        }

        public void Run()
        {
            string drverName = Console.ReadLine();

            Ferrari ferrari = new Ferrari(drverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.BreaksPushed()}" +
                $"/{ferrari.GasPushed()}/{ferrari.Driver}");

        }
    }
}
