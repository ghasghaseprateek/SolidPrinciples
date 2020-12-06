using System.Collections.Generic;

namespace InterfaceSegregationPrinciple_1.Incorrect
{
    interface ICustomer
    {
        // Thousands of client are using only Add method and don't need Get
        void Add();

        // By adding Get method in this interface we are forcing all the clients to implement this method
        List<string> GetUsernames();
    }
}