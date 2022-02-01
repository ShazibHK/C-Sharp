using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ4.SystemsUnderTest
{
    namespace MOQExamples.SystemsUnderTest
    {
        public interface IOrder
        {
            Customer CustomerOnOrder { get; set; }
        }
    }
}
