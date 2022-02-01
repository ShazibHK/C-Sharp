using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoMOQ
{
    public interface ISomethingUseful
    {
        int CalculateSomething(int x);
    }

    public class MyClass
    {
        public MyClass(ISomethingUseful useful)
        {
            this.useful = useful;
        }

        ISomethingUseful useful;

        public int MethodUnderTest(int x)
        {
            //Yah, it's dumb.
            return 1 + useful.CalculateSomething(x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
