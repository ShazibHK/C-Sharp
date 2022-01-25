using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class VCRPlayCommand : ICommand
    {
        public VCRPlayCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("VCR Started.");
        }
    }
}
