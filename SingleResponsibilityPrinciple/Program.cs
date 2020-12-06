using SingleResponsibilityPrinciple_1.Correct;
using SingleResponsibilityPrinciple_1.Incorrect;
using System;

namespace SingleResponsibilityPrinciple_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Incorrect.Start.StartApplication();

            Correct.Start.StartApplication();
            
            Console.ReadLine();
        }
    }
}
