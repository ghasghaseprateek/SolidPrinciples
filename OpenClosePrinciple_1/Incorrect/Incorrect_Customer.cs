using OpenClosePrinciple_1.Common;

namespace OpenClosePrinciple_1.Incorrect
{
    public class Incorrect_Customer
    {
        public CustomerType Type { get; set; }

        public double GetDiscount(double totalSales)
        {
            if (Type == CustomerType.Gold)
            {
                return totalSales - 100;
            }
            else
            {
                return totalSales - 50;
            }
        }
    }
}
