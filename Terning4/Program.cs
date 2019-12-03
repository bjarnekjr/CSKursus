using System;

namespace PolymorfTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Polymorf terning");
            //Terning t = new Terning();
            //t.Skriv();
            //t.Ryst();
            //t.Skriv();
            //t.Vaerdi = 5;
            //t.Skriv();
            LudoTerning ludoTerning = new LudoTerning();
            ludoTerning.Vaerdi = 3;
            ludoTerning.Skriv();
            Console.WriteLine($"LudoTerning værdi { ludoTerning.Vaerdi}");
        }
    }
}
