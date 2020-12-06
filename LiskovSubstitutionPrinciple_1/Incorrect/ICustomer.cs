using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Incorrect
{
    public interface ICustomer
    {
        double GetDiscount(double totalSales);
        void Add();
    }
}
