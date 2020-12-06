using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_1.Correct
{
    public class FileLogger : ILogger
    {
        public void Error(Exception ex)
        {
            Console.WriteLine("Logging error to a file");
        }
    }
}
