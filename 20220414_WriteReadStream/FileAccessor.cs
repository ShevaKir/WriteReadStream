using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace _20220414_WriteReadStream
{
    class FileAccessor : IAccessStoredge
    {
        private string _path;

        public FileAccessor(string path)
        {
            _path = path;
        }

        public void Add(Player player)
        {
            //File.AppendText
            using (Stream playerOut = new FileStream(_path, FileMode.Append, FileAccess.Write))
            {
                using (TextWriter writePlayer = new StreamWriter(playerOut))
                {
                    writePlayer.WriteLine(player.ToString());
                }
            }
        }

        IEnumerable<Player> IAccessStoredge.GetPlayers()
        {
            using (StreamReader readerPlayers = File.OpenText(_path))
            {
                while (!readerPlayers.EndOfStream)
                {
                    string[] playerProperties = readerPlayers.ReadLine().Split(';');

                    Player player = SplitPropertiesPlayer(playerProperties);

                    yield return player;
                }
            }
        }

        private Player SplitPropertiesPlayer(string[] player)
        {
            Player currentPlayer = new Player();

            currentPlayer.Name = player[0];
            currentPlayer.Surname = player[1];
            currentPlayer.IdTeam = int.Parse(player[2]);
            currentPlayer.NumberPlayer = int.Parse(player[3]);
            currentPlayer.Role = (Position)Enum.Parse(typeof(Position), player[4]);

            return currentPlayer;
        }
    }
}
