using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {

            //Look at you tube videos from 3/27/18 end of parts 1 0f 3

            Console.WriteLine("Hello World!");

            enumExample();
            Console.ReadLine();


        }


        // Method that calls Hearts, which is stated in CardDeck.cs.
        // remeber that deal is a local variable which calls 
        static void enumExample()
        {
           // Hearts deal = Hearts.Jack;
            int daynumber = (int)deal;
            Console.WriteLine(daynumber);
        }
    }
}
