using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplo_II__23_03_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            // O seu programa começa aqui

            string nome, nome_ma, nome_mi, corte, troca, nome_s;
            int pos;
            Console.WriteLine("(c)Raziel, 2022");
            Console.WriteLine("");
            Console.Write("Escreva um nome aqui: ");
            // Lê o nome provido pelo usuario
            nome = Console.ReadLine();
            //corta os espaços 
            nome_s = nome.Trim();
            //converte pra MAIUSCULO.
            nome_ma = nome_s.ToUpper();
            //CONVERTE PARA minusculo.
            nome_mi = nome_s.ToLower();
            //define a posição do A(?)
            pos = nome_s.IndexOf("a");
            //ignora os primeiros 5 caracteres enquanto imprime os proximos cinco.
            corte = nome_s.Substring(5, 5);
            //substitui a letra A pela letra O
            troca = nome_s.Replace("a", "o");
            //escreve o nome em MAIUSCULO.
            Console.WriteLine("");
            Console.WriteLine("Nome em maiúsculo: " + nome_ma);
            //escreve o nome em MINUSCULO.
            Console.WriteLine("");
            Console.WriteLine("Nome em minúsculo: " + nome_mi);
            //escreve a posição de a
            Console.WriteLine("");
            Console.WriteLine("Posição de a: " + pos);
            //escreve o nome cortado a exemplo da variavel substring
            Console.WriteLine("");
            Console.WriteLine("Nome cortado: " + corte);
            //troca o A por O
            Console.WriteLine("");
            Console.WriteLine("Troca 'a' por 'o': " + troca);
            //tira o espaço do inicio e fim
            Console.WriteLine("");
            Console.WriteLine("Tira espaço do início e do fim: " + nome_s);
            Console.WriteLine("");
            Console.WriteLine("Aperte uma tecla para sair...");
            Console.ReadKey();

            // Aqui termina o seu programa

        }
    }
}
