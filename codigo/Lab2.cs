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
