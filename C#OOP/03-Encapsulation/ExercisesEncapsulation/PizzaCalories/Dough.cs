using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int grams;

        public Dough(string flourType, string bakingTechnique, int grams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }

        public double TotalCaloriesGetter
            => TotalCalories(flourType, bakingTechnique, grams);

        public string FlourType
        {
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(Exceptions.invalidDough);
                }
                else
                {
                    this.flourType = value;
                }
            }
        }

        public string BakingTechnique
        {
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" 
                    && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(Exceptions.invalidDough);
                }
                else
                {
                    this.bakingTechnique = value;
                }
            }
        }

        public int Grams
        {
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(Exceptions.invalidWeight);
                }
                else
                {
                    this.grams = value;
                }
            }
        }

        private double TotalCalories(string flourType, 
            string bakingTechnique, int grams)
        {
            double typeModifier = 0;
            double techniqueModifier = 0;
            switch (flourType.ToLower())
            {
                case "white":
                    typeModifier = 1.5;
                    break;
                case "wholegrain":
                    typeModifier = 1.0;
                    break;
            }
            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    techniqueModifier = 0.9;
                    break;
                case "chewy":
                    techniqueModifier = 1.1;
                    break;
                case "homemade":
                    techniqueModifier = 1.0;
                    break;
            }

            double totalCalories = (2 * grams) * typeModifier * techniqueModifier;
            return totalCalories;

        }
    }
}
