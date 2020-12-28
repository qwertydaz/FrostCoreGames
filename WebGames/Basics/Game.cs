using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.Basics
{
	abstract class Game
	{
		Dictionary<int, Player> playerList = new Dictionary<int, Player>();
		int counter;
		string inviteCode;

		public abstract string genInvCode(int counter);
		public abstract void addPlayer(string name, string ip);
	}
}
