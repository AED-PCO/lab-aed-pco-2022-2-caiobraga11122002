//Codigos cópiados/modificados da internet

BoubleSort-

using System;

namespace ConsoleApp7
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0, 1000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }

        static void bubblesort(int[] vet,  ref int comparacoes, ref int troca)
        {

            int Cont;

            for (int i = vet.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    comparacoes++;

                    if (vet[j + 1] <= vet[j])
                    {
                        troca++;

                        Cont = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = Cont;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];
            int compara = 0, troca = 0;

            CriaVetor(V);

            bubblesort(V, ref compara, ref troca);

            MostraVetor(V);
        }
    }
}



InsertionSort-

using System;

namespace ConsoleApp7
{
    class Program
    {
         static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }

        static void CriaVetor(int[] vet)
        {
            Random X = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = X.Next(0, 10000);
            }
        }

        static void insertionSort(int[] V, ref int comp, ref int troca)
        {
            int aux, j;

            for (int i = 1; i < V.Length; i++)
            {
                aux = V[i];

                for (j = i; (j > 0) && (V[j - 1] > aux); j--, comp++)
                {
                    troca++;
                    V[j] = V[j - 1];
                }

                troca++;
                V[j] = aux;
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];

            int Comp = 0, troca = 0;

            CriaVetor(V);

            insertionSort(V, ref Comp, ref troca);

            MostraVetor(V);
        }
    }
}




MergeSort-

using System;

namespace ConsoleApp7
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0, 10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }
        static void Troca(int[] V, int In, int Fim)
        {
            int meio = (In + Fim) / 2;

            int p = In, i, j;

            int[] vetAux1 = new int[meio + 1];

            int[] vetAux2 = new int[Fim - meio];

            for (i = 0; i < (meio - In) + 1; i++)
            {
                vetAux1[i] = V[In + i];
            }

            for (j = 0; j < Fim - meio; j++)
            {
                vetAux2[j] = V[meio + 1 + j];
            }

            for (i = 0, j = 0; i < (meio - In) + 1 && j < Fim - meio; p++)
            {
                Comp++;

                if (vetAux1[i] <= vetAux2[j])
                {
                    troca++;
                    V[p] = vetAux1[i];
                    i++;
                }
                else
                {
                    troca++;
                    V[p] = vetAux2[j];
                    j++;
                }
            }
            for (; i < (meio - In) + 1; i++, p++)
            {
                V[p] = vetAux1[i];
            }
                
            for (; j < Fim - meio; j++, p++)
            {
                V[p] = vetAux2[j];
            }   
        }
        static void mergeSort(int[] V, int In, int Fim)
        {
            if (In < Fim)
            {
                int meio = In + (Fim - In) / 2;
                mergeSort(V, In, meio);
                mergeSort(V, meio + 1, Fim);
                Troca(V, In, Fim);
            }
        }

        static int Comp = 0, troca = 0;
        static void Main(string[] args)
        {
            int[] V = new int[10000];

            CriaVetor(V);

            mergeSort(V, 0, V.Length - 1);

            MostraVetor(V);
        }
    }
}




QuickSort-

using System;

namespace ConsoleApp8{
    class Program
    {
        static int Comp = 0, troca = 0;

        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0,10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }


        static void quickSort(int[] V, int In, int Fim)
        {
            int i = In, j = Fim;
            int x, y;
            x = V[(In + Fim) / 2];

            while (i <= j)
            {
                while (V[i] < x && i < Fim)
                {
                    i++;
                    Comp++;
                }
                while (V[j] > x && j > In)
                {
                    j--;
                    Comp++;
                }
                if (i <= j)
                {
                    y = V[i];
                    V[i] = V[j];
                    V[j] = y;
                    i++;
                    j--;
                    Comp++;
                }
            }

            if (j > In)
            {
                quickSort(V, Fim, j);
            }
            if (i < In)
            {
                quickSort(V, i, Fim);
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];

            CriaVetor(V);

            quickSort(V, 0, V.Length - 1);

            MostraVetor(V);
        }
    }
}



SelecionSort-


using System;

namespace ConsoleApp8
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0,10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }

        static void selectionSort(int[] V, ref int Comp, ref int troca)
        {
            int Menor, cont;

            for (int i = 0; i < V.Length; i++)
            {
                Menor = i;

                for (int j = i + 1; j < V.Length; j++)
                {
                    Comp++;
                    if (V[j] < V[Menor])
                    {
                        Menor = j;
                    }
                }

                Comp++;
                if (Menor != i)
                {
                    troca++;

                    cont = V[Menor];
                    V[Menor] = V[i];
                    V[i] = cont;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];

            int Comp = 0, Troca = 0;

            CriaVetor(V);

            selectionSort(V, ref Comp, ref Troca);

            MostraVetor(V);
        }
    }
}


Shellsort-

using System;

namespace ConsoleApp8
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0, 10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }
        static void shellSort(int[] V, ref int Comp, ref int troca)
        {

            int j, k = 400, Ref;

            while (k > 0)
            {
                for (int i = 0; (i + k) <= (V.Length - 1); i++)
                {
                    Ref = V[i + k];
                    Comp++;
                    for (j = i + k; (j - k >= 0) && V[j - k] >= Ref; j -= k)
                    {
                        V[j] = V[j - k];
                        troca++;
                    }
                    V[j] = Ref;

                }
                k = k / 2;

            }
        }
        static void Main(string[] args)
        {
            int[] V = new int[10000];

            int Comp = 0, troca = 0;

            MostraVetor(V);

            shellSort(V, ref Comp, ref troca);

            MostraVetor(V);

        }
    }
}

