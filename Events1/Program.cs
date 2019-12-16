using System;
using System.IO;

namespace Events1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Created += lyt;
            w.Changed += (s, e) => Console.WriteLine("Ændret"+ e.FullPath);
            w.Renamed += (s, e) => Console.WriteLine("Renamed" + e.OldFullPath + " " + e.FullPath);
            w.Deleted += (s, e) => Console.WriteLine(e.ChangeType + " " + e.FullPath);
            do { } while (true);
        }

        private static void lyt(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Oprettet"+e.ChangeType);
        }
    }
}
