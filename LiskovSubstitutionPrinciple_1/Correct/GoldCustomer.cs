using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Correct
{
    public class GoldCustomer : ICustomer
    {
        public void Add()
        {
            Console.WriteLine("Adding new GOLD customer");
        }

        public double GetDiscount(double totalSales)
        {
            return totalSales - 100;
        }
    }
}
