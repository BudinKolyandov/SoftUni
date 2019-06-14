﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            this.engine = engine;
            Weight = 0;
            Color = @"n/a";
        }

        public Car(string model, Engine engine, int weight)
            :this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            :this(model, engine, weight)
        {            
            Color = color;
        }

        public string Model {get; set;}

        public Engine engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }
    }
}