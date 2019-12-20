using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa40_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal1");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indtast tal2");
            string tal2 = Console.ReadLine();
            double t1 = System.Convert.ToDouble(tal1);
            double t2 = System.Convert.ToDouble(tal2);
            double t3 = t1 + t2;
            Console.WriteLine(t3.ToString("N2"));


            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
