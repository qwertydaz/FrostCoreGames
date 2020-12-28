using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.FunnyCardClasses
{
    class Hand
    {
		Card[] cards;
		public Hand()
		{
			Card[] cards = new Card[10];
		}

		public Card[] getCards()
		{
			return cards;
		}

		private void refreshCards()
		{
		}
	}
}
