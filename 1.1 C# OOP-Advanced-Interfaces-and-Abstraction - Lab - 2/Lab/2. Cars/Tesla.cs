using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cars
{
    class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }

        public string Colour { get; private set; }

        public int Battery { get; private set; }

        public Tesla(string model, string colour, int battery)
        {
            this.Model = model;
            this.Colour = colour;
            this.Battery = battery;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Colour} Tesla {this.Model} with {this.Battery} Batteries";
        }
    }
}
