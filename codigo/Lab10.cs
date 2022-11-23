//.....................................................................................................................FILA
using PosicaoFila;//MAIN
using FilaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Op;
            int Val;

            Posicao Pos = new Posicao();

            do
            {
                Console.Write("Programa de Fila:\n 1 -> Inserir\n 2 -> Remover\n 3 -> Mostrar\n");


                Op = Console.ReadLine();

                switch (Op)
                {
                    case "1":
                        Console.Write("Qual será inserido: ");
                        Val = int.Parse(Console.ReadLine());
                        Fila.Inserir(Val);
                        break;
                    case "2":
                        Console.WriteLine("Elemento removido:" + Fila.Remover());
                        Console.ReadKey();
                        break;
                    case "3":
                        Fila.mostrar();
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (Op != "9");
        }
    }
}

//.....................................................................................................................PILHA

using PosicaoFila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaClasse
{
    internal class Fila
    {
        public static Posicao Inicio = new Posicao();
        public static Posicao Fim = Inicio;

        Posicao PosicaoFila = new Posicao();

        public Fila()
        {
            Inicio = new Posicao();
            Fim = Inicio;
        }

        public static void Inserir(int Numero)
        {
            Posicao NovaPosicao = new Posicao();
            NovaPosicao.Elemento = Numero;

            Fim.Ponteiro = NovaPosicao;
            Fim = NovaPosicao;
        }

        public static void mostrar()
        {
            Posicao x = Inicio.Ponteiro;

            Console.Write("Sua fila:");
            do
            {
                Console.Write(x.Elemento + " ");
                x = x.Ponteiro;

            } while (x != null);
          }

        public static int Remover()
        {
            if (Inicio == Fim)
            {
                return 0;
            }
            else
            {
                Inicio = Inicio.Ponteiro;
                int Remover = Inicio.Elemento;
                return Remover;
            }
        }
    }
}

//CLASSE POSIçÂO

using System;
using FilaClasse;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicaoFila
{
    internal class Posicao
    {
        public int Elemento;
        public Posicao Ponteiro;

        public Posicao()
        {
            this.Elemento = 0;
        }

        public Posicao(int elemento)
        {
            this.Elemento = elemento;
        }
    }
}
