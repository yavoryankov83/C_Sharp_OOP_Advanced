using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Rectangle : IDrawable
    {
        private int width;
        private int height;
        
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }


        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
