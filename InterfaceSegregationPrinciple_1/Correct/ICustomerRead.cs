using System.Collections.Generic;

namespace InterfaceSegregationPrinciple_1.Correct
{
    interface ICustomerRead : ICustomer
    {
        List<string> GetUsernames();
    }
}