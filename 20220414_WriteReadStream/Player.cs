using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220414_WriteReadStream
{
    class Player
    {
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public int IdTeam { get; set; }
        
        public int NumberPlayer { get; set; }

        public Position Role { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4}", Name, Surname, IdTeam, NumberPlayer, Role);
        }
    }
}
