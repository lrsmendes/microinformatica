using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circulo
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

            double raio;
            
            Console.Write("Escreva o raio do seu circulo: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("A sua área é: ");
            Console.Write (Math.PI * (Math.Pow (raio, 2)));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("O seu diâmetro é: ");
            Console.Write(raio * 2);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("O seu perímetro é: ");
            Console.Write(2 * Math.PI * raio);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Aperte uma tecla para sair...");
            Console.ReadKey();

        }
    }
}
