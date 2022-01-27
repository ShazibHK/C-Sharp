using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
            Console.Read();
        }
    }
}
