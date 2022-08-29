//Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro

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