Atividade Busca Binária.

using System;

namespace CaioBragaBUSCA 
{
    class Program
    {
        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }

        static int buscaBinaria(int[] V, int N, int In, int Fim)
        {
            int Meio = (Fim + In) / 2;

            if (Fim < 0)
            {
                return 0;
            }
            if (V[Meio] < N)
            {
                return buscaBinaria(V, N, (Meio + 1), In);
            }
            else if (V[Meio] > N)
            {
                return buscaBinaria(V, N, In, (Meio - 1));
            }                
            else
                return Meio;

        }

        static void Main(string[] args)
        {
            int[] V = {5, 10, 33 , 52, 90, 101, 303, 500, 503};
            int N, Resultado;

            MostraVetor(V);

            Console.WriteLine("");

            Console.WriteLine("Busca:");
            N = int.Parse(Console.ReadLine());

            Resultado = buscaBinaria(V, N, 0, (V.Length - 1));

           Console.WriteLine($"O número {N} está na posição {Resultado+1} do vetor.");
        }
    }
}
