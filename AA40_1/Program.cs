using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA40_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);


            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }


    }
}
