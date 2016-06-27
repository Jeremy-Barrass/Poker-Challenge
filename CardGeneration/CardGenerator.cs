using System;
using Cards;
using System.Collections;
using System.Collections.Generic;

namespace CardGeneration
{
	public class CardGenerator {

		private string[] suits = { "Spade", "Club", "Diamond", "Heart" };

		private string[] values = {
			"Ace",
			"Two",
			"Three",
			"Four",
			"Five",
			"Six",
			"Seven",
			"Eight",
			"Nine",
			"Ten",
			"Jack",
			"Queen",
			"King"
		};

		private void AssignCards(List<Card> cards) {
			for (int x = 0; x < 52; x++) {
				cards [x].setCardSuit (suits[x / 4]);
				cards [x].setCardValue (values[x / 13]);
			}
		}

		public List<Card> generateCards(List<Card> deck) {
			for (int x = 0; x < 52; x++) {
				Card card = new Card ();
				deck.Add (card);
			}
			AssignCards(deck);
			return deck;
		}

	}
}

