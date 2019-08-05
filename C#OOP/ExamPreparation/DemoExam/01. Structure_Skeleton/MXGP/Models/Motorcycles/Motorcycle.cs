using MXGP.Models.Motorcycles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public abstract class Motorcycle : IMotorcycle
    {
        private string model;
        private int horsePower;
        private double cubicCentimeters;

        protected Motorcycle(string model, int horsePower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model {model} cannot be less than 4 symbols.");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public abstract int HorsePower { get; protected set; }
        
        public double CubicCentimeters { get;}

        public double CalculateRacePoints(int laps)
        {
            return this.cubicCentimeters / this.HorsePower * laps;
        }
    }
}
