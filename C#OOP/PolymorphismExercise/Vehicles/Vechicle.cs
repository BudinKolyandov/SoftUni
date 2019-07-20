using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Vechicle
    {
        private double fuelQuantity;
        private double consumption;
        private string type;
        public Vechicle(string type, double fuelQuantity, double fuelConcumption)
        {
            this.Type = type;
            this.FuelQuantity = fuelQuantity;
            this.Consumption = fuelConcumption;
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                fuelQuantity = value;
            }
        }               

        public double Consumption
        {
            get
            {
                return consumption;
            }
            set
            {
                consumption = value;
            }
        }

        public void Drive(double distance)
        {
            if ((distance * consumption) <= fuelQuantity)
            {
                Console.WriteLine($"{this.type} travelled {distance} km");
                fuelQuantity -= distance * consumption;
            }
            else
            {
                Console.WriteLine($"{this.type} needs refueling");
            }
        }
        public virtual void Refuel(double fuel)
        {
            fuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.type}: {this.fuelQuantity:f2}";
        }
    }
}
