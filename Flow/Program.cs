using System;

namespace Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j < 11; j++)
            {
                
                for (int i = 1; i < 11; i++)
                {
                    int y = j * i;
                    if (y>=50)
                        Console.ForegroundColor = ConsoleColor.Red;                    
                    Console.Write(y.ToString().PadLeft(4));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }
    }
}
