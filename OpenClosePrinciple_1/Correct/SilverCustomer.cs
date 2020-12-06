using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple_1.Correct
{
    class SilverCustomer : ICustomer
    {
        public double GetDiscount(double totalSales)
        {
            throw new NotImplementedException();
        }
    }
}
