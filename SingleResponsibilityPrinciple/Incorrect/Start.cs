using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple_1.Incorrect
{
    public class Start
    {
        public static void StartApplication()
        {
            Console.WriteLine("Incorrect");
            Console.WriteLine();
            Customer incorrect_Customer = new Customer();
            incorrect_Customer.Add();
            Console.WriteLine();
            Console.WriteLine("This is not the right way because the logic for logging is in Customer class.");
            Console.WriteLine();
            Console.WriteLine("The above customer class is doing things WHICH HE IS NOT SUPPOSED TO DO.Customer class should do customer datavalidations, call the customer data access layer etc, but if you see the catch block closely it also doing LOGGING activity.In simple words its over loaded with lot of responsibility.");
            Console.WriteLine();
            Console.WriteLine("So tomorrow if add a new logger like event viewer I need to go and change the “Customer”class, that’s very ODD.");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
