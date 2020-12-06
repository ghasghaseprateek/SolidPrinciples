using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple_1.Incorrect
{
    class Start
    {
        public static void StartApplication()
        {
            Console.WriteLine("Incorrect");
            Console.WriteLine();

            ICustomer customer = new Customer();
            customer.Add();
            customer.GetUsernames();

            Console.WriteLine();
            Console.WriteLine("This is not the right way because now by changing the current interface you are doing an awful thing, disturbing the 1000s of satisfied current client’s, even when they are not interested in the “Read” method. You are forcing them to use the “Read” method.");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
