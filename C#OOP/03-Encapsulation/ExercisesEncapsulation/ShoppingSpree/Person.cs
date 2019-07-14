using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;

        private double money;

        private List<string> products;
        public Person(string name, double money)
        {
            this.Name = name;

            this.Money = money;

            products = new List<string>();
        }

        public int Count
            => products.Count;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Exceptions.emptyName);
                }
                this.name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Exceptions.negativeMoney);
                }
                this.money = value;
            }
        }
        

        public void Bought(string product)
        {
            this.products.Add(product);
        }

        public override string ToString()
        {
            return $"{this.Name} - {string.Join(", ", products)}";            
        }

    }
}
