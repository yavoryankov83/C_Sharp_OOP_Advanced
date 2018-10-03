using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cars
{
    class Seat : ICar
    {
        public string Model { get; private set; }

        public string Colour { get; private set; }

        public Seat(string model, string colour)
        {
            this.Model = model;
            this.Colour = colour;
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
            return $"{this.Colour} Seat {this.Model}";
        }
    }
}
