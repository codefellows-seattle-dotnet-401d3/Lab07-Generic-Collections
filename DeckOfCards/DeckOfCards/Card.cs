using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {
        public S Suit { get; set; }
        public V Value { get; set; }

        /// <summary>
        /// Card constructor
        /// </summary>
        /// <param name="value">Card value/rank</param>
        /// <param name="suit">Card suit</param>
        public Card(V value, S suit)
        {
            Suit = suit;
            Value = value;
        }

        /// <summary>
        /// Allows two card instances to be compared against each other.
        /// </summary>
        /// <param name="c">the card to be comapared against this instance</param>
        /// <returns>true if same, false if different</returns>
        public bool IsSame (Card c)
        {
            return Suit == c.Suit && Value == c.Value;
        }
    }
}
