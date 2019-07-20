using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vechicle
    {
        private double fuelQuantity;
        private double consumption;
        private string type;
        public Truck(string type, double fuelQuantity, double fuelConcumption) 
            : base(type, fuelQuantity, fuelConcumption)
        {
            this.Type = type;
            this.FuelQuantity = fuelQuantity;
            this.Consumption = fuelConcumption + 1.6;
        }

        public override void Refuel(double fuel)
        {
            this.FuelQuantity += (fuel * 0.95);
        }

    }
}
