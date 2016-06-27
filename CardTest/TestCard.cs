using System;
using Cards;
using NUnit.Framework;

namespace CardTest
{
	[TestFixture]
	public class TestCard
	{
		Card card = new Card();

		[SetUp]
		public void BeforeEach() {
			card.setCardSuit ("Spade");
			card.setCardValue ("Ace");
		}

		[Test]
		public void ItHasAMethodWhichSetsTheSuitProperty ()
		{
			Assert.That(card, Has.Property("Suit").EqualTo("Spade"));
		}

		[Test]
		public void ItHasAMethodWhichSetsTheValueProperty() {
			Assert.That (card, Has.Property ("Value").EqualTo ("Ace"));
		}
	}
}

