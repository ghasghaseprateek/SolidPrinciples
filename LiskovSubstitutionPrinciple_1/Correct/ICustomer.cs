using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Correct
{
    internal interface ICustomer : IDiscountCandidates
    {
        void Add();
    }
}
