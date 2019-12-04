using System;

namespace Terning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Vaerdi = 5;
            t.Skriv();
            
        }
    }

    class Terning
    {
        private int _vaerdi;
        private static Random _rnd = new Random();
        public int Vaerdi
        {
            get { return this._vaerdi; }
            set
            {
                Console.WriteLine("Værdi sættes " + value);
                if (value < 0 || value > 6)
                    this._vaerdi = 1;
                else
                    this._vaerdi = value;
                Console.WriteLine("Værdi sat " + this.Vaerdi);
            }
        }

        public void Ryst()
        {
            this._vaerdi = _rnd.Next(1,7);
            
        }

        public void Skriv()
        {
            Console.WriteLine("["+this.Vaerdi+"]");
        }
        public Terning()
        {
            Ryst();
        }

    }
}
