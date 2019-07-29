using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string fullName, int Age)
        {
            this.FullName = fullName;
            this.Age = Age;
        }
        [MyRequired]
        public string FullName { get; set; }
        [MyRange(12, 90)]
        public int Age { get; set; }
    }
}
