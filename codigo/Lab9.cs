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

        static int[] InserirPilha(int[] Vetor, int tam)
        {
            int[] pilha = new int[tam];

            for (int j = 0; j < tam; j++)
            {
                for(int i = tam-1; i >= 0; i--)
                {
                    pilha[i] = Vetor[j];
                    j++;
                }
            }
            return pilha;
        }
        static void Main(string[] args)
        {
            int Pos = 0;
            int tam = 5;
            int[] V = new int[tam];
            int[] VTrocado = new int[V.Length];

            for (int j = 0; j < tam; j++)
            {
                if (Pos < tam)
                {
                    InserirFila(V, Pos);
                    Pos += 1;
                }
            }

            Console.Write("Fila: ");
            MostraVetor(V);

            VTrocado = InserirPilha(V, tam);

            MostraVetor(VTrocado);

            Console.ReadKey();
        }
    }
}
