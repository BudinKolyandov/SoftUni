using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const int PowerMotorcycleCC = 125;
        private const int MinHP = 50;
        private const int MaxHP = 69;
        private int horsePower;

        public SpeedMotorcycle(string model, int horsePower) 
            : base(model, horsePower, PowerMotorcycleCC)
        {
        }

        public override int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            protected set
            {
                if (value < MinHP || value > MaxHP)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
            }
        }
    }
}
