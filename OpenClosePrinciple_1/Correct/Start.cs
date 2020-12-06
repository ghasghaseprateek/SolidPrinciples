using OpenClosePrinciple_1.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple_1.Correct
{
    class Start
    {
        public static void StartApplication(int totalSales, CustomerType customerType)
        {
            Console.WriteLine("Correct");
            Console.WriteLine();
            ICustomer customer = null;
            switch (customerType)
            {
                case CustomerType.Gold:
                    customer = new GoldCustomer();
                    break;
                case CustomerType.Silver:
                    customer = new SilverCustomer();
                    break;
                default:
                    break;
            }
            customer.GetDiscount(totalSales);
            Console.WriteLine();
            Console.WriteLine("This is the right way because if a new customer type is added we are not changing the implementation of any of the current classes instead we will inherit from ICustomer and extend the functionality.");
            Console.WriteLine();
            Console.WriteLine("OCP: Open for extension and closed for modification");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
