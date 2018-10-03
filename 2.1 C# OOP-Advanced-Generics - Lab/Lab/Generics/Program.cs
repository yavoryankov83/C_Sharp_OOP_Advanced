using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //first problem
            //Box<int> box = new Box<int>();
            //box.Add(1);
            //box.Add(2);
            //box.Add(3);
            //Console.WriteLine(box.Remove());
            //box.Add(4);
            //box.Add(5);
            //Console.WriteLine(box.Remove());

            //second problem
            //string[] strings = ArrayCreator.Create(5, "Pesho");
            //int[] integers = ArrayCreator.Create(10, 33);

            Scale<int> scale = new Scale<int>();
            Console.WriteLine(scale.GetHavier(8, 3));
        }
    }
}
