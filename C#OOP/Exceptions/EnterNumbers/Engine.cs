using System;
using System.Collections.Generic;
using System.Text;

namespace EnterNumbers
{
    class Engine
    {

        List<int> numbers;

        public Engine()
        {
            numbers = new List<int>() { int.MinValue };
        }

        public void Run()
        {
            try
            {
                int start = int.Parse(Console.ReadLine());
                int end = int.Parse(Console.ReadLine());

                ReadNumber(start, end);

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }

        }


        public void ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current > start && current > numbers[i] && current < end)
                {
                    numbers.Add(current);
                }
                else
                {
                    numbers.Clear();
                    numbers.Add(int.MinValue);
                    Console.WriteLine("Enter all the numbers again");
                    ReadNumber(start, end);
                }

            }
        }

    }
}
