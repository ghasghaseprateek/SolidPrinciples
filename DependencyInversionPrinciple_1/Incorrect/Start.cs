using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_1.Incorrect
{
    public class Start
    {
        public static void StartApplication()
        {
            Console.WriteLine("Incorrect");
            Console.WriteLine();
            Customer customer = new Customer();
            customer.Add();
            Console.WriteLine();
            Console.WriteLine("This is not the right way because if a new logging is introduced say FileLogging then we will need to change the Customer class implementation.");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
