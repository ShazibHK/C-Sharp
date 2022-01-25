using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Client
    {
        public Client()
        {
        }
        public static int Main(String[] args)
        {
            //Instantiate the invoker object
            Remote remote = new Remote();
            //Instantiate DVD related commands and pass them to invoker object
            DVDPlayCommand dvdPlayCommand = new DVDPlayCommand();
            remote.Invoke(dvdPlayCommand);
            DVDStopCommand dvdStopCommand = new DVDStopCommand();
            remote.Invoke(dvdStopCommand);
            //Instantiate VCR related commands and pass them to invoker object
            VCRPlayCommand vcrPlayCommand = new VCRPlayCommand();
            remote.Invoke(vcrPlayCommand);
            VCRStopCommand vcrStopCommand = new VCRStopCommand();
            remote.Invoke(vcrStopCommand);
            return 0;
        }
    }
}
