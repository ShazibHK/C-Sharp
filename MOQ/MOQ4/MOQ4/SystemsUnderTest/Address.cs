using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ4.SystemsUnderTest
{
    public class Address
    {
        public virtual int Id { get; set; }
        public virtual int StreetNumber { get; set; }
        public virtual string StreetName { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
    }
}
