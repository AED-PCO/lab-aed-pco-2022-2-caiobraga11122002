namespace lab8_fila
{
    internal class Program
    { 
        static void MostraVetor(int[] V)
        {
            for(int i = 0; i < V.Length; i++)
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

        static int[] InserirPilha(int[] Vetor, int pos)
        {
            
            int[] pilha = new int[Vetor.Length];
            int posPilha = pilha.Length;

            for(int j = 0; j > Vetor.Length; j++)
            {
                pos = Vetor[j];
                pos+=1;
                posPilha-=1;
            }
            return pilha;
        }


        static void Main(string[] args)
        {
            int Pos = 0;
            int[] V = new int[5];
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

            VTrocado = InserirPilha(V, Pos);

            MostraVetor(VTrocado);

            Console.ReadKey();
        }
    }
}
