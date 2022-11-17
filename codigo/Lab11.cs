//.....................................................................................................................FILA
using System;//CLASSE FILA
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    internal class Fila
    {
        const int Capacidade = 5;
        private int quantidade = 0;
        private int inicio = 0;
        private int fim = 0;
        private string[] dados = new string[Capacidade];

        public int tamanho()
        {
            return quantidade;
        }

        public void inserirElemento(string valor_i)
        {
            if(tamanho () == Capacidade)
            {
                throw new Exception("Fila cheia");
            }
            else
            {
                dados[fim] = valor_i;  
                fim = (fim+1) % Capacidade;
                quantidade++;
            }
        }
        public string RemoveElemento()
        {
            if (tamanho() == 0)
            {
                throw new Exception("Fila Vazia");
            }
            else
            {
                String valor = dados[inicio];
                inicio = (inicio +1) % Capacidade;
                quantidade--;
                return valor;
            }
        }
    }
}

using System;//MAIN FILA
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "", valor;

            Fila  minhafila = new Fila();
            Console.WriteLine("Sistemas de Fila");

            do
            {
                try
                {
                    Console.WriteLine("\n1 -> inserir \n2 -> remover \n3 -> mostrar");
                    op = Console.ReadLine();

                    switch (op)
                    {
                        case "1":
                            Console.Write("Qual o elemento para inserir na fila: ");
                            valor = Console.ReadLine();
                            minhafila.inserirElemento(valor);
                            break;

                        case "2":
                            Console.Write("Qual o elemento para Remover na fila: ");
                            valor = Console.ReadLine();
                            minhafila.RemoveElemento();
                            break;

                        case "3":
                            Console.Write("Tamanho da fila: ");
                            minhafila.tamanho();
                            break;

                        default:
                            Console.WriteLine("Opção inválida!!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (op != "9");
        }
    }
}

//.....................................................................................................................PILHA

using System;//CLASSE PILHA
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    internal class Pilha
    {
        const int Capacidade = 5;
        private int quantidade = 0;
        private int inicio = 0;
        private int fim = 0;
        private string[] dados = new string[Capacidade];

        public int tamanho()
        {
            return quantidade;
        }

        public void inserirElemento(string valor_i)
        {
            if (tamanho() == Capacidade)
            {
                throw new Exception("Pilha cheia");
            }
            else
            {
                dados[inicio] = valor_i;
                inicio = (inicio + 1) % Capacidade;
                quantidade++;
            }
        }
        public string RemoveElemento()
        {
            if (tamanho() == 0)
            {
                throw new Exception("Pilha Vazia");
            }
            else
            {
                String valor = dados[fim];
                fim = (fim + 1) % Capacidade;
                quantidade--;
                return valor;
            }
        }
    }
}


using System;//MAIN PILHA
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "", valor;

            Pilha minhaPilha = new Pilha();
            Console.WriteLine("Sistemas de Fila");

            do
            {
                try
                {
                    Console.WriteLine("\n1 -> inserir \n2 -> remover \n3 -> mostrar");
                    op = Console.ReadLine();

                    switch (op)
                    {
                        case "1":
                            Console.Write("Qual o elemento para inserir na fila: ");
                            valor = Console.ReadLine();
                            minhaPilha.inserirElemento(valor);
                            break;

                        case "2":
                            Console.Write("Qual o elemento para Remover na fila: ");
                            valor = Console.ReadLine();
                            minhaPilha.RemoveElemento();
                            break;

                        case "3":
                            Console.Write("Quantidade total de elementos: ");
                            minhaPilha.tamanho();
                            break;

                        default:
                            Console.WriteLine("Opção inválida!!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (op != "9");
        }
    }
}

//.....................................................................................................................LISTA





