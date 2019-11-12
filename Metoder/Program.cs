using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string testfil = @"c:\temp\test.txt";
            testmet1(testfil);
            testmet2(testfil);

            static void testmet1(string sti)
            {
                bool findes = System.IO.File.Exists(sti);
                if (findes)
                {
                    string filetext = System.IO.File.ReadAllText(sti);
                    Console.WriteLine(filetext);
                }
                else
                    Console.WriteLine($"Testfil {sti} findes ikke");
            }


            static void testmet2(string sti)
            {
                var fil = new System.IO.FileInfo(sti);
                DateTime d = new DateTime();
                    
                d = fil.LastAccessTime;
                Console.WriteLine(fil.DirectoryName + " " + fil.Extension);
                Console.WriteLine(d);


            }

        }
    }
}
