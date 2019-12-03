using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Peter";
            p.Efternavn = "Hansen";
            Console.WriteLine(p.FuldtNavn());
            Elev e = new Elev();
            e.Klasselokale = 27;
            e.Fornavn = "F";
            e.Efternavn = "E";
            Console.WriteLine($"Navn {e.FuldtNavn()}, K {e.Klasselokale}");
            Instruktør i = new Instruktør { Fornavn = "i forn", Efternavn = "i efter", NøgleId = 42 };
            Console.WriteLine($"Navn {i.FuldtNavn()}, N {i.NøgleId}");
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
        }   
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + Efternavn;
        }

    }

    class Elev : Person
    {
        public int Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }

    class UdvidetRandom : System.Random
    {
        
      
        public bool NextBool()
        {
            return Next(1, 1002) < 501;
      //      int i = Next(1, 1002);
      //      if (i <= 501)
      //          return true;
      //      else
      //          return false;
        }
    }
}
