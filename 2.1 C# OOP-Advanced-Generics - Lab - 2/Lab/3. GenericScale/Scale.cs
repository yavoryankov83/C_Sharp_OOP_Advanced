using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericScale
{
    public class Scale<T>
        where T : IComparable<T>
    {
        public string GetHeavier(T elementLeft, T elementRight)
        {
            if (elementLeft.CompareTo(elementRight) == 0)
            {
                return null;
            }
        }
    }
}
