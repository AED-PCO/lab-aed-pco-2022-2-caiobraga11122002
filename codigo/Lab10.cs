//.....................................................................................................................MAIN FILA
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

//.....................................................................................................................CLASSE FILA 

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

//.....................................................................................................................CLASSE POSICAO 

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

//.......................................................................................................................MAIN PILHA
using PosicaoPilha;//MAIN
using PilhaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePilha
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
                Console.Write("Programa de Pilha:\n 1 -> Inserir\n 2 -> Remover\n 3 -> Mostrar\n");


                Op = Console.ReadLine();

                switch (Op)
                {
                    case "1":
                        Console.Write("Qual será inserido: ");
                        Val = int.Parse(Console.ReadLine());
                        Pilha.Inserir(Val);
                        break;
                    case "2":
                        Console.WriteLine("Elemento removido:" + Pilha.Remover());
                        Console.ReadKey();
                        break;
                    case "3":
                        Pilha.mostrar();
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (Op != "9");
        }
    }
}


//.......................................................................................................................CLASSE PILHA

using PosicaoPilha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaClasse
{
    internal class Pilha
    {
        public static Posicao Inicio = new Posicao();
        public static Posicao Fim = Inicio;
        Posicao PosicaoPilha = new Posicao();

        public Pilha()
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
                return 0;

            int Remover = Fim.Elemento;
            Posicao In = Inicio;


            while (In.Ponteiro != Fim)
            {
                In = In.Ponteiro;
            }

            Fim = In;
            Fim.Ponteiro = null;

            return Remover;
        }
    }
}

//.......................................................................................................................CLASSE PONTEIRO


using System;
using PilhaClasse;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicaoPilha
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

//.......................................................................................................................MAIN LISTA

using PosicaoLista;//MAIN
using ListaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePilha
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
                Console.Write("Programa de Lista:\n 1 -> Inserir\n 2 -> Remover\n 3 -> Mostrar\n");


                Op = Console.ReadLine();

                switch (Op)
                {
                    case "1":
                        Console.Write("Qual será inserido: ");
                        Val = int.Parse(Console.ReadLine());
                        Lista.Inserir(Val);
                        break;
                    case "2":
                        Lista.Remover();
                        Console.ReadKey();
                        break;
                    case "3":
                        Lista.mostrar();
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (Op != "9");
        }
    }
}

//.......................................................................................................................CLASSE LISTA

using PosicaoLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClasse
{
    internal class Lista
    {
        public static Posicao Inicio = new Posicao();
        public static Posicao Fim = Inicio;
        Posicao PosicaoPilha = new Posicao();

        public Lista()
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

            Console.Write("Sua Lista:");
            do
            {
                Console.Write(x.Elemento + " ");
                x = x.Ponteiro;

            } while (x != null);
        }
        public static void Remover()
        {
            int RemoveLista;

            if (Inicio == Fim)
            {
                Console.Write("Vazio");
            }

           else
            {
                Posicao In = Inicio;

                Console.Write("Qual o elemento deseja retirar da Lista: ");
                RemoveLista = int.Parse(Console.ReadLine());

                while (In.Ponteiro != Fim)
                {
                    if(In.Ponteiro.Elemento == RemoveLista)
                    {
                        In.Ponteiro = In.Ponteiro.Ponteiro;
                    }
                    else
                    {
                        In = In.Ponteiro;
                    }
                }
                Console.Write(RemoveLista+" Removido");

            }
        }
    }
}

//.......................................................................................................................CLASSE PONTEIRO

using System;
using ListaClasse;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicaoLista
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

//.......................................................................................................................CALCULADORA 
