using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Incorrect
{
    class Start
    {
        public static void StartApplication(int totalSales)
        {
            Console.WriteLine("Incorrect");
            Console.WriteLine();

            List<ICustomer> customers = new List<ICustomer>();
            customers.Add(new SilverCustomer());
            customers.Add(new GoldCustomer());
            customers.Add(new EnquiryCustomer());

            try
            {
                foreach (ICustomer o in customers)
                {
                    var discount = o.GetDiscount(totalSales);
                    Console.WriteLine($"Discount: {discount}");

                    // This will throw an exception for Enquiry.
                    o.Add();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.WriteLine();
            Console.WriteLine("This is not the right way because “Enquiry” it looks like a “Customer” but IT IS NOT A CUSTOMER.");

            Console.WriteLine();
            Console.WriteLine("So the parent cannot replace the child object seamlessly. In other words “Customer” is not the actual parent for the “Enquiry”class. “Enquiry” is a different entity altogether. ");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
