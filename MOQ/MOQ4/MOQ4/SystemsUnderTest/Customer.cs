using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace MOQ4.SystemsUnderTest
{
    public class Customer
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual Address AddressNavigation { get; set; }
    }
}
