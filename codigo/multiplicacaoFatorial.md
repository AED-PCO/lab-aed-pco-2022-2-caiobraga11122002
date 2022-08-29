/*Uma multiplicação pode ser vista como uma 
sequência de somas. Escreva um método 
recursivo que realize a multiplicação de dois 
números inteiros, A e B, recebidos por 
parâmetro. */

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