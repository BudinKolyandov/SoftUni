using System;
using System.Collections.Generic;
using System.Text;

namespace SquareRoot
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
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new InvalidNumberException();
                }
                Console.WriteLine(Math.Sqrt(input));

            }
            catch(FormatException fe)
            {
                Console.WriteLine("Invalid number", fe);
            }
            catch (InvalidNumberException ine)
            {
                Console.WriteLine(ine.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            



        }
    }
}
