using System;

namespace Lab07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> cards = new Deck<Card>();
            Deal(cards);
        }

        public static void BUildSuite(Deck<Card> deck, Card.Suits suit)
        {
            deck.Add(new Card(suit, "Ace"));
            for (int i = 2; i <= 10; i++)
            {
                deck.Add(new Card(suit, i.ToString()));
            }
            deck.Add(new Card(suit, "Jack"));
            deck.Add(new Card(suit, "Queen"));
            deck.Add(new Card(suit, "King"));
        }

        public static void BuildPLayingCardDeck(Deck<Card> deck)
        {
            BUildSuite(deck, Card.Suits.hearts);
            BUildSuite(deck, Card.Suits.diamonds);
            BUildSuite(deck, Card.Suits.clubs);
            BUildSuite(deck, Card.Suits.spades);
        }

        public static void PrintDeck(Deck<Card> deck)
        {
            foreach (Card item in deck)
            {
                Console.WriteLine($"{item.Value} of {item.Suit}");
            }
        }

        public static void Deal(Deck<Card> deck)
        {
            BUildSuite(deck, Card.Suits.hearts);
            PrintDeck(deck);
            Console.ReadLine();
            deck.Shuffle();
            PrintDeck(deck);
            Console.ReadLine();
        }
    }
}
