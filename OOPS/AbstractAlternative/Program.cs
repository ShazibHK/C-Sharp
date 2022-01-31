using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cust_Lib;
namespace AbstractAlternative
{
     class Program
    {
        static void Main(string[] args)
        {
            Class1 Cust_Lib=new Class1();
            var a=Cust_Lib.display(2);
            Console.WriteLine(a);   
          
        }
    }
}
