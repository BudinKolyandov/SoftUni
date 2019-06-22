using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthyHeaven
{
    class Salad
    {
        List<Vegetable> products;
        public string Name { get; set; }

        public Salad(string name)
        {
            this.Name = name;

            products = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {
            int sum = 0;

            foreach (var item in products)
            {
                sum += item.Calories;
            }

            return sum;
        }

        public int GetProductCount()
        {
            return products.Count();
        }

        public void Add(Vegetable product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");
            foreach (var product in products)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
