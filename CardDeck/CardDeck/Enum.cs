﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    /* this is a Enum : this is also a Class, An enum
     is like miss kitty, and has emurators inside of her so
     she can pick on other students.
   */

    public class Enum
    {
        // V will be this list of all the cards
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

        // S will be the type of cards
        public enum s : byte
        {
            Spades,
            Hearts,
            Dimond,
            Clubs
        }


    }
}
