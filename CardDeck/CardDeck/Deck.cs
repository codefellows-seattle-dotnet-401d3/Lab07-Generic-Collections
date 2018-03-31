using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Deck
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //EnumExample();
            DeckExample();

       
        }


        static void DeckExample()
        {
            List<string> myList = new List<string>();
            myList.Add("Ace of Hearts");
            myList.Add("Two of Hearts");
            myList.Add("Three of Hearts");
            myList.Add("Four of Hearts");
            myList.Add("Five of Hearts");
            myList.Add("Six of Hearts");


        }

    }
}
