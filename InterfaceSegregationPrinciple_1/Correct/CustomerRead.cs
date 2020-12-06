using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple_1.Correct
{
    class CustomerRead : ICustomer, ICustomerRead
    {
        public void Add()
        {
            Console.WriteLine("Adding customer to database");
        }

        public List<string> GetUsernames()
        {
            Console.WriteLine("Fetching customers");
            return new List<string>();
        }
    }
}
