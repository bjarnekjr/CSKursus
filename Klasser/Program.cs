using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person");

            Person p1 = new Person("Sigurd", "Jensen", 1960);
            String navn = p1.FuldtNavn();
            int alder = p1.Alder();
            Console.WriteLine(navn + " " + alder.ToString());

        }
    }

    class Person
    {
        public String Fornavn;
        public String Efternavn;
        public int Fødselsår;

        public String FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;        
        }
        public int Alder()
        {
            
            int aar = DateTime.Now.Year;
            return aar - this.Fødselsår;
        }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }
        public Person(String fnavn,String enavn, int faar)
        {
            if (fnavn == null)
                Fornavn = "";
            else Fornavn = fnavn;
            if (enavn == null)
                Efternavn = "";
            else Efternavn = enavn;
            
        }
    }
}
