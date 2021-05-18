using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Pratice_3
{
    class FiftyPercentDiscountWithTheCard : IDiscountManager
    {
        public void Calculate()
        {
            Console.WriteLine("Kartla yüzde 50 indirim tanımlandı.");
        }
    }
}
