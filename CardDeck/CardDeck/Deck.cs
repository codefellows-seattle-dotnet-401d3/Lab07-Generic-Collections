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

        /// <summary>
        /// add a new card to the deck.
        /// </summary>
        /// <param name="newCard">card to be added</param>
        public void Add(T newCard)
        {
            if(count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }

            cards[count++] = newCard;
        }

        public int Length()
        {
            return count;
        }

        /// <summary>
        /// removes the last card in the deck
        /// </summary>
        /// <returns>the new deck</returns>
        public T Remove()
        {
            Array.Resize(ref cards, cards.Length - 1);
            T deck = cards[--count];
            return deck;
        }

        /// <summary>
        /// randomly shuffles the deck
        /// </summary>
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

        /// <summary>
        /// gives the ability to use a foreach loop
        /// </summary>
        /// <returns>the cards at each index</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        // I believe this is magic.....
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
