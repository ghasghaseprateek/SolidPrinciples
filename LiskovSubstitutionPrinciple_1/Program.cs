using System;

namespace LiskovSubstitutionPrinciple_1
{
    class Program
    {
        private const int _totalSales = 500;

        static void Main(string[] args)
        {
            Incorrect.Start.StartApplication(_totalSales);

            Correct.Start.StartApplication(_totalSales);

            Console.ReadLine();
        }
    }
}
