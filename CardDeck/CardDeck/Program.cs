using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck<Card> sampleDeck = BuildNewDeck();
            DisplayDeck(sampleDeck);
            sampleDeck.Shuffle();
            DisplayDeck(sampleDeck);
            Console.ReadLine();
        }

        public static void DisplayDeck(Deck<Card> deck)
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value + " of " + card.Suit + "s");
            }
        }

        public static Deck<Card> BuildNewDeck()
        {
            Card fourSpade = new Card("4", "spade");
            Card fiveSpade = new Card("5", "spade");
            Card fourHeart = new Card("4", "heart");
            Card fiveHeart = new Card("5", "heart");
            Card fourDiamond = new Card("4", "diamond");
            Card fourClub = new Card("4", "club");

            Deck<Card> myDeck = new Deck<Card> { fourClub, fourDiamond, fourHeart };
            myDeck.Add(fourSpade);
            myDeck.Add(fiveHeart);
            myDeck.Add(fiveSpade);

            return myDeck;

        }

        public static Deck<Card> RemoveFromDeck(Deck<Card> deck, Card card)
        {
            deck.Remove(card);
            return deck;
        }
    }
}
