using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.FunnyCardClasses
{
	class Deck
    {
		// TODO: Replace with ditt
		static Dictionary<int, Card> whiteCards = new Dictionary<int, Card>();
		static Random rand = new Random();

		/* Constructor for Deck which accepts no params */
		public Deck()
		{
			// TODO: Correct xls input to dict
			string[] whiteCardsFromTxt = new string[];//// READ IN TEXT FILE FOR WHITE CARDS ////
			for (int i=0; i<whiteCardsFromTxt.Length; i++)
			{
				whiteCards.Add(i, new Card(whiteCardsFromTxt[i], 0));
			}
		}

		/* addCard
		 * @param cards - Takes in an array of cards from
		 *				  which to add a card to and return.
		 */

		public static Card[] addCard(Card[] cards)
		{
			Card c = whiteCards[rand.Next(0, whiteCards.Count() - 1)];
			whiteCards.Remove(c.Key);
			cards.Add(c);
			return cards;
		}

		/* dealCards
		 * @param numOfCards - Will create a new hand of cards
		 *					Card[] to return to the user filled
		 *					with numOfCard amount of new cards.
		 */
		public static Card[] dealCards(int numOfCards)
		{
			Card[] newHand = new Card[numOfCards];
			for (int i = 0; i < numOfCards; i++) { addCard(newHand); }
			return newHand;
		}
		int test;
	}
	
}
