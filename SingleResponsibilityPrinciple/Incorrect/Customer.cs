using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple_1.Incorrect
{
    public class Customer
    {
        public void Add()
        {
            try
            {
                // Code to add customer to database
                throw new Exception("Logging from the Incorrect_Customer - Incorrect way");
            }
            catch (Exception ex)
            {
                // Logging right from the call 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
