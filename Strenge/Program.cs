using System;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string forNavn = "Mikkel";
            string efterNavn = "Cronberg";
            string samletNavn = forNavn + " " + efterNavn;
            Console.WriteLine(samletNavn);
            Console.WriteLine($"navn {samletNavn.ToUpper()}");
            string sti = "C:\\kursus\\cskursus\\n.txt";
            System.IO.File.WriteAllText(sti, samletNavn);

        }
    }
}
