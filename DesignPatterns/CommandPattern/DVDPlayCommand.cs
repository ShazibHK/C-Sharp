using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DVDPlayCommand : ICommand
    {
        public DVDPlayCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("DVD Started.");
        }
    }
}
