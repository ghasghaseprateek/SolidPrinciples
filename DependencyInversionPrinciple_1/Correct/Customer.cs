using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_1.Correct
{
    public class Customer
    {
        private ILogger _logger;

        public Customer(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            try
            {
                // Code to add customer to database
                throw new Exception("Logging from the Logger - Correct way");
            }
            catch (Exception ex)
            {
                // Calling logger to log
                _logger.Error(ex);
            }
        }
    }
}
