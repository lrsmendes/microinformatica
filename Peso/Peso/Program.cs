using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LAYOUT - FATEC";
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.Clear();

            Console.SetCursorPosition(10, 5);
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("║                                                  ║");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("║                                                  ║");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("║                                                  ║");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("║                                                  ║");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("║                                                  ║");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("╚══════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(12, 6);
            Console.WriteLine("(c)Raziel, 2022");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(12, 7);
            Console.Write("Digite o seu peso: ");
            Console.ForegroundColor = ConsoleColor.White;
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(12, 9);
            Console.WriteLine("Peso em gramas: " + (peso * 1000) +"g.");
            Console.SetCursorPosition(12, 10);
            Console.WriteLine("Peso com acréscimo: " + (peso * 1.10) +"kg.");
            Console.ReadKey();
        }
    }
}
