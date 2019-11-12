using System;

namespace Fejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;            
            try
            {
                //Run();
                prøvIgen();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
              
            }
        }

        private static void prøvIgen()
        {

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Run();
                    break;
                }
                catch (Exception ex)
                {
                    if(i<3)
                    Console.WriteLine("forkert format, prøv igen");
                    else
                    {
                        Console.WriteLine("For mange forsøg");
                        throw new ApplicationException();
                    }
                } 
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
    }
}
