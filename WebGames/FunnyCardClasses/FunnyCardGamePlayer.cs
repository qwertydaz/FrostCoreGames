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
		string playerName;
		string playerIP;
		int playerID;

		public FunnyCardGamePlayer(string name, string ip)
		{
			this.playerName = name;
			this.playerIP = ip;
			this.playerID = generateID(playerName, playerIP);
			Hand playerHand = new Hand();
		}

        public override int getID() { return this.playerID; }

		private int generateID(string name, string ip)
        {
			// TODO: Generate playerID
        }
    }
}
