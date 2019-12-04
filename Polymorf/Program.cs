using System;

namespace Polymorf
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura() { Nr = 1, Dato = DateTime.Now, Kunde = "Sigurd" }; ;
            Console.WriteLine(f.ToString());
        }
    class Faktura
        {
            public int Nr { get; set; }
            public DateTime Dato { get; set; }
            public string Kunde { get; set; }

            public override string ToString()
            {
                return ($"Faktura til { Kunde} FaktNr { Nr} fra { Dato}");
            }
        }
    }
}
