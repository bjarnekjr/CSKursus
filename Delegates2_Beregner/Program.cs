using System;

namespace Delegates2_Beregner
{
    public delegate int BeregnDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {

            int res = Beregner(2, 2, Plus);
            Console.WriteLine(res);
            res = Beregner(2,0,Divider);
            Console.WriteLine(res);
            BeregnDelegate f1 = TilfaeldigFunktion();
            res = f1(3, 4);
            Console.WriteLine(res);
            
        }

        public static int Beregner(int x, int y, BeregnDelegate regneMetode)
        {
            return regneMetode(x, y);            
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            if (b == 0)
                return -9999;
            else
               return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static BeregnDelegate TilfaeldigFunktion()
        {
            if (System.DateTime.Now.Millisecond < 250)
                return Plus;
            if (System.DateTime.Now.Millisecond >= 250 || System.DateTime.Now.Millisecond <= 500)
                return Minus;
            return Gange;

        }
        
    }
}
