using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
   
            string text = @"
    ____  ___ _____   ____________ 
   / __ \/   /__  /  /  _/ ____/ / 
  / /_/ / /| | / /   / // __/ / /  
 / _, _/ ___ |/ /___/ // /___/ /___
/_/ |_/_/  |_/____/___/_____/_____/                                        
   ___  _______ ___ ___ ___  / /____      
  / _ \/ __/ -_|_-</ -_) _ \/ __(_-<_ _ _ 
 / .__/_/  \__/___/\__/_//_/\__/___(_|_|_)  
/_/(c)Raziel, 2022                                                                                                                                                                                                                                  
";
            Console.Write(text);

            double a,b,c, delta, x1, x2;

            Console.Write("Escreva a primeira parte da equação:");
            Console.WriteLine("");
            Console.Write("A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("C: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine("");
            
            Console.Write("DELTA = " + delta);

            Console.WriteLine("");
            Console.WriteLine("");

            x1 = (-b + Math.Sqrt (delta)) / (2 * a);
            x2 = (-b - Math.Sqrt (delta)) / (2 * a);

            Console.WriteLine("X1 = " + x1);
            Console.WriteLine("X2 = " + x2);



            Console.WriteLine("Aperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
