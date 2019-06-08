using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {                
                string [] person = Console.ReadLine().Split();
                string name = person[0];
                int age = int.Parse(person[1]);

                Person familyMember = new Person(name, age);

                family.AddMember(familyMember);
                
            }
            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
