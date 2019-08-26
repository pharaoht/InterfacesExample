using System;

namespace InterfaceExample
{
    interface ICustomer
    {
        void Print1();
    }
}

//README We create interface using the interface keyword. Just like classes interfaces also contain properties, methods, delegates or events and no 
//implementations.
//It is a compile time error to provide implementations for any interface member. 
//Interfaces members are public by default, and they dont allow explicit access modifiers.
//interfaces cannot contain fields 
//Go to Customer.cs