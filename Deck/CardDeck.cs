using System;
using System.Collections;
using System.Collections.Generic;

namespace Deck
{
	public class CardDeck
	{
		private List<Card> currentCards = new List<Card>();

		public void generateCards() {
			for (int x = 0; x < 52; x++) {
				Card card = new Card ();
				currentCards.Add (card);
			}
			AssignSuits(List<Card> cards);
			AssignValues(card);
		}

		public struct Card {
			public string Suit;
			public string Value;
		}

		public int getRemainingCards ()
		{
			return currentCards.Count;
		}

		public string examineCard(int card) {
			return "Suit: " + currentCards[card].Suite + ", Value: " + currentCards[card].Value;
	    }

		private void AssignSuits(Card card) {
			string[] suits = { "Spade", "Club", "Diamond", "Heart" };
			for (int x = 0; x < 4; x++) {
				for (int y = 0; y < 13; y++) {
					currentCards [y].Suit = suits [x];
				}
			}
		}
	}
}

