using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ig = 0, Dif = 0;
            string Arquivo, Texto;

            StreamReader ARQ = new StreamReader("C:\\AED\\Arq1.txt");
            Arquivo = ARQ.ReadLine();

            Console.WriteLine("Escreva...");
            Texto = Console.ReadLine();

            ARQ.Close();

            foreach (char line in Arquivo)
            {
                if (Texto == Arquivo)
                {
                    Ig++;
                }
                Dif++;
            }
            Console.WriteLine("Iguais {0}", Ig);
            Console.WriteLine("Diferentes {0}", Dif);
        }
    }
}
