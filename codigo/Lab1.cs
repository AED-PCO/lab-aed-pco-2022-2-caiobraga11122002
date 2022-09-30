Atividade 1

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


Atividade 2

using System;

namespace MyApp
{
    internal class Program
    {

        static void ValidaPrimo(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Não é primo");
                    i = n;
                }
                else
                {
                    Console.WriteLine("é primo");
                    i = n;
                }
            }
        }

        static void NumeroPerfeito()
        {
            int Soma = 0;

            for (int i = 1; i <= 1000; i++)
            {
                for (int N = 1; N <= i; N++)

                    if (N % i == 0)
                    {
                        Soma = Soma + i;

                        if (N == Soma)
                        {
                            Console.Write($"{N} ");
                            Soma = 0;

                        }
                    }
            }

        }

        static void Main(string[] args)
        {

            int n;
            Console.Write("Escreva N: ");
            n = int.Parse(Console.ReadLine());

            ValidaPrimo(n);

            NumeroPerfeito();

            Console.ReadKey();
        }
    }
}

Atividade 3

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

Atividade 4

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

Atividade 5

using System;

class Program
{

    static void Fat(int N)
    {

        int Resultado = N;

        for (int i = N - 1; i >= 1; i--)
        {
            Resultado = Resultado * i;
        }
        Console.Write($"O fatorial de {N} é {Resultado}");
    }

    public static void Main(string[] args)
    {

        int N;
        Console.Write("Qual o valor de N: ");
        N = int.Parse(Console.ReadLine());

        Fat(N);

        Console.ReadKey();
    }
}

Atividade 6

using System;

class Program
{
    static void Elevado(int x, int y)
    {

        int ValY = y;

        int resultado = x;

        do
        {

            resultado *= x;
            y--;

        } while (y != 1);

        Console.Write($"Resultado de {x} ^ {ValY} = {resultado}");

    }

    public static void Main(string[] args)
    {

        int X, Y;

        Console.Write("Qual o valor de X: ");
        X = int.Parse(Console.ReadLine());

        Console.Write("Qual o valor de y: ");
        Y = int.Parse(Console.ReadLine());

        Elevado(X, Y);

        Console.ReadKey();
    }
}
