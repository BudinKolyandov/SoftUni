using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Topping
    {
        private string type;
        private int grams;
        
        public Topping(string type, int grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        public double TotalCaloriesGetter
            => TotalCalories(type, grams);

        public string Type
        {
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                else
                {
                    this.type = value;
                }
            }
        }
        public int Grams
        {
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range[1..50].");
                }
                else
                {
                    this.grams = value;
                }
            }
        }

        private double TotalCalories(string type, int grams)
        {
            double typeModifier = 0;
            switch (type.ToLower())
            {
                case "meat":
                    typeModifier = 1.2;
                    break;
                case "veggies":
                    typeModifier = 0.8;
                    break;
                case "cheese":
                    typeModifier = 1.1;
                    break;
                case "sauce":
                    typeModifier = 0.9;
                    break;
            }
            double totalCalories = (2 * grams) * typeModifier;
            return totalCalories;
        }


    }
}
