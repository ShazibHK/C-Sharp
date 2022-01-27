using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MediatorDesignPattern
{
    /// <summary>
    /// Mediator Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();
            Console.WriteLine(m);
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
           
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;
            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            // Wait for user

            Console.ReadKey();
        }
    }   
}

