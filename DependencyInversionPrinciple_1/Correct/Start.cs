using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_1.Correct
{
    class Start
    {
        public static void StartApplication()
        {
            Console.WriteLine("Correct");
            Console.WriteLine();

            Customer customer1 = new Customer(new ConsoleLogger());
            customer1.Add();

            Console.WriteLine();

            Customer customer2 = new Customer(new FileLogger());
            customer2.Add();

            Console.WriteLine();
            Console.WriteLine("This is the right way because now depending on configuration settings different logger classes will used at given moment.");
            Console.WriteLine();
            Console.WriteLine("Now it’s the responsibility of the client who is consuming the customer object to decide which Logger class to inject.");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
