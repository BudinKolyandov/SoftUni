using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tire
    {
        public Tire(double presure, int age)
        {
            Presure = presure;
            Age = age;
        }

        public double Presure { get; set; }

        public int Age { get; set; }
    }
}
