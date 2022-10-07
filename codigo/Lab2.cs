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


Atividade 2-
    
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

        Console.WriteLine("X");

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
