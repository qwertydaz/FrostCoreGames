using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGames.Basics;

namespace WebGames.FunnyCardClasses
{
    class FunnyCardGame : Game
    {
		int counter;
		Dictionary<int, FunnyCardGamePlayer> playerDict = new Dictionary<int, FunnyCardGamePlayer>();
		public FunnyCardGame(int counter)
		{
			this.counter = counter;
			string inviteCode = genInvCode(counter);
		}

		override
		public string genInvCode(int counter)
		{
			int x = counter / 26 ^ 3;
			int y = counter % 26 ^ 3 / 26 ^ 2;
			int z = counter % 26 ^ 2 / 26 ^ 1;
			int w = counter % 26 ^ 1;
			//Create string from alphabet of xyzw
			return x.ToString() + y.ToString() + z.ToString() + w.ToString();
		}

		override
		public void addPlayer(string name, string ip)
		{
			FunnyCardGamePlayer newPlayer = new FunnyCardGamePlayer(name, ip);
			this.playerDict.Add(newPlayer.getID, newPlayer);
		}
	}
}
