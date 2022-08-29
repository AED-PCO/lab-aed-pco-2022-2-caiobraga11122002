//Faça um programa que chame uma função capaz de x ^ y usando parametros como referência  

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