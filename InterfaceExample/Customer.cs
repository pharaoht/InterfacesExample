using System;

namespace InterfaceExample
{
    class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Customer 1 name is John Smith");
        }

        public void Print2()
        {
            Console.WriteLine("Customer 2 name is Michael Smith");
        }
    }
    //README If a class or a struct inherits from an interface, it must provide implementation for all interface members.
    //Otherwise we get a compiler error
    //A class or a struct can inhierit from more than one interface at the sametime, but where as,
    //a class cannot inherit from more than one class at the same time
    //Goto ICustomer2
}