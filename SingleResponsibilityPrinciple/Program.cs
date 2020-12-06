using SingleResponsibilityPrinciple_1.Correct;
using SingleResponsibilityPrinciple_1.Incorrect;
using System;

namespace SingleResponsibilityPrinciple_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incorrect");
            Console.WriteLine();
            Incorrect_Customer incorrect_Customer = new Incorrect_Customer();
            incorrect_Customer.Add();
            Console.WriteLine();
            Console.WriteLine("This is not the right way because the logic for logging is in Customer class.");
            Console.WriteLine();
            Console.WriteLine("The above customer class is doing things WHICH HE IS NOT SUPPOSED TO DO.Customer class should do customer datavalidations, call the customer data access layer etc, but if you see the catch block closely it also doing LOGGING activity.In simple words its over loaded with lot of responsibility.");
            Console.WriteLine();
            Console.WriteLine("So tomorrow if add a new logger like event viewer I need to go and change the “Customer”class, that’s very ODD.");

            Console.WriteLine("\n\n\n\n\n");

            Console.WriteLine("Correct");
            Console.WriteLine();
            Correct_Customer correct_Customer = new Correct_Customer(new FileLogger());
            correct_Customer.Add();
            Console.WriteLine();
            Console.WriteLine("This is the right way because the logic for logging is moved to a new class(Logger) and the customer class only contains logic for adding a new customer.");
            Console.WriteLine();
            Console.WriteLine("SRP says that a class should have only one responsibility and not multiple.So if we apply SRP we can move that logging activity to some other class who will only look after logging activities.");

            Console.WriteLine("\n\n\n\n\n");
            Console.ReadLine();
        }
    }
}
