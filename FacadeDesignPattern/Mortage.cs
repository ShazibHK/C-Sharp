using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>

    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer cust, int amount, int credit_score, string past_loan)
        {
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("{0} applies for  Bike loan of worth {1}\n",
                cust.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant

            if (!bank.HasSufficientSavings(amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(past_loan))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(credit_score))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
