using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Deck<T> : IEnumerable<T>
    {
        int topCard;
        T[] deck = new T[8];

        /// <summary>
        /// This will add an item to the collection
        /// </summary>
        /// <param name="card">item to be added</param>
        public void Add(T card)
        {
            if (deck.Length == topCard)
            {
                Array.Resize(ref deck, deck.Length * 2);
            }
            deck[topCard++] = card;
        }

        /// <summary>
        /// This enables a clunky form of accessing indexed values
        /// </summary>
        /// <param name="index">Index to access in the collection</param>
        /// <returns>value at that index in the deck</returns>
        public T AtIndex (int index)
        {
            return deck[index];
        }

        /// <summary>
        /// Removes an item from the end (highest index) of the collection
        /// </summary>
        /// <returns>the item removed</returns>
        public T Remove()
        {
            if (deck.Length < topCard / 3)
            {
                Array.Resize(ref deck, deck.Length / 2);
            }
            T temp = deck[--topCard];
            deck[topCard] = default(T);
            return temp;
        }

        /// <summary>
        /// allows foreach to function
        /// </summary>
        /// <returns> indexes</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < topCard; i++)
            {
                yield return deck[i];
            }
        }

        // magic don't touch
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Shuffles a deck, randomizing the order of the elements in the deck.
        /// </summary>
        public void Shuffle()
        {
            for (int i = 0; i < topCard; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, topCard);
                T temp = deck[i];
                deck[i] = deck[num];
                deck[num] = temp;
            }
        }

    }
}
