using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DVDStopCommand : ICommand
    {
        public DVDStopCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("DVD Stopped.");
        }
    }
}
