using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace _20220414_WriteReadStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "players.csv";

            IAccessStoredge filePlayers = new FileAccessor(path);

            Player player = new Player()
            {
                Name = "Denis",
                Surname = "Shevchenko",
                IdTeam = 1,
                NumberPlayer = 7,
                Role = Position.Striker
            };

            filePlayers.Add(player);            

            foreach (var item in filePlayers.GetPlayers())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
