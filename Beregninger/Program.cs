using System;

namespace Beregninger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beregninger");
            int i = Beregninger.Laegsammen(2, 3);
            Console.WriteLine(i);
            i = Beregninger.Traekfra(5, 7);
            Console.WriteLine(i);
        }
    }
}
