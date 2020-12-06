using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Incorrect
{
    class EnquiryCustomer : ICustomer
    {
        public void Add()
        {
            // Enqiry customer is a lead. Thus cannot be added to customer.
            throw new NotImplementedException("Enquiry customer is a lead. Thus cannot be added to customer");
        }

        public double GetDiscount(double totalSales)
        {
            return totalSales - 50;
        }
    }
}
