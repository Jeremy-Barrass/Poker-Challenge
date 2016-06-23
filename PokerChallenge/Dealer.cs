using System;
using Deck;
using TestDeck;

namespace PokerChallenge
{
	class Dealer
	{
		public static void Main (string[] args)
		{
			DeckTest dt = new DeckTest();

			dt.ItHasFiftyTwoCards();

			dt.ItAssignsASuiteToANewCard ();
		}
	}
}
