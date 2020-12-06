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
            Incorrect.Start.StartApplication(_totalSales, _customerType);

            Correct.Start.StartApplication(_totalSales, _customerType);

            Console.ReadLine();
        }
    }
}
