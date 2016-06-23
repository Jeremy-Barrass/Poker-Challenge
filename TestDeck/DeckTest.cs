using System;
using Deck;
using NUnit.Framework;

namespace TestDeck
{
	[TestFixture]
	public class DeckTest
	{
		CardDeck deck = new CardDeck();

		[SetUp]
		public void BeforeEach() {
			deck.generateCards ();
		}

		[Test]
		public void ItHasFiftyTwoCards ()
		{
			Assert.That (deck.getRemainingCards (), Is.EqualTo (52));
		}

		[Test]
		public void ItAssignsASuiteAndValueToANewCard() {
			Assert.That (deck.examineCard (1), Is.EqualTo ("Suite: Spade, Value: Ace"));
		}

		//[Test]
		//public void ItShufflesTheDeck() {
		//	Assert.That(deck.
		//}
	}
}

