using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box<T>
    {
        private IList<T> data;

        private int Count { get; }

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var reminder = data.LastOrDefault();
            data.RemoveAt(data.Count - 1);
            return reminder;
        }
    }
}
