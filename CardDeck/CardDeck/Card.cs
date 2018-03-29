using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    public class Card
    {
        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }

        public string Value { get; set; }
        public string Suit { get; set; }
    }
}
