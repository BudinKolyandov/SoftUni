﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
    class Vegetable
    {
        public string Name { get; set; }

        public int Calories { get; set; }

        public Vegetable(string name, int calories)
        {
            this.Name = name;
            this.Calories = calories;
        }

        public override string ToString()
        {
            return $" - {Name} have {Calories} calories";
        }
    }
}
