using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>

    public class Loan
    {
        public bool HasNoBadLoans(string past_loan)
        {
            Console.WriteLine("< Check if loan has been taken earlier,if yes wether its been resolved >");
            if (past_loan == "unresoleved >")
            {
                return false;
            }
            else
                return true;
        }
    }

}
