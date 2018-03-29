using Xunit;
using CardDeck;
using static CardDeck.Enums;

namespace TestCardDeck
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreatCard()
        {
            Card testCard = new Card(V.Two, S.Clubs);
            Assert.Equal(new byte[] { (byte)testCard.Value, (byte)testCard.Suit }, new byte[] { 2, 3 });
        }

        [Fact]
        public void CanCreateDeck()
        {
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, S.Spades),
                new Card(V.Five, S.Spades),
                new Card(V.Eight, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Ace, S.Diamonds),
                new Card(V.Queen, S.Clubs),
            };


            Assert.Equal(6, testDeck.Length());
        }

        [Fact]
        public void CanRemoveCard()
        {
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, S.Spades),
                new Card(V.Five, S.Spades),
                new Card(V.Eight, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Ace, S.Diamonds),
                new Card(V.Queen, S.Clubs),
            };

            testDeck.Remove();

            Assert.Equal(5, testDeck.Length());
        }

        [Fact]
        public void CanRemoveMultipleCards()
        {
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, S.Spades),
                new Card(V.Five, S.Spades),
                new Card(V.Eight, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Ace, S.Diamonds),
                new Card(V.Queen, S.Clubs),
            };

            testDeck.Remove();
            testDeck.Remove();
            testDeck.Remove();

            Assert.Equal(3, testDeck.Length());
        }

        [Fact]
        public void CanRemoveAllCards()
        {
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, S.Spades),
                new Card(V.Five, S.Spades),
                new Card(V.Eight, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Ace, S.Diamonds),
                new Card(V.Queen, S.Clubs),
            };

            testDeck.Remove();
            testDeck.Remove();
            testDeck.Remove();
            testDeck.Remove();
            testDeck.Remove();
            testDeck.Remove();

            Assert.Empty(testDeck);
        }

        [Fact]
        public void CanAddCardToEmptyDeck()
        {
            Deck<Card> emptyDeck = new Deck<Card>();

            emptyDeck.Add(new Card(V.Two, S.Clubs));

            Assert.NotEmpty(emptyDeck);
        }

        [Fact]
        public void CanAddCardToExistingDeck()
        {
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, S.Spades),
                new Card(V.Five, S.Spades),
                new Card(V.Eight, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Ace, S.Diamonds),
                new Card(V.Queen, S.Clubs),
            };

            testDeck.Add(new Card(V.Two, S.Clubs));

            Assert.Equal(7, testDeck.Length());
        }

        [Fact]
        public void CanAddMultipleCardsToEmptyDeck()
        {
            Deck<Card> emptyDeck = new Deck<Card>();

            emptyDeck.Add(new Card(V.Two, S.Clubs));
            emptyDeck.Add(new Card(V.Three, S.Clubs));
            emptyDeck.Add(new Card(V.Four, S.Clubs));

            Assert.Equal(3, emptyDeck.Length());
        }

        [Fact]
        public void CanAddMultipleCardsToExistingDeck()
        {
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, S.Spades),
                new Card(V.Five, S.Spades),
                new Card(V.Eight, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Ace, S.Diamonds),
                new Card(V.Queen, S.Clubs),
            };

            testDeck.Add(new Card(V.Two, S.Clubs));
            testDeck.Add(new Card(V.Three, S.Clubs));
            testDeck.Add(new Card(V.Four, S.Clubs));

            Assert.Equal(9, testDeck.Length());
        }
    }
}
