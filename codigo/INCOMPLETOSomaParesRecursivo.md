/* Escreva um método recursivo que calcule a 
soma dos elementos de valor par de um 
vetor de numeros inteiros positivos.*/

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }

        }

        static int SomaPares(int[] V, int i)
        {
            int Soma=0;

            if (V[i] % 2 == 0)
            {
                return Soma + SomaPares(V );
            }
            else
                return V[i - 1] + SomaPares(V, i - 1);
        }

        static void Main(string[] args)
        {
            int[] V = new int[5];

            Random x = new Random();

            for (int i = 0; i < 5; i++)
            {
                V[i] = x.Next(1, 100);
            }

            MostraVetor(V);

            Console.WriteLine($"{SomaPares(V, 5)} ");

            Console.ReadKey();
        }
    }
}