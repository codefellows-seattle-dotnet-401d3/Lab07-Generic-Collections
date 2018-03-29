using System;
using Xunit;
using DeckOfCards;

namespace TestDeckAndCards
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateCard()
        {
            Card ace = new Card(V.Ace, S.Spades);
            Assert.Equal(new int[] { (int)ace.Value, (int)ace.Suit }, new int[] { 14, 2 });
        }

        [Fact]
        public void CanCompareCardsTrue()
        {
            Assert.True(new Card(V.Eight, S.Diamonds).IsSame(new Card(V.Eight, S.Diamonds)));
        }

        [Fact]
        public void CanCompareCardsFalseValue()
        {
            Assert.False(new Card(V.Eight, S.Diamonds).IsSame(new Card(V.Seven, S.Diamonds)));
        }

        [Fact]
        public void CanCompareCardsFalseSuit()
        {
            Assert.False(new Card(V.Eight, S.Diamonds).IsSame(new Card(V.Eight, S.Clubs)));
        }

        [Fact]
        public void CanAccessByIndex()
        {
            Deck<Card> test = new Deck<Card> {
                new Card (V.Ace, S.Spades),
                new Card(V.King, S.Hearts),
                new Card(V.Queen, S.Clubs),
                new Card(V.Jack, S.Diamonds),
                new Card(V.Ten, S.Hearts),
            };
            Assert.True(test.AtIndex(4).IsSame(new Card(V.Ten, S.Hearts)));
        }

    }
}
