using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.Basics
{
    abstract class Player
    {
        string playerName;
        string playerIP;
        int playerID;

        public abstract int getID();

    }
}
