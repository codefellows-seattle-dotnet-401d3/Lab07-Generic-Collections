using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    public class Enums
    {
        /// <summary>
        /// all the possible values of cards
        /// </summary>
        public enum V : byte
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        /// <summary>
        /// the available suits for the card
        /// </summary>
        public enum S : byte
        {
            Spades,
            Hearts,
            Diamonds,
            Clubs
        }
    }
}
