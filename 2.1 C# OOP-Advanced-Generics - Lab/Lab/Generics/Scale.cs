using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Scale<T>
        where T : IComparable<T>
    {
        public T GetHavier(T left, T right)
        {
            if (left.CompareTo(right) > 0)
            {
                return left;
            }
            else if (left.CompareTo(right) < 0)
            {
                return right;
            }
            else
            {
                return default (T);
            }
        }
    }
}
