using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;

            Distance = 0;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double Consumption { get; set; }

        public double Distance { get; set; }
        
        public void Drive(double distance)
        {
            double requiredFuel = distance * Consumption;
            if (requiredFuel <= Fuel)
            {
                Distance += distance;
                Fuel -= requiredFuel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
