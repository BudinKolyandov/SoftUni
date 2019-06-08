using System;
using System.Collections.Generic;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);

            
            Person person1 = new Person
            {
                Name = "Pesho",
                Age = 20
            };

            Person person2 = new Person();
            person2.Name = "Gosho";
            person2.Age = 18;

            Person person3 = new Person
            {
                Name = "Stamat"
            };
            person3.Age = 43;
        }
    }
}