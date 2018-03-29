using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck<Card> royals = new Deck<Card> {
                new Card(V.King, S.Spades),
                new Card(V.Queen, S.Spades),
                new Card(V.Jack, S.Spades),
                new Card(V.Ten, S.Spades),
                new Card(V.King, S.Diamonds),
                new Card(V.Queen, S.Diamonds),
                new Card(V.Jack, S.Diamonds),
                new Card(V.Ten, S.Diamonds),
                new Card(V.King, S.Hearts),
                new Card(V.Queen, S.Hearts),
                new Card(V.Jack, S.Hearts),
                new Card(V.Ten, S.Hearts),
                new Card(V.King, S.Clubs),
                new Card(V.Queen, S.Clubs),
                new Card(V.Jack, S.Clubs),
                new Card(V.Ten, S.Clubs),
            };
            PrintDeck(royals);

            Console.WriteLine("Nobody likes Clubs. Lets get rid of those.");
            royals.Remove();
            royals.Remove();
            royals.Remove();
            royals.Remove();

            PrintDeck(royals);

            Console.WriteLine("Add in the Aces");
            royals.Add(new Card(V.Ace, S.Hearts));
            royals.Add(new Card(V.Ace, S.Diamonds));
            royals.Add(new Card(V.Ace, S.Spades));
            PrintDeck(royals);

            Console.WriteLine("Ok. Now we have an awesome deck. Lets shuffle it up!");
            Deal(royals);
        }

        /// <summary>
        /// Prints to the console every card in a deck of cards
        /// </summary>
        /// <param name="deck">deck to be printed to the console</param>
        public static void PrintDeck(Deck<Card> deck)
        {
            foreach (Card c in deck)
            {
                Console.WriteLine($"{(V)c.Value} {(S)c.Suit}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This will show the starting deck, shuffle it, and show the shuffled deck.
        /// </summary>
        /// <param name="deck">deck to shuffle</param>
        public static void Deal(Deck<Card> deck)
        {
            Console.WriteLine("Starting deck");
            PrintDeck(deck);
            Console.WriteLine("shuffling ...");
            deck.Shuffle();
            PrintDeck(deck);
        }

    }
}
