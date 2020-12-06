using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_1.Incorrect
{
    public class Customer
    {
        private ConsoleLogger _consoleLogger = new ConsoleLogger();

        public void Add()
        {
            try
            {
                // Code to add customer to database
                throw new Exception("Logging from the Incorrect_Customer - Incorrect way");
            }
            catch (Exception ex)
            {
                _consoleLogger.Error(ex);
            }
        }
    }
}
