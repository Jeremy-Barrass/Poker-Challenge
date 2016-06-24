using System;

namespace Cards
{
	public struct Card {
		private string Suit;
		private string Value;
		public string examineCard(int card) {
			return "Suit: " + this.Suit + ", Value: " + this.Value;
		}
		public void setCardSuit(string suit) {
			Suit = suit;
		}

		public void setCardValue(string value) {
			Value = value;
		}

	}
}

