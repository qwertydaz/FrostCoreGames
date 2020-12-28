using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.FunnyCardClasses
{
	class Card
	{
		string cardContents;
		CardType cardType;

		public Card()
		{
			this.cardContents = "";
			this.cardType = 0;
		}

		public Card(string contents, CardType type)
        {
			this.cardContents = contents;
			this.cardType = type;
		}
	}
	enum CardType
	{
		white,
		black
	}
}
