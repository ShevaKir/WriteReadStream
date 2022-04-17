using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220414_WriteReadStream
{
    interface IAccessStoredge
    {
        void Add(Player player);

        IEnumerable<Player> GetPlayers();
    }
}
