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