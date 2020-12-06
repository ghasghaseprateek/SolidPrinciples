using OpenClosePrinciple_1.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple_1.Incorrect
{
    class Start
    {
        public static void StartApplication(int totalSales, CustomerType customerType)
        {
            Console.WriteLine("Incorrect");
            Console.WriteLine();
            Customer incorrect_Customer = new Customer() { Type = customerType };
            incorrect_Customer.GetDiscount(totalSales);
            Console.WriteLine();
            Console.WriteLine("This is not the right way because if a new customer type is added we are changing the implementation of the Customer class by adding a new if statement.");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
