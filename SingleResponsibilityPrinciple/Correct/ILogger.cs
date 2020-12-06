using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple_1.Correct
{
    public interface ILogger
    {
        void Error(Exception ex);
    }
}
