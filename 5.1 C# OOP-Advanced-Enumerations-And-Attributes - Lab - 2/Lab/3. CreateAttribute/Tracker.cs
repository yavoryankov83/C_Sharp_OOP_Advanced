using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CreateAttribute
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var startUp = typeof(StartUp);
            var method = startUp.GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

            foreach (var info in method)
            {
                if (info.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
                {
                    foreach (SoftUniAttribute attr in info.GetCustomAttributes(false))
                    {
                        Console.WriteLine($"{info.Name} is Written by {attr.Name}");
                    }
                }
            }
        }
    }
}
