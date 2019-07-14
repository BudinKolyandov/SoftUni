using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;

        private double money;

        public Product(string name, double money)
        {
            this.Name = name;

            this.Money = money;
        }               

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


    }
}
