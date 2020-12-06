using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_1.Correct
{
    public interface ILogger
    {
        void Error(Exception ex);
    }
}
