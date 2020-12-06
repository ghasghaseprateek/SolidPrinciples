using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple_1.Correct
{
    class Start
    {
        public static void StartApplication()
        {
            Console.WriteLine("Correct");
            Console.WriteLine();

            ICustomer customer = new Customer();
            customer.Add();

            ICustomerRead customerRead = new CustomerRead();
            customerRead.GetUsernames();
            customerRead.Add();

            Console.WriteLine();
            Console.WriteLine("So the old clients will continue using the “ICustomer” interface while new client can use “ICustomerRead” interface");

            Console.WriteLine();
            Console.WriteLine("Interface-segregation principle states that no client should be forced to depend on methods it does not use");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
