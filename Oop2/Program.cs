using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Selman Jir CAN

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirsName = "Selman Jir";
            customer1.LastName = "CAN";
            customer1.TcNo = "12345678910";

            // Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer1.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            
        }
    }
}
