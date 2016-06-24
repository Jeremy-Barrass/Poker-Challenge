using System;
using Cards;
using System.Collections;
using System.Collections.Generic;

namespace CardGeneration
{
	public class CardGenerator {

		public CardGenerator() {
			Dictionary<string,int> values = new Dictionary<string, int> ();
			values.Add("Ace", 1);
			values.Add("Two", 2);
			values.Add("Three", 3);
			values.Add("Four", 4);
			values.Add("Five", 5);
			values.Add("Six", 6);
			values.Add("Seven", 7);
			values.Add("Eight", 8);
			values.Add("Nine", 9);
			values.Add("Ten", 10);
			values.Add("Jack", 11);
			values.Add("Queen", 13);
			values.Add("King", 14);
		}

		private string[] suits = { "Spade", "Club", "Diamond", "Heart" };

		private void AssignCards(List<Card> cards) {
			for (int x = 0; x < 4; x++) {
				for (int y = 0; y < 14; y++) {
					cardsetCardSuit(suits[x]);
				}
			}
		}

		public void generateCards(List<Card> deck) {
			for (int x = 0; x < 52; x++) {
				Card card = new Card ();
				deck.Add (card);
			}
			AssignCards(deck);
		}

	}
}

