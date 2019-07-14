
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            toppings = new List<Topping>();
        }

        public int Count
            => toppings.Count;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException(Exceptions.invalidName);
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public void AddATopping(Topping topping)
        {
            if (toppings.Count + 1 > 10)
            {
                throw new ArgumentException(Exceptions.toppingsRange);
            }
            else
            {
                toppings.Add(topping);
            }
        }

        public double TotalCalories()
        {
            double totalCaloreis = 0;
            double doughCalories = dough.TotalCaloriesGetter;
            totalCaloreis += doughCalories;
            foreach (var topping in toppings)
            {
                totalCaloreis += topping.TotalCaloriesGetter;
            }
            return totalCaloreis;
        } 
    }
}
