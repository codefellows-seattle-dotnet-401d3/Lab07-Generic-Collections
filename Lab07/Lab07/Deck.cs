using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0; //Total items in the array.Used for length

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item; //Add an item to the index at count and then increment
        }

        public void Remove(T targetItem)
        {
            int targetIndex = Array.IndexOf(items, targetItem); //find the index of the item.
            for (int i = 0; i < items.Length; i++)
            {
                if (i < targetIndex) //Up to the target index is copied
                {
                    items[i] = items[i];
                }
                else //The rest of the array is shifted over one
                {
                    items[i] = items[i + 1];
                }
            }
            count--; //Dccriment our length
            if (items.Length > count * 2) //If our Actual length is more than double our precived length shrink the array
            {
                T[] temp = new T[count + 10];
                for (int i = 0; i <= count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp; //temp becomes items
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            T[] temp = new T[count];
            int tempCount = count;
            for (int i = 0; i <= count; i++)
            {
                int targetIndex = rand.Next(0, tempCount); //Find index between 0 and collection length
                temp[i] = items[targetIndex]; //Add that to the new array
                //Pull that index from the list so we don't get it again
                for (int k = 0; k < tempCount-1; k++)
                {
                    if (i < targetIndex) //Up to the target index is copied
                    {
                        items[k] = items[k];
                    }
                    else //The rest of the array is shifted over one
                    {
                        items[k] = items[k + 1];
                    }
                }
                tempCount--;
            }
            items = temp; //Items gets the shuffled array
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); //Zombie code required for the interface
        }
    }
}
