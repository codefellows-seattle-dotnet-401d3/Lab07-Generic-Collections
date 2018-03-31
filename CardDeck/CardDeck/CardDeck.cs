﻿using System;
using System.Collections.Generic;
using System.Text;
using static CardDeck.Enum;

namespace CardDeck
{
    public class Card
    {
        public Card(V value, s suit)
        {
            Value = value;
            Suit = suit;
        }

        public V Value { get; set; }
        public s Suit { get; set; }
    }

 
}
