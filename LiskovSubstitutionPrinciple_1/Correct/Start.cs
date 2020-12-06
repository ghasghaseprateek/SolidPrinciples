using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple_1.Correct
{
    class Start
    {
        public static void StartApplication(int totalSales)
        {
            Console.WriteLine("Correct");
            Console.WriteLine();

            List<ICustomer> customers = new List<ICustomer>();
            customers.Add(new SilverCustomer());
            customers.Add(new GoldCustomer());
            Console.WriteLine("Compilation error for EnquiryCustomer as it is not a customer");
            //Customers.Add(new EnquiryCustomer());

            try
            {
                foreach (ICustomer o in customers)
                {
                    o.Add();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine();
            List<IDiscountCandidates> discountCandidates = new List<IDiscountCandidates>();
            discountCandidates.Add(new SilverCustomer());
            discountCandidates.Add(new GoldCustomer());
            discountCandidates.Add(new EnquiryLead());

            try
            {
                foreach (IDiscountCandidates o in discountCandidates)
                {
                    var discount = o.GetDiscount(totalSales);
                    Console.WriteLine($"Discount: {discount}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("This is the right way because “Enquiry” is not a customer but a DiscountCandidates");

            Console.WriteLine();
            Console.WriteLine("LISKOV principle says the parent should easily replace the child object.");

            Console.WriteLine("\n\n\n\n\n");
        }
    }
}
