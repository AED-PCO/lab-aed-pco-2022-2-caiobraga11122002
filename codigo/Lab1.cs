/*Escreva 5034 e devolva 50 34*/

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, Resultado, Resultado2;

            Console.Write("Qual o valor de N: ");
            N = int.Parse(Console.ReadLine());

            Resultado = N / 100;

            Resultado2 = N % 100;

            Console.WriteLine($"O resultado de {N} é {Resultado} e {Resultado2}");

            Console.ReadLine();
        }
    }
}
