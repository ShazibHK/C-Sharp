using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ2
{
    public interface IPlayerDataMapper
    {
        bool PlayerNameExistsInDatabase(string name);
        void InsertNewPlayerIntoDatabase(string name);
    }
}
