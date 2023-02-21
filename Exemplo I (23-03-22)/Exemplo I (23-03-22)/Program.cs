using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplo_I__23_03_22_
{
    class Program
    {
        static void Main(string[] args)
        {
            // O seu programa começa aqui

            double a, b, c, d;
            Console.WriteLine("(c)Raziel, 2022");
            Console.WriteLine("");
            Console.Write("Escreva um número: ");

            // Converte a função ReadLine para Double (se fosse string, seria Convert.ToString) assim permitindo ao usuario definir a variavel A. 

            a = Convert.ToDouble(Console.ReadLine());

            // Essencialmente diz que a variavel B é igual a raiz quadrada de A.

            b = Math.Sqrt(a);

            // Diz que C é a raiz quadrada de A. 

            c = Math.Pow(a, 2);
            Console.WriteLine("");
            Console.WriteLine("A sua raiz é: " + b);
            // o + B imprime o valor de B no console, assim permitindo a sua leitura.

            Console.WriteLine("");
            // essa linha faz isso para o valor de C.


            Console.WriteLine("O seu número vezes ele mesmo é: " + c);

            d = Math.Round(b);
            Console.WriteLine("");
            Console.WriteLine("O seu numero arrendondado é: " + d);
            // arredonda o valor de B.
            Console.WriteLine("");
            Console.WriteLine("Aperte uma tecla para sair...");
            Console.ReadKey();

            // Aqui termina o seu programa
        }
    }
}
