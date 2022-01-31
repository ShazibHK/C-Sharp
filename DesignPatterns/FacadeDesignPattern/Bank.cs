using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>

    public class Bank
    {
        public bool HasSufficientSavings(int amount)
        {
            Console.WriteLine("< Check if bank has sufficient amount deposited > ");
            if (amount > 100000)
                return true;
            return false;
        }
    }
}
