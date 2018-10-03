using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
