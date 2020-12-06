using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple_1.Correct
{
    class Start
    {
        public static void StartApplication()
        {
            Console.WriteLine("Correct");
            Console.WriteLine();
            Customer correct_Customer = new Customer(new FileLogger());
            correct_Customer.Add();
            Console.WriteLine();
            Console.WriteLine("This is the right way because the logic for logging is moved to a new class(Logger) and the customer class only contains logic for adding a new customer.");
            Console.WriteLine();
            Console.WriteLine("SRP says that a class should have only one responsibility and not multiple.So if we apply SRP we can move that logging activity to some other class who will only look after logging activities.");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
