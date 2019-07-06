using System.Collections.Generic;

namespace P01_RawData
{
    class Car
    {
        public Car(string model,
                   Engine engine,
                   Cargo cargo,
                   params Tire[] tires
                   )
        {
            this.Model = model;
            this.EngineSpeed = engine.EngineSpeed;
            this.EnginePower = engine.EnginePower;
            this.CargoWeight = cargo.CargoWeight;
            this.CargoType = cargo.CargoType;
            this.tires = tires;
        }
        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
        public Tire[] tires { get; set; }
    }
}
