using System;
using static CardDeck.Enums;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deal();
            Console.ReadLine();
        }

        /// <summary>
        /// uses a foreach loop to print all cards in the deck
        /// </summary>
        /// <param name="deck">the deck to be displayed</param>
        public static void DisplayDeck(Deck<Card> deck)
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
            }
        }

        /// <summary>
        /// instantiates a new deck
        /// </summary>
        /// <returns>the built deck</returns>
        public static Deck<Card> BuildNewDeck()
        {
            Deck<Card> badHand = new Deck<Card> {
                new Card(V.Four, S.Spades),
                new Card(V.Five, S.Spades),
                new Card(V.Eight, S.Hearts),
                new Card(V.King, S.Hearts),
                new Card(V.Ace, S.Diamonds),
                new Card(V.Queen, S.Clubs),
                new Card(V.Four, S.Clubs),
                new Card(V.Five, S.Clubs),
                new Card(V.Eight, S.Diamonds),
                new Card(V.King, S.Diamonds),
                new Card(V.Ace, S.Hearts),
                new Card(V.Queen, S.Spades),
                new Card(V.Four, S.Diamonds),
                new Card(V.Five, S.Diamonds),
                new Card(V.Eight, S.Clubs),
                new Card(V.King, S.Clubs),
                new Card(V.Ace, S.Spades),
                new Card(V.Queen, S.Diamonds),
            };

            return badHand;

        }

        /// <summary>
        /// uses the Remove() method from the Deck class to remove a card
        /// </summary>
        /// <param name="deck">the Deck object to remove from</param>
        /// <returns>the updated Deck object</returns>
        public static Deck<Card> RemoveFromDeck(Deck<Card> deck)
        {
            deck.Remove();
            return deck;
        }

        public static void Deal()
        {
            Deck<Card> deal = BuildNewDeck();
            Console.WriteLine("New Deck!!!");
            DisplayDeck(deal);
            Console.ReadLine();
            Console.WriteLine();
            deal.Shuffle();
            Console.WriteLine("Shuffled Deck!!!");
            DisplayDeck(deal);
            Console.ReadLine();
            Console.WriteLine();
            deal.Remove();
            Console.WriteLine("Removed a card!!!");
            DisplayDeck(deal);
            Console.ReadLine();
            Console.WriteLine();
            deal.Add(new Card(V.Two, S.Clubs));
            Console.WriteLine("Added the 2 of Clubs");
            DisplayDeck(deal);
        }
    }
}
