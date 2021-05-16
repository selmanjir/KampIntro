using System;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customers = new MyDictionary<int, string> ();
            customers.Add(1, "Selman");
            customers.Add(2, "Ardıl");
            customers.Add(3,"Ezgi");
            customers.Add(4,"Recep");
            Console.WriteLine("Toplam müşteri sayımız : " + customers.Count);
            
            
        }
    }
    class MyDictionary <Tkey,Tvalue>
    {
        Tkey[] itemKey;
        Tvalue[] itemValue;
        public MyDictionary()
        {
            itemKey = new Tkey[0];
            itemValue = new Tvalue[0];
        }
        public void Add(Tkey key,Tvalue value)
        {
            Tkey[] tempKey = itemKey;
            Tvalue[] tempValue = itemValue;
            itemKey = new Tkey[itemKey.Length + 1];
            itemValue = new Tvalue[itemValue.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                itemKey[i] = tempKey[i];
            }
            itemKey[itemKey.Length - 1] = key;
            for (int i = 0; i < tempValue.Length; i++)
            {
                itemValue[i] = tempValue[i];
            }
            itemValue[itemValue.Length - 1] = value;

        }
        public int Count
        {
            get { return itemKey.Length; }
        }


     
    }
}
