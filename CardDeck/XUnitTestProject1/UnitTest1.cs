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
            //testing Card deck suggesting its a new car
            Deck<Card> testDeck = new Deck<Card> {
                new Card(V.Four, s.Spades),
            };
            Assert.Equal(1, testDeck.Length());
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



    } //bottom of the public test
}
