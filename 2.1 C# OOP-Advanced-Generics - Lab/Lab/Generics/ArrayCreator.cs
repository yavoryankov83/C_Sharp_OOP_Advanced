﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int lenght, T item)
        {
            return new T[lenght];
        }
    }
}
