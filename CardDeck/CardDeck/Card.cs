using System;
using System.Collections.Generic;
using System.Text;
using static CardDeck.Enums;

namespace CardDeck
{
    public class Card
    {
        /// <summary>
        /// constructor for card objects
        /// </summary>
        /// <param name="value">value of the card</param>
        /// <param name="suit">the card suit</param>
        public Card(V value, S suit)
        {
            Value = value;
            Suit = suit;
        }

        public V Value { get; set; }
        public S Suit { get; set; }
    }
}
