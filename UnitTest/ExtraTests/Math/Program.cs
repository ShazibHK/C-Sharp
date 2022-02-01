using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public static class MathOperation
    {
        public static double Add(double number1, double number2)
        {
            return (number1 + number2);
        }

        public static double Subtract(double number1, double number2)
        {
            return (number1 - number2);
        }

        public static double Multiply(double number1, double number2)
        {
            return (number1 * number2);
        }

        public static double Divide(double number1, double number2)
        {
            return (number1 / number2);
        }
    }
   class Program
    {
        public static void Main(string[] Args)
        {
            throw new NotImplementedException();
        }
    }
}
