using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.Basics
{
	abstract class Game {
		HashMap<int, Player> playerList = new HashMap;
		int counter;
		string inviteCode;

		public string genInvCode();
		private void addPlayer(string name);
	}
}
