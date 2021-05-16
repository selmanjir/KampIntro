using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1 , FirstName = "Selman Jir" , LastName = "CAN" , City = "Diyarbakır" };

            Customer customer2 = new Customer(2,"Ardıl","ELKAAN","Diyarbakır");

            Console.WriteLine(customer2.FirstName);
            
        }
       
    }
    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Console.WriteLine("Yapıcı blok çalıştı.");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
