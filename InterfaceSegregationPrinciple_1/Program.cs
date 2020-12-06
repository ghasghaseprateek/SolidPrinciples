using System;

namespace InterfaceSegregationPrinciple_1
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
