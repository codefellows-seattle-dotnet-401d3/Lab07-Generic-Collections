using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] cards = new T[10];
        int count = 0;

        public void Add(T newCard)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }

            cards[count++] = newCard;
        }

        public int Length()
        {
            return count;
        }

        public T Remove()
        {
            Array.Resize(ref cards, cards.Length - 1);
            T deck = cards[--count];
            return deck;
        }

        public void Shuffle()
        {
            for (int i = 0; i < count; i++)
            {
                Random rand = new Random();
                int randNum = rand.Next(0, count);
                T temp = cards[i];
                cards[i] = cards[randNum];
                cards[randNum] = temp;
            }
        }

      
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
