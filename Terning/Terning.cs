using System;
using System.Collections.Generic;
using System.Text;

namespace TerningSpil

{
    class Terning
    {
        public int vaerdi;
        private bool snyd;
        private static Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine(vaerdi);
        }

        public void Ryst()
        {
            if (snyd)
               vaerdi = 6;
            else
               vaerdi = rnd.Next(1, 7);
            
        }

        public Terning()
        {
            vaerdi = 1;
            snyd = false;
        }

        public Terning(bool snyd)
        {
            
            this.snyd = snyd;
            Ryst();
        }

    }
}
