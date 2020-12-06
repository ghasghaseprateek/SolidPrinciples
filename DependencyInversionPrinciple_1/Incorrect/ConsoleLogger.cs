using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_1.Incorrect
{
    public class ConsoleLogger
    {
        public void Error(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
