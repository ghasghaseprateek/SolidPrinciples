using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple_1.Correct
{
    public class ConsoleLogger : ILogger
    {
        public void Error(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
