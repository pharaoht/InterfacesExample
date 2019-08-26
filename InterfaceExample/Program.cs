using System;

namespace InterfaceExample
{
    class Program
    {
        //README Go to ICustomer.cs >
        static void Main(string[] args)
        {
            Customer Cust = new Customer();
            Cust.Print1();
            Cust.Print2();
            Console.WriteLine("-----------------------");
            ICustomer Cust1 = new Customer();
            Cust1.Print1();
            Console.WriteLine("------------------------");
            ICustomer2 Cust2 = new Customer();
            Cust2.Print2();
        }
    }//We cannot create an instance of an interface, but an interface reference variable can point to a derived class object
}
