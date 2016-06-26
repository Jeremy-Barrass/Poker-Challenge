using System;
using System.Collections;
using System.Collections.Generic;
using Cards;
using CardGeneration;

namespace Deck
{
	public class CardDeck
	{
		public CardDeck(CardGenerator CG) {
			CardGenerator cg = CG;
			currentCards = cg.generateCards(currentCards);
		}

		private List<Card> currentCards = new List<Card>();

		public int getRemainingCards ()
		{
			return currentCards.Count;
		}
	}
}

