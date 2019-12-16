using System;
using System.Collections.Generic;

namespace Lamba1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            //   Console.WriteLine(a.FindIndex(Find));
            //  Console.WriteLine(a.FindIndex((i) => { return i == 51; }));
            //ListVærdi(a);
            a.ForEach(i => { Console.WriteLine(i); });
        }

        //      static bool Find(int i)
        //      {
        //          return i == 51;
        //      }
        static void ListVærdi(List<int> a)
        {
            foreach (int x in a)
            Console.WriteLine(x);
        }
    }
}
