using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    public class Card
    {
        public enum Suits { hearts, diamonds, spades, clubs }

        public Suits Suit { get; set; }
        public string Value { get; set; }

        public Card (Suits suit, string value) //Card constructor with props
        {
            Suit = suit;
            Value = value;
        }

        public Card() //Blank card constructor
        {

        }
    }
}
