﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //
            //

            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void GetPrintouts()
        {
            throw new NotImplementedException();
        }
    }
}
