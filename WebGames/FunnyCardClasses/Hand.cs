using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.FunnyCardClasses
{
    class Hand
    {
		List<Card> cards;
		public Hand()
		{
			this.cards = new List<Card>();
		}

		public List<Card> getCards()
		{
			return this.cards;
		}

		private void refreshCards()
		{
		}
	}
}
