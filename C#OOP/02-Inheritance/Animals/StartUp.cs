using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            List<Animal> animals = new List<Animal>();

            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] properties = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                bool validAge;
                switch (input)
                {                    
                    case "Dog":                        
                        string dogName = properties[0];
                        validAge = int.TryParse(properties[1], out int dogAge);
                        string dogGender = properties[2];
                        Dog dog = new Dog(dogName, dogAge, dogGender);
                        animals.Add(dog);
                        break;
                    case "Cat":                        
                        string catName = properties[0];
                        validAge = int.TryParse(properties[1], out int catAge);
                        string catGender = properties[2];
                        Cat cat = new Cat(catName, catAge, catGender);
                        animals.Add(cat);
                        break;
                    case "Frog":
                        string frogName = properties[0];
                        validAge = int.TryParse(properties[1], out int frogAge);
                        string frogGender = properties[2];
                        Frog frog = new Frog(frogName, frogAge, frogGender);
                        animals.Add(frog);
                        break;
                    case "Kitten":
                        string kittenName = properties[0];
                        validAge = int.TryParse(properties[1], out int kittenAge);
                        string kittenGender = properties[2];
                        Kitten kitten = new Kitten(kittenName, kittenAge, kittenGender);
                        animals.Add(kitten);
                        break;
                    case "Tomcat":
                        string tomcatName = properties[0];
                        validAge = int.TryParse(properties[1], out int tomcatAge);
                        string tomcatGender = properties[2];
                        Tomcat tomcat = new Tomcat(tomcatName, tomcatAge, tomcatGender);
                        animals.Add(tomcat);
                        break;
                    default:
                        break;
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }

        }
    }
}
