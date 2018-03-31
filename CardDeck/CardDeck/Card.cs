using System;
using System.Collections.Generic;
using System.Text;
using static CardDeck.Enum;

namespace CardDeck
{
    public class Card
    {
        /* this is the constructor, remember that a constructor used
        for wiring, the acutal work is done by a method. */
        public Card(V value, s suit)
        {
            // v are the variations, s is type of card
            Value = value;
            Suit = suit;
        }

        public V Value { get; set; }
        public s Suit { get; set; }
    }

 
}
