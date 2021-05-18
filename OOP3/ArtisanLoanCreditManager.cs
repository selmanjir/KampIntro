using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanLoanCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }

        public void GetPrintouts()
        {
            throw new NotImplementedException();
        }
    }
}
