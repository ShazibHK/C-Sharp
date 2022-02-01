using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ3
{
    public class Animal
    {
        private readonly IInfo _info;
        public Animal(IInfo info)
        {
            if(info ==null)
            {
                throw new ArgumentNullException(nameof(info));

            }
            _info = info;
        }
        public string Legs() => _info.legs;
        public int Health() => _info.healthy;
        public string name() => _info.name;
    }
}
 