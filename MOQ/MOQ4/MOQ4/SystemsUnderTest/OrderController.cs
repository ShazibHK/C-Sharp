using MOQ4.SystemsUnderTest.MOQExamples.SystemsUnderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ4.SystemsUnderTest
{
    public class OrderController
    {
        private readonly IOrder _order;

        public OrderController(IOrder order)
        {
            _order = order;
        }
        public Customer GetCustomer()
        {
            return _order.CustomerOnOrder;
        }
    }

}
