using System;

namespace PolymorfTerning
{
    class Terning
    {
        public Terning()
        {
            Ryst();
        }
        public Terning(int vaerdi)
        {
            this.Vaerdi = vaerdi;
        }
        private int _vaerdi;
        private static Random _rnd = new Random();
        public int Vaerdi
        {
            get { return this._vaerdi; }
            set
            {
                 if (value < 0 || value > 6)
                    this._vaerdi = 1;
                else
                    this._vaerdi = value;
                Console.WriteLine("Værdi sat " + this.Vaerdi);
            }
        }

        public void Ryst()
        {
            this._vaerdi = _rnd.Next(1, 7);

        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Vaerdi + "]");
        }

    }
}
