using System;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "guld";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("Bronze", 10);
            Console.WriteLine(v2.PrisMedMoms());
        }
    }

    class Vare
    {
        private string _navn ;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value;
                Console.WriteLine("Varenavn sat til: "+ _navn);
            }
        }

        private double _pris;

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
