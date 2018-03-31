using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


//Systems.collections.Generic imports libary
namespace CardDeck
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] cards = new T[2];
        int count = 0;

       // add method to create a card <T>
        public void Add(T newCard)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }

            cards[count++] = newCard;
        }

        // returng the lenght of the array
        public int Length()
        {
            return count;
        }

        // Method to remove the card
        public T Remove()
        {
            Array.Resize(ref cards, cards.Length - 1);
            T deck = cards[--count];
            return deck;
        }

        // Method to shuffle the card
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

      //method to get a recieve the cards
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

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
