using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList2<string> sehirler2 = new MyList2<string> ();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList2 <T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList2()
        {
            _array = new T[0];
        }
        
        public void Add(T item)
        {
            _tempArray = _array;

            _array = new T[_array.Length + 1];
            
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = _array[i];
            }
            _array[_array.Length - 1] = item; 
        }
        
        public int Count
        {
            get { return _array.Length; }
            
        }


    }
}
