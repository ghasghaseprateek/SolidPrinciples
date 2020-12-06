using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Correct
{
    class SilverCustomer : ICustomer
    {
        public void Add()
        {
            Console.WriteLine("Adding new SILVER customer");
        }

        public double GetDiscount(double totalSales)
        {
            return totalSales - 50;
        }
    }
}
