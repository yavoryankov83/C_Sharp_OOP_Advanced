using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            //var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(2);

            //var width = int.Parse(Console.ReadLine());
            //var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(2, 5);

            circle.Draw();
            rect.Draw();
        }
    }
}
