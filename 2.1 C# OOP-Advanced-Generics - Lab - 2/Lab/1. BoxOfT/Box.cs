﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BoxOfT
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove()
        {
            var last = data.LastOrDefault();
            this.data.RemoveAt(data.Count - 1);
            return last;
        }

        public int Count { get; }
    }
}
