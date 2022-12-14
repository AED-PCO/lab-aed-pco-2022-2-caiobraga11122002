Atividade 1-

using System;

class Program
{
    static int FatrialRecursivo(int N)
    {
        if (N <= 0)
        {
            return 1;
        }
        else
        {
            return N * FatrialRecursivo(N - 1);
        }
    }

    public static void Main(string[] args)
    {

        int N, Resultado;

        Console.Write("Qual o valor de N: ");
        N = int.Parse(Console.ReadLine());

        Resultado = FatrialRecursivo(N);
        Console.Write($"Resultado: {Resultado} ");

        Console.ReadKey();
    }
}


Atividade 2-(Corrigir)
    
    using System;

class Program
{
    static int MultiplicacaoRecursiva(int N, int N2)
    {
        int Resultado = 0;

        if (N == 0 || N2 == 0)
        {
            return 1;
        }

        if (N2 >= 0)
        {
            return Resultado = N + MultiplicacaoRecursiva(N, N2--);
        }
        else
        {
            return Resultado;
        }

    }

    public static void Main(string[] args)
    {

        int N, N2, Resultado;

        Console.Write("Qual o valor de N: ");
        N = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.Write("Qual o valor de N2: ");
        N2 = int.Parse(Console.ReadLine());


        Resultado = MultiplicacaoRecursiva(N, N2);

        Console.Write($"Resultado: {Resultado} ");

        Console.ReadKey();
    }
}

Atividade 3 - 
    
    namespace ConsoleApp5
{
    internal class Program
    {
        static int ElevevadoRecursivo(int A, int B)
        {
            if ((B == 1 || A == 1))
            {
                return A;
            }
            return A * ElevevadoRecursivo(A, B - 1);
        }
        static void Main(string[] args)
        {
            int A, B, total;
            Console.WriteLine("Qual o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de B: ");
            B = int.Parse(Console.ReadLine());

            total = ElevevadoRecursivo(A, B);

            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}

Atividade 4-
    
    namespace lab2_fra
{
    internal class Program
    {
        static int Frase(string frase, char letra)
        {
            if (frase == "")
            {
                return (0);
            }
            else if (frase[0] == letra)
            {
                return Frase(frase.Substring(1), letra) + 1;
            }
            else
                return Frase(frase.Substring(1), letra);
        }
        static void Main(string[] args)
        {


            string Frase1 = ("a ana e linda");
            char letra;

            Console.WriteLine("Letra:");
            letra = char.Parse(Console.ReadLine());

            int n = Frase(Frase1, letra);

            Console.WriteLine($"Frase {Frase1} possui {n} quantidades de letras {letra}");
        }
    }
}


Atividade 5 - (Falhas)
    
    /* Escreva um m??todo recursivo que calcule a 
soma dos elementos de valor par de um 
vetor de numeros inteiros positivos.*/

/* Escreva um m??todo recursivo que calcule a 
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
            int Soma = 0;

            if(i ==0)
          {
                return 0;
            }
            else
                return V[i - 1] + SomaPares(V, i - 1);
        }

        static void Main(string[] args)
        {
            int[] V = new int[5];

            int[] v = new int[5];

            Random x = new Random();

            for (int i = 0; i < 5; i++)
            {
                V[i] = x.Next(1, 100);

                if (V[i] % 2 == 0)
                {
                    v[i] = V[i];
                }
            }

            MostraVetor(V);

            Console.WriteLine("");

            Console.WriteLine($"{SomaPares(v, 5)} ");

            Console.ReadKey();
        }
    }
}

Atividade 6 (A FAZER)
