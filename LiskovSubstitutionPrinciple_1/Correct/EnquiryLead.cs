using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Correct
{
    class EnquiryLead : IDiscountCandidates
    {
        public double GetDiscount(double totalSales)
        {
            return totalSales - 50;
        }
    }
}
