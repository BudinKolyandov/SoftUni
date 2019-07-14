using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string pizzaName = pizzaInput[1];

                string[] doughInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Dough dough = new Dough(doughInput[1], doughInput[2], int.Parse(doughInput[3]));

                Pizza pizza = new Pizza(pizzaName, dough);

                string command = string.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Topping topping = new Topping(commands[1], int.Parse(commands[2]));
                    pizza.AddATopping(topping);
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():f2} Calories.");

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


        }
    }
}
