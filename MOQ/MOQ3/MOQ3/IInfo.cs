using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ3
{
    public interface IInfo
    {
        string name { get; set; }    
        int healthy { get; set; }

        string legs { get; set; }
    }
}
