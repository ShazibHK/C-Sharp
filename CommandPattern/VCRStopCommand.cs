using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    using System;
    public class VCRStopCommand : ICommand
    {
        public VCRStopCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("VCR Stopped.");
        }
    }
}
