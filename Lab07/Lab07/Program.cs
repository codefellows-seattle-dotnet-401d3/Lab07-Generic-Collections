using System;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<int> temp = new Deck<int>();
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);
            temp.Add(1);

            //Console.WriteLine(temp[16]);
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }
}
