using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MathOperation m = new MathOperation();
            double a = 1.2, b = 2.2;
            m.Multiply(a, b);
        }
    }
}
