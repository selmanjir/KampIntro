﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void GetPrintouts()
        {
            throw new NotImplementedException();
        }
    }
}
