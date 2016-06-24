using System;
using System.Collections;
using System.Collections.Generic;
using Cards;
using CardGeneration;

namespace Deck
{
	public class CardDeck
	{
		CardGenerator cg = new CardGenerator ();

		private List<Card> currentCards = new List<Card>();

		cg.generateCards(currentCards);

		public int getRemainingCards ()
		{
			return currentCards.Count;
		}
	}
}

