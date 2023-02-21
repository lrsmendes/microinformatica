using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Email
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

            string nome, fatec, email;

            fatec = ("@fatec.sp.gov.br");

            Console.Write("Escreva o seu nome de usuário: ");
            nome = Console.ReadLine();
            Console.WriteLine("");

            email = nome.Replace(" ", "");
            email = email.ToLower(); 

            Console.Write("O seu email é: " + email + fatec);

            
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Aperte uma tecla para sair...");
            Console.ReadKey();

        }
    }
}
