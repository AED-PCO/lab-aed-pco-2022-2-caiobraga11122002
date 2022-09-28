using System;

namespace MyApp
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

        static void ComparaVetorSemelhante(int[] A, int[] B)
        {
            int[] C = new int[A.Length];

             for(int i = 0; i < A.Length;i++)
            {
                for(int j = 0; j < B.Length; j++)
                {
                    if(A[i] == B[j])
                    {
                        C[i] = A[i];
                        Console.Write($"{C[i]}, ");
                    }
                }
            }

        }

        static void ComparaVetorDiferente(int[] A, int[] B)
        {
            int[] D = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] != B[j])
                    {
                        D[i] = A[i];
                        Console.Write($"{D[i]}, ");
                    }
                }
            }

        }
        static void Main(string[] args)
        {

            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
            int[] D = new int[5];

            int N;

            for(int i = 0; i<5; i++)
            {
                Console.Write("Preencha A: ");
                N = int.Parse(Console.ReadLine());

                A[i] = N;
            }

            Console.WriteLine("   ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Preencha B: ");
                N = int.Parse(Console.ReadLine());

                B[i] = N;
            }

            Console.WriteLine(" ");

            Console.WriteLine("Vetor A: ");
            MostraVetor(A);

            Console.WriteLine(" ");

            Console.WriteLine("Vetor B: ");
            MostraVetor(B);

            Console.WriteLine(" ");

            Console.WriteLine("Vetor C: ");
            ComparaVetorSemelhante(A , B);

            Console.WriteLine(" ");

            Console.WriteLine("Vetor D: ");
            ComparaVetorDiferente(A, B);

        }
    }
}
