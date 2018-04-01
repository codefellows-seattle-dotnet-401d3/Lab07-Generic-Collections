using System;
using static CardDeck.Enum;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" This is a card deck");
            bool session = true;

            while (session)
            {
                Display();
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        DisplayDeck(BuildNewDeck());
                        Console.WriteLine("");
                        break;

                    case '2':
                        Deal();
                        break;

                    case '3':
                        Deal();
                        break;
                }

            }
           
            Display();
            Deal();
            Console.ReadLine();
        }

        static void Display()
        {
            Console.WriteLine("Slelect an option");
            Console.WriteLine("1 : View Deck");
            Console.WriteLine("2: Shuffle Deck ");
            Console.WriteLine("3: Remove One Card");



        }



      
        // the method for the for loop to display each card.
        public static void DisplayDeck(Deck<Card> deck)
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
            }
        }

        // Deck is a list/Dictonary adding a new list with the attached properties of V and s
        /* List<string> cats = new List <string> {kitt, kitten}
         * WriteLine ("$ these are :{cats}")
         *
         */
        public static Deck<Card> BuildNewDeck()
        {
            Deck<Card> DeckofCards = new Deck<Card> {
                new Card(V.Four, s.Spades),
                new Card(V.Five, s.Spades),
                new Card(V.Eight, s.Hearts),
                new Card(V.King, s.Hearts),
                new Card(V.Ace, s.Dimond),
                new Card(V.Queen, s.Clubs),
                new Card(V.Four, s.Clubs),
                new Card(V.Five, s.Clubs),
                new Card(V.Eight, s.Dimond),
                new Card(V.King, s.Dimond),
                new Card(V.Ace, s.Hearts),
                new Card(V.Queen, s.Spades),
                new Card(V.Four, s.Dimond),
                new Card(V.Five, s.Dimond),
                new Card(V.Eight, s.Clubs),
                new Card(V.King, s.Clubs),
                new Card(V.Ace, s.Spades),
                new Card(V.Queen, s.Dimond),
            };

            return DeckofCards;

        }

        // calls the remove method on the Generics list of Deck <card>
        public static Deck<Card> RemoveFromDeck(Deck<Card> deck)
        {
            deck.Remove();
            return deck;
        }

        public static void Deal()
        {
            Deck<Card> deal = BuildNewDeck();
            Console.WriteLine("Here is ths Deck");
            DisplayDeck(deal);
            Console.ReadLine();
            Console.WriteLine();
            deal.Shuffle();
            Console.WriteLine("Here is a Deck with Random");
            DisplayDeck(deal);
            Console.ReadLine();
            Console.WriteLine();
            deal.Remove();
            Console.WriteLine("Removed only ");
            DisplayDeck(deal);
            Console.ReadLine();
            Console.WriteLine();
            deal.Add(new Card(V.Three, s.Dimond));
            Console.WriteLine("Add two cards");
            DisplayDeck(deal);
        }
    }
}