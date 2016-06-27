using System;
using System.Collections.Generic;
using CardGeneration;
using Cards;
using NUnit.Framework;
using Moq;

namespace CardGenerationTest
{
	[TestFixture]
	public class TestGenerator
	{
		CardGenerator cg = new CardGenerator();

		Mock<List<Card>> cardListMock = new Mock<List<Card>> ();

		[SetUp]
		public void BeforeEach ()
		{
			cg.generateCards (cardListMock);
		}

		[Test]
		public void ItAddsNewCardsToTheCardList() {
			cardListMock.Verify (x => x.Add (It.IsAny(<Card>));
		}

		[Test]
		public void ItSetsCardSuit() {
			cardMock.Verify(cm => cm.setCardSuit("Spade"));
		}

		[Test]
		public void ItSetsCardValue() {
			cardMock.Verify (cm => cm.setCardValue ("Ace"));
		}
	}
}

