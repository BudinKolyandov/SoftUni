using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const int PowerMotorcycleCC = 450;
        private const int MinHP = 70;
        private const int MaxHP = 100;
        private int horsePower;

        public PowerMotorcycle(string model, int horsePower) 
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
