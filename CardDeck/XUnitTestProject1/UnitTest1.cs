using CardDeck;
using System;
using Xunit;
using static CardDeck.Enum;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
      
        [Fact]
        public void CanCreateDeck()
        {
            //testing Card deck suggesting its a new cars
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, s.Spades),
            };
            Assert.Equal(1, testDeck.Length());
        }

        // Testing to see if correct number card called is 2
        [Fact]
        public void TestDeck()
        {
            Deck<Card> testDeck = new Deck<Card>
            {
                new Card(V.King, s.Dimond),
                new Card(V.King, s.Hearts),
            };
            Assert.Equal(2, testDeck.Length());
        }

        //testing to see if
        [Fact]
        public void RemoveCard()
        {
            Deck<Card> testDeck = new Deck<Card>
            {
                new Card(V.Four, s.Spades),
                new Card(V.Five, s.Spades),
            };

            testDeck.Remove();
            Assert.Equal(2, testDeck.Length());

        }

        //testing to see if removing one card from deck
        [Fact]
        public void RemoveCards()
        {
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, s.Spades),
                new Card(V.Five, s.Spades),
                new Card(V.Eight, s.Hearts),
                new Card(V.King, s.Hearts),
                new Card(V.Ace, s.Dimond),
            };

            testDeck.Remove();
            Assert.Equal(4, testDeck.Length());
        }


        /*
        [Fact]
       public void RemoveFromDeck()
        {
            Deck<Card> testDeck = new Deck<Card>
            {
                new Card(V.Four, s.Spades),
            };

            testDeck.Remove();
            Assert.Equal(2, testDeck.Length());
        }*/



    }
    
   //bottom of the public test
}
