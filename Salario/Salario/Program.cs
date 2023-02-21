using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LAYOUT - FATEC";
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.Clear();

            Console.SetCursorPosition(30, 5);
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("╚══════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(32, 6);
            Console.WriteLine("(c)Raziel, 2022");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(32, 7);
            Console.Write("Digite o salário minímo atual: ");
            Console.ForegroundColor = ConsoleColor.White;
            double salmin = Convert.ToDouble(Console.ReadLine());

            Console.SetCursorPosition(32, 8);
            Console.Write("Digite o seu salário: ");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(35, 10);
            double soma;

            soma = (sal / salmin);


            Console.Write("Você recebe " + soma);
            Console.Write(" salários minimos.");

                Console.ReadKey();

            }
        }
    }

