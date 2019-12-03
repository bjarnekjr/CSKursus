using System;
using System.Collections.Generic;

namespace ArvDyr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dyr> d = new List<Dyr>();
            d.Add(new Hund() { Navn = "Fido" });
            d.Add(new Hund() { Navn = "Olfert" });
            d.Add(new Kat() { Navn = "Mis" });
            d.Add(new Hund() { Navn = "Z" });
            d.Add(new Kat() { Navn = "Misser" });
            foreach( Dyr dl in d)
            {
                dl.SigNoget();
            }
            Dyr dyr = new Dyr();
            

        }
    }
    class Dyr
    {
        private static System.Random rnd = new Random();
        public string Navn { get; set; }
        public virtual void SigNoget()
        { }
        public static Dyr TilfældigtDyr()
        {

            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }

    }
    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}");
        }
    }
    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {Navn}");
        }
    }
}
