using System;

namespace TerningSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terning");
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Terning t3 = new Terning(false);
            t3.Skriv();
            t3.Ryst();
            t3.Skriv();
        }
    }

 
}
