using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple_1.Incorrect
{
    class Customer : ICustomer
    {
        public void Add()
        {
            Console.WriteLine("Adding customer to database");
        }

        // Forcing all clients to implement Get customers even though they don't need it
        // because we have modified the interface with declaration of get customers
        public List<string> GetUsernames()
        {
            Console.WriteLine("Fetching customers");
            return new List<string>();
        }
    }
}
