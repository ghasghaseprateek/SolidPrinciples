using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple_1.Correct
{
    class Customer : ICustomer
    {
        public void Add()
        {
            Console.WriteLine("Adding customer to database");
        }
    }
}
