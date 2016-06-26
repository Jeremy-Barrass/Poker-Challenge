using System;
using Deck;
using CardGeneration;
using Cards;
using NUnit.Framework;
using Moq;

namespace TestDeck
{
	[TestFixture]
	public class DeckTest
	{
		Mock<CardGenerator> cardGen = new Mock<CardGenerator> ();
		CardGenerator gc = cardGen.Object;

		Mock<Card> cardMock = new Mock<Card> ();
		Card cm = cardMock.Object;

		gc.Setup(gc => gc.generateCards(List<Card>));

		CardDeck deck = new CardDeck(gc);

		[Test]
		public void ItCallsTheCardGeneratorGenerateCardsMethod() {
			cardMock.Verify(gc => gc.generateCards(List<Card>)
		}

		[Test]
		public void ItHasFiftyTwoCards ()
		{
			Assert.That (deck.getRemainingCards (), Is.EqualTo (52));
		}

		//[Test]
		//public void ItShufflesTheDeck() {
		//	Assert.That(deck.
		//}
	}
}

