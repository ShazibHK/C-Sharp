using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>

    public class ConcreteColleague1 : Colleague
    {
        // Constructor
        protected Mediator _mediator;
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        {
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
            Console.WriteLine(this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: "
                + message);
        }
    }
}
