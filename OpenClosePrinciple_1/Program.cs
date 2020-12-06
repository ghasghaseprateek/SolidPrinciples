using OpenClosePrinciple_1.Common;
using OpenClosePrinciple_1.Correct;
using OpenClosePrinciple_1.Incorrect;
using System;

namespace OpenClosePrinciple_1
{
    class Program
    {
        private const int _totalSales = 500;
        private const CustomerType _customerType = CustomerType.Gold;

        static void Main(string[] args)
        {
            Console.WriteLine("Incorrect");
            Console.WriteLine();
            Incorrect_Customer incorrect_Customer = new Incorrect_Customer() { Type = _customerType };
            incorrect_Customer.GetDiscount(_totalSales);
            Console.WriteLine();
            Console.WriteLine("This is not the right way because if a new customer type is added we are changing the implementation of the Customer class by adding a new if statement.");

            Console.WriteLine("\n\n\n\n\n");

            Console.WriteLine("Correct");
            Console.WriteLine();
            ICustomer correct_Customer;
            switch (_customerType)
            {
                case CustomerType.Gold:
                    correct_Customer = new GoldCustomer();
                    break;
                case CustomerType.Silver:
                    correct_Customer = new SilverCustomer();
                    break;
                default:
                    break;
            }
            correct_Customer.GetDiscount(_totalSales);
            Console.WriteLine();
            Console.WriteLine("This is the right way because if a new customer type is added we are not changing the implementation of any of the current classes instead we will inherit from ICustomer and extend the functionality.");
            Console.WriteLine();
            Console.WriteLine("OCP: Open for extension and closed for modification");

            Console.WriteLine("\n\n\n\n\n");
            Console.ReadLine();
        }
    }
}
