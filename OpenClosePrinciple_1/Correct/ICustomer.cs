using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple_1.Correct
{
    public interface ICustomer
    {
        double GetDiscount(double totalSales);
    }
}
