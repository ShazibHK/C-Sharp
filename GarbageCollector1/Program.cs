using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The number of generations are: " +
                                               GC.MaxGeneration);
        }
    }
}
