//Erro na hora da troca.

namespace lab8_fila
{
    internal class Program
    {
        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }

        static int[] InserirFila(int[] Vetor, int pos)
        {
            Console.Write("inserir: ");
            int n = int.Parse(Console.ReadLine());

            Vetor[pos] = n;
            return Vetor;
        }

        static int[] InserirPilha(int[] Vetor)
        {
            int[] pilha = new int[Vetor.Length];

            int pos = Vetor[0];
            int aux = 0;
            int posPilha = pilha.Length;


            for (int j =0; j > Vetor.Length; j++)
            {
                aux = pos;
                pos++;

                posPilha = aux;
                posPilha--;

                pilha[posPilha] = aux;
            }
            return pilha;
        }

        static void Main(string[] args)
        {
            int Pos = 0;
            int[] V = new int[2];
            int[] VTrocado = new int[V.Length];

            for (int j = 0; j < V.Length; j++)
            {
                if (Pos < V.Length)
                {
                    InserirFila(V, Pos);
                    Pos += 1;
                }
            }

            Console.Write("Fila: ");
            MostraVetor(V);

            VTrocado = InserirPilha(V);

            MostraVetor(VTrocado);

            Console.ReadKey();
        }
    }
}
