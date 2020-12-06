using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple_1.Correct
{
    public class GoldCustomer : ICustomer
    {
        public double GetDiscount(double totalSales)
        {
            return totalSales - 100;
        }
    }
}
