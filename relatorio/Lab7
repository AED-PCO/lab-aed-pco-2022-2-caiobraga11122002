1-
CODIGO

2-
a) Se a foir <= 1 ou esttourar o limite da variável.
b)Conta de 3 em 3 ex: 6,9,12,15,18
c)CRIAR TABELA 

3-
a
b
c

4-
a
b
c

5-
a
b
c
1

namespace lab2_fra
{
    internal class Program
    {
        static int ComparaArquivo(string FraseArquivo, String FraseEscrita)
        {
            int Iguais = 0, Diferentes = 0;

            for(int i=0; i <= FraseArquivo.Length; i++)
            {
                for()
                if (FraseArquivo[i] == FraseEscrita[i])
                {
                    Iguais++;
                    Diferentes++;

                }
                else
                {
                    Iguais++;
                    Diferentes++;
                }
            }
             return Iguais;
             return Diferentes;
        }
        
        static void Main(string[] args)
        {

            String Linha, ArmCaminho, FraseUs;
            StreamReader X;

            ArmCaminho = "C:\\AED\\Arq1.TXT";

            X = File.OpenText(ArmCaminho);

            //while (X.EndOfStream != true)
            //{
                Linha = X.ReadLine();
                Console.WriteLine(Linha);
            //}

            Console.WriteLine("Olá, informe uma frase para que possamos comparar:");
            FraseUs = Console.ReadLine();

            ComparaArquivo(FraseUs, Linha);

            X.Close();
            Console.ReadKey();
        }
    }
}






2

namespace lab2_fra
{
    internal class Program
    {
      static int funcRec1(int a)
        {
            if (a <= 1)
                return 0;
            else
                return funcRec1((a - 2) + 5);
        }
        static void Main(string[] args)
        {

            int a = 6, r;

            r = funcRec1(a);

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}


5
