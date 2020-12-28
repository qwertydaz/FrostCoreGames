using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGames.Basics;

namespace WebGames.FunnyCardClasses
{
	class FunnyCardGamePlayer : Player
	{
		Hand playerHand;

		public FunnyCardGamePlayer(string name, string ip)
		{
			string playerName = name;
			string playerIP = ip;
			Hand playerHand = new Hand();
		}
	}
}
