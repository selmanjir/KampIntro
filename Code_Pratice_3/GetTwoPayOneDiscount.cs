using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Pratice_3
{
    class GetTwoPayOneDiscount : IDiscountManager
    {
        public void Calculate()
        {
            Console.WriteLine("2 al 1 öde indirimi tanımlandı. ");
        }
    }
}
