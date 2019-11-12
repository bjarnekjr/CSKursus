using System;
using System.Collections.Generic;
using System.Text;



namespace VAriabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            Console.WriteLine(--a);
            Console.WriteLine(a += 20); 
            Console.WriteLine($"Heltal = {a}");

            Double b = 12.5;
            Console.WriteLine(b);
            Console.WriteLine(++b);
            b--;
            Console.WriteLine(b);
            Console.WriteLine(b*=2);
            Console.WriteLine(b);

            // Til alle der læser koden...
            // Kulør 0 = Spar
            // Kulør 1 = Hjerter
            // Kulør 2 = Ruder
            // Kulør 3 = Klør

            int kort1Værdi = 2;
            Kortfarve kortf = Kortfarve.Spar;
            Console.WriteLine();

            int kort2Værdi = 2;
            int kort2Kulør = 2;

        }
    }
}
