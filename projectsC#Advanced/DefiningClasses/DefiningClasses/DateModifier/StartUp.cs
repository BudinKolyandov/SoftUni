using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            string days = DateModifier.DifferenceBetweenDates(firstDate, secondDate).ToString();
            Console.WriteLine(days);

        }
    }
}
