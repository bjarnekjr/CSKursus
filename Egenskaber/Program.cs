using System;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Vare v = new Vare();
            //  v.Navn = "guld";
            //  v.Pris = 100;
            //  Console.WriteLine(v.PrisMedMoms());
            //  Vare v2 = new Vare("Bronze", 10);
            //  Console.WriteLine(v2.PrisMedMoms());

            Person p = new Person();
            p.Fornavn = "abc";
            p.Efternavn = "qwer";
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(p.Fuldtnavn2);
        }
    }
    class Person
    {
        public string Fornavn { get; set; }

        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set { if (value.Length < 4)
                    _efternavn = "det kan ikke passe med så kort et efternavn";
            else
                _efternavn = value; }
        }

        private string _fuldtnavn2;

        public string Fuldtnavn2
        {
            get { return this.Fornavn + " " + this._efternavn; }
          //  set { _fuldtnavn2 = value; }
        }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }


    }
    class Vare
    {
        private string _navn ;
        private double _pris;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value;
                Console.WriteLine("Varenavn sat til: "+ _navn);
            }
        }
        public double Pris
        {
            get { return _pris; }
            set { if (value < 0)
                    _pris = 0;
                 else
                _pris = value;
                Console.WriteLine("Varepris sat til: " +_pris);
            }
        }

        public double PrisMedMoms()
        {
            return _pris*1.25;
        }

        public Vare()
        { 
        }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;

        }
    }
}
