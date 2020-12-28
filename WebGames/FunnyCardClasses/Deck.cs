using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGames.FunnyCardClasses
{
	class Deck
    {
		int cardNum;
		// TODO: Replace with ditt
		Dictionary<int, Card> whiteCards = new Dictionary<int, Card>();
		Random rand = new Random();

		/* Constructor for Deck which accepts no params */
		public Deck()
		{
			// TODO: Correct xls input to dict
			string[] whiteCardsFromTxt = string[];//// READ IN TEXT FILE FOR WHITE CARDS ////
			for (int i=0; i<whiteCardsFromTxt.Length; i++)
			{
				whiteCards.Add(i, whiteCardsFromTxt[i]);
			}
		}

		/* addCard
		 * @param cards - Takes in an array of cards from
		 *				  which to add a card to and return.
		 */

		public Card[] addCard(Card[] cards)
		{
			Card c = whiteCards.Get(rand.Next(0, whiteCards.Size));
			whiteCards.Remove(c);
			cards.Add(c);
			return cards;
		}

		/* dealCards
		 * @param numOfCards - Will create a new hand of cards
		 *					Card[] to return to the user filled
		 *					with numOfCard amount of new cards.
		 */
		public Card[] dealCards(int numOfCards)
		{
			Card[] newHand = new Card[numOfCards];
			for (int i = 0; i < numOfCards; i++) { addCard(newHand); }
			return newHand;
		}
		int test;
	}
	
}
