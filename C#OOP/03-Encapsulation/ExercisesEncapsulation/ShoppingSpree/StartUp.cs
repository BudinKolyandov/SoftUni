using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            try
            {   
                string[] peopleInput = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                string[] productsInput = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (var person in peopleInput)
                {
                    string[] currentPerson = person.Split("=");
                    Person current = new Person(currentPerson[0],
                        double.Parse(currentPerson[1]));
                    people.Add(currentPerson[0], current);
                }
                foreach (var product in productsInput)
                {
                    string[] currentProduct = product.Split("=");
                    Product current = new Product(currentProduct[0],
                        double.Parse(currentProduct[1]));
                    products.Add(currentProduct[0], current);
                }
                string command = string.Empty;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] currentCommand = command.Split(" ");
                    string buyer = currentCommand[0];
                    string productToBuy = currentCommand[1];

                    if (people.ContainsKey(buyer) && products.ContainsKey(productToBuy))
                    {
                        double personsMoney = people[buyer].Money;
                        double productPrice = products[productToBuy].Money;

                        if (personsMoney - productPrice >= 0)
                        {
                            people[buyer].Money -= productPrice;
                            Console.WriteLine($"{buyer} bought {productToBuy}");
                            people[buyer].Bought(productToBuy);
                        }
                        else
                        {
                            Console.WriteLine($"{buyer} can't afford {productToBuy}");
                        }
                    }

                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            foreach (var person in people)
            {
                int productsBought = person.Value.Count;
                if (productsBought > 0)
                {
                    Console.WriteLine(person.Value.ToString().TrimEnd());
                }
                else
                {
                    Console.WriteLine($"{person.Key} - Nothing bought ");
                }
            }


        }
    }
}
