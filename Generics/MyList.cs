﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    
    class MyList <T>
    {
        T[] items;
        
        public MyList ()
        {
            T[] items = new T[0];
        }

        public void Add (T item)
        {
            T[] tempArray = items;

            items = new T[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {

                tempArray[i] = items[i];

            }
        }

    }
}
