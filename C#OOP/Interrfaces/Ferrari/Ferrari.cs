using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    class Ferrari : IDrivable
    {
        private string driver;

        private string model;

        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }              

        public string Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public string Brakes { get; set; }
        public string Gas { get; set; }

        public string BreaksPushed()
        {
            return "Brakes!";
        }

        public string GasPushed()
        {
            return "Gas!";
        }
    }
}
