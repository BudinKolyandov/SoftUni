using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vechicle
    {
        private double fuelQuantity;
        private double consumption;
        private string type;

        public Car(string type, double fuelQuantity, double fuelConcumption)
            : base(type, fuelQuantity, fuelConcumption)
        {
            this.Type = type;
            this.FuelQuantity = fuelQuantity;
            this.Consumption = fuelConcumption + 0.9;
        }
        
        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
        }

    }
}
