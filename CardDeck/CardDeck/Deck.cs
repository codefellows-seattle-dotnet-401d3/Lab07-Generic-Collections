using System;
using System.Collections;
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
            if(count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length + 1);
            }

            cards[count++] = newCard;
        }

        public void Remove(T card)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                T curr = cards[i];
                if (curr.Equals(card))
                {
                    cards[i] = cards[cards.Length - 1];
                    Array.Resize(ref cards, cards.Length - 1);
                    count--;
                }
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Length / 2; i++)
            {
                Random rand = new Random();
                int randNum = rand.Next(cards.Length / 2, cards.Length);
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
