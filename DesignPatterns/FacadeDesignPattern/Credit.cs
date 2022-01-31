using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{

    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>

    public class Credit
    {
        public bool HasGoodCredit(int credit_score)
        {
            Console.WriteLine("< Check if credit score is sufficient > ");
            if (credit_score > 350)
                return true;
            return false;
        }
    }

}
