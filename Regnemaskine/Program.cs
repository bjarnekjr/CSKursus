using System;

namespace Regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indatst et tal");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indatst et andet tal");
            string tal2 = Console.ReadLine();
            Double res;
            Double tal2d = System.Convert.ToDouble(tal2);


            res = System.Convert.ToDouble(tal1) + tal2d;
            Console.WriteLine(res.ToString("N2"));

            //System.DateTime d;
            

        }
    }
}
