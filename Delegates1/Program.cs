using System;

namespace Delegates1
{

    public delegate void MinDelegate1(string t);


    class Program
    {
        static void Main(string[] args)
        {
            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("Test");
            MinDelegate1 f2 = MinSkrivTilConsole;
            f2.Invoke("Test2");
            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("Test3");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }



    }
}
