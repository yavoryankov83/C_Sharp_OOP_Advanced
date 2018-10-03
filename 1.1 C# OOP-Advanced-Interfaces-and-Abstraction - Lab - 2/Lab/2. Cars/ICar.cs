using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cars
{
    public interface ICar
    {
        string Model { get; }
        string Colour { get; }

        string Start();
        string Stop();
    }
}
