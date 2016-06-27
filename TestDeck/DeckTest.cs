using System;
using System.Collections.Generic;
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

		Mock<List<Card>> cardListMock = new Mock<List<Card>> ();

		CardDeck deck = new CardDeck(cardGen.Object);

		[Test]
		public void ItCallsTheCardGeneratorGenerateCardsMethod() {
			cardGen.Verify(x => x.generateCards(It.IsAny<List<Card>>()));
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

