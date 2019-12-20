using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa40_2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);
            DateTime d2 = DateTime.Now;
            DateTime d3 = d2.AddDays(10);
            TimeSpan a = d2-d3;
            Console.WriteLine(a.Days);
            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(t3);
            TimeSpan t4 = t2 - t3;
            Console.WriteLine(t4);
            TimeSpan t5 = t2 + t3;
            Console.WriteLine(t5);



            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
