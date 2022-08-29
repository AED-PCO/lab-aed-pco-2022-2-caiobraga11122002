
/*Soma linhas das Matrizes*/

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void MostraMatriz(int[,] M)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{M[i, j]} ");
                }
            }
        }

        static void SomaMatriz(int[,] M)
        {
            int Soma= 0;

            for (int i = 0; i < 3; i++)
            {
                Soma = 0;
                Console.WriteLine("\n");

                for (int j = 0; j < 3; j++)
                {
                    Soma = Soma + M[i, j]; 
                }
                Console.WriteLine(Soma);
            }
            
        }
        static void Main(string[] args)
        {
            int[,] M;

            Random x = new Random();    

            M = new int[3, 3];

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    M[i, j] = x.Next(1, 100);
                }
            }

            MostraMatriz(M);

            SomaMatriz(M);

            Console.ReadLine();
        }
    }
}