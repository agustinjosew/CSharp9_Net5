using System;

namespace CH2_SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My rocking APP";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("***** WELCOME TO MY ROCKING APP *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            _ = Console.ReadLine();
            
        }
    }
}
