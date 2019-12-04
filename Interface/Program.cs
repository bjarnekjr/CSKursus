using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDbFunktioner> list = new List<IDbFunktioner>();
            list.Add(new Hund() { Navn = "Fido" });
            list.Add(new Ubåd());
            list.Add(new Hund());
            foreach(var item in list)
            {
                item.Gem();
            }
        }
    }

    interface IDbFunktioner
    {
        public void Gem();
    }
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund der hedder "+Navn);
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd");
        }
    }
}
