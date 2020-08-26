using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Vill du skriva i ditt namn? (y/n)?");
            var key = Console.ReadKey();

            if (key.KeyChar == 'n') return;

            Console.WriteLine("Skriv in ditt namn ");
            var name = Console.ReadLine();

            Console.WriteLine(" Hej på dig " + name);
            Console.ReadKey();
        }
    }
}
