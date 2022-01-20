using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class RegularEmployee : Base
    {
        public int AnnualSalary { get; set; }
        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
