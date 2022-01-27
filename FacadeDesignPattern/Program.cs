using System;

namespace FacadeDesignPattern
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade

            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Shazib");
            Customer customer2 = new Customer("Shawn");

            bool customer1_eligible = mortgage.IsEligible(customer, 125000,450,"resolved");

            Console.WriteLine("\n" + customer.Name + (customer1_eligible ? ",Congratulations your loan is Approved" : ",Sorry your loan is Rejected"));

           
            bool customer1_eligible2 = mortgage.IsEligible(customer2, 50000,400, "resolved");


            Console.WriteLine("\n\n" + customer2.Name +
                    " has been " + (customer1_eligible2 ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    }
}
