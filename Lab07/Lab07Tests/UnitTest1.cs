using System;
using Xunit;
using Lab07;
using System.Collections.Generic;
using static Lab07.Program;

namespace Lab07Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanIntCard()
        {
            Card testCard = new Card(Card.Suits.hearts, "Ace");
            Assert.NotNull(testCard);
        }

        [Fact]
        public void CardHasValue()
        {
            Card testCard = new Card(Card.Suits.hearts, "Ace");
            Assert.NotNull(testCard.Value);
        }

        [Fact]
        public void DeckIsEnumaerable()
        {
            Assert.IsAssignableFrom<IEnumerable<Card>>(new Deck<Card>());
        }
    }
}
