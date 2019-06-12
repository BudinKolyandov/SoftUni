using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string Model { get; set; }

        public Engine Engine;

        public Cargo Cargo;

        public List<Tire> Tires;


    }
}
