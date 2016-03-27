using System;

namespace BlackJack6
{
    static class Display
    {
        public static void PrintStartTitle()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("-------------Black Jack-------------------");
            Console.WriteLine("------------------------------------------");
        }

        public static void PrintHeader(string title)
        {
            Console.WriteLine();
            Console.WriteLine($"------------{title}------------");
            Console.WriteLine();
        }
    }
}