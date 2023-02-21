using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
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

            string nome, corte, letras, nome_s;

            Console.Write("Escreva o seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("");
            nome_s = nome.Trim();
            letras = nome.Replace("a", "o");
            corte = nome_s.Substring(5, 10);

            int i = nome.IndexOf(" ");

            string NomeP = nome.Substring(0, i);
            Console.WriteLine("Nome: " + NomeP);
            string Sobrenome = nome.Substring(i + 1);
            Console.WriteLine("Sobrenome: " + Sobrenome);

            Console.WriteLine("");

            Console.WriteLine("String de 5 a 10: " + corte);

            Console.WriteLine("");

            Console.WriteLine("Substituição de Caracteres: " + letras );

            Console.WriteLine("");

            Console.WriteLine("Aperte uma tecla para sair...");
            Console.ReadKey();


        }
    }
}
