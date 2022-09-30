using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace MyApp
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

        static double ReajusteSalario(Double S)
        {
            double Soma = 0;

            if (S < 1700)
            {
                Soma = S + 300;
                return Soma;
            }
            else
                Soma = S + 200;
            return Soma;
        }

        static string FuncaoTrocaLetra(string frase)
        {
            if (frase.Trim().Length > 0)
            {
                int Total = frase.Length, i = 0;

                var StringBuilder = new StringBuilder(frase);

                while (i < Total)
                {
                    if (StringBuilder[i] == 'A' || StringBuilder[i] == 'a')
                    {
                        StringBuilder[i] = '&';
                    }
                    i++;
                }

                frase = StringBuilder.ToString();

                return frase;
            }
            else
            {
                return null;
            }
        }

        static void Main(string[] args)
        {
            int op;
            do
            {
                //MENU DE OPÇÕES
                {
                    Console.WriteLine("======= BEM VINDO A ATIVIDADE DE NIVELAMENTO =======");
                    Console.WriteLine();
                    Console.WriteLine("1 - MEDIA ALUNOS");
                    Console.WriteLine("2 - VALIDA PAR OU IMPAR");
                    Console.WriteLine("3 - VALIDA MAIORES DE IDADE");
                    Console.WriteLine("4 - CÓDIGO MAIOR E MENOR ALUNO");
                    Console.WriteLine("5 - CALCULADORA");
                    Console.WriteLine("6 - VALIDA PERMIÇÃO");
                    Console.WriteLine("7 - SOLICITE A ENTRADA DA FRASE E TROQUE 'a' POR '&'");
                    Console.WriteLine("8 - AJUSTE DE SALÁRIO");
                    Console.WriteLine("9 - GRAVA CADASTRO - EM ARQUIVO");
                    Console.WriteLine("10 - CADASTRO DE CALCULO IMC - EM ARQUIVO");
                    Console.WriteLine("0 - SAIR...");
                    Console.WriteLine();

                    Console.Write("Qual Atividade: ");
                    op = int.Parse(Console.ReadLine());
                }

                Console.Clear();

                //TRABALHO

                switch (op)
                {
                    case 1:
                        {
                            int soma = 0, media = 0, idade;

                            for (int i = 1; i <= 5; i++)
                            {
                                Console.Write($"Qual a idade do aluno {i}: ");
                                idade = int.Parse(Console.ReadLine());

                                soma = soma + idade;

                            }
                            media = soma / 5;
                            Console.WriteLine($"A idade Media dos Alunos são: {media}");

                        }
                        break;

                    case 2:
                        {

                            int N;

                            Console.WriteLine($"Qual o Valor para Validação: ");
                            N = int.Parse(Console.ReadLine());

                            if (N % 2 == 0)
                            {
                                Console.WriteLine("O valor informado é PAR!");
                            }
                            else
                                Console.WriteLine("O valor informado é IMPAR!");
                        }
                        break;

                    case 3:
                        {

                            int Idade;
                            int[] V = new int[10];

                            for (int i = 1; i <= 10; i++)
                            {
                                Console.Write($"Qual a idade do aluno {i}: ");
                                Idade = int.Parse(Console.ReadLine());

                                if (Idade > 18)
                                {
                                    V[i] = Idade;
                                }

                            }

                            MostraVetor(V);
                        }
                        break;

                    case 4:
                        {

                            double altura, codigo, maiorAltura = 0, MenorAltura = 10, MaiorCodigo = 0, MenorCodigo = 0;

                            for (int i = 1; i <= 3; i++)
                            {
                                Console.Write($"Qual a Altura do Aluno: {i} ");
                                altura = double.Parse(Console.ReadLine());

                                Console.Write($"Qual o Codigo Aluno: {i} ");
                                codigo = double.Parse(Console.ReadLine());

                                if (maiorAltura < altura)
                                {
                                    maiorAltura = altura;
                                    MaiorCodigo = codigo;
                                }

                                if (MenorAltura > altura)
                                {
                                    MenorAltura = altura;
                                    MenorCodigo = codigo;
                                }
                            }
                            Console.Write($"O codigo do maior aluno é: {MaiorCodigo}");

                            Console.Write($"O codigo do menor aluno é: {MenorCodigo}");

                        }
                        break;

                    case 5:
                        {

                            int N1, N2, Total, opcao;
                            Console.WriteLine("==========CALCULADORA============");

                            Console.WriteLine("Qual a opção deseja fazer: ");

                            Console.WriteLine("1 - Adição: ");
                            Console.WriteLine("2 - Subtração: ");
                            Console.WriteLine("3 - Multiplicação: ");
                            Console.WriteLine("4 - Divisão: ");

                            opcao = int.Parse(Console.ReadLine());

                            Console.Write("Qual o valor de N1: ");
                            N1 = int.Parse(Console.ReadLine());

                            Console.Write("Qual o valor de N2: ");
                            N2 = int.Parse(Console.ReadLine());

                            switch (opcao)
                            {
                                case 1:

                                    Total = N1 + N2;
                                    Console.WriteLine($"O total da Soma é {Total}");

                                    break;

                                case 2:

                                    Total = N1 - N2;
                                    Console.WriteLine($"O total da Subtração é {Total}");

                                    break;

                                case 3:

                                    Total = N1 * N2;
                                    Console.WriteLine($"O total da Multiplicação é {Total}");

                                    break;

                                case 4:

                                    Total = N1 / N2;
                                    Console.WriteLine($"O total da Divisão é {Total}");

                                    break;

                            }
                            break;
                        }
                        break;

                    case 6:
                        {
                            int idadePermicao;

                            Console.WriteLine("Qual a idade:");
                            idadePermicao = int.Parse(Console.ReadLine());

                            if (idadePermicao >= 18)
                            {
                                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Está permitido");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Não está permitido");
                                Console.ResetColor();
                            }
                        }
                        break;

                    case 7:
                        {
                            string Frase = "A Sra Ana é o amor da minha voida.";

                            Console.WriteLine(FuncaoTrocaLetra(Frase));

                            Console.ReadKey();
                        }
                        break;

                    case 8:
                        {
                            double salario, Total;

                            Console.Write("Qual o salário: ");
                            salario = double.Parse(Console.ReadLine());

                            Total = ReajusteSalario(salario);

                            Console.WriteLine($"O salário atual após o reajuste é: {Total}");
                        }
                        break;

                    case 9:
                        {
                            int contador;
                            string email, nome, rg, telefone;

                            Console.WriteLine("Quantos Cadastros deseja fazer: ");
                            contador = int.Parse(Console.ReadLine());

                            for (int j = 1; j <= contador; j++)
                            {
                                StreamWriter sw = new StreamWriter("C:\\AED\\AED.txt", true);

                                Console.Write("Qual o email: ");
                                email = Console.ReadLine();
                                sw.WriteLine(email);

                                Console.Write("Qual o Nome: ");
                                nome = Console.ReadLine();
                                sw.WriteLine(nome);

                                Console.Write("Qual o telefone: ");
                                telefone = Console.ReadLine();
                                sw.WriteLine(telefone);

                                Console.Write("Qual o RG: ");
                                rg = Console.ReadLine();
                                sw.WriteLine(rg);

                                sw.Close();
                            }

                            Console.WriteLine("CADASTRO REALIZADO COM SUCESSO!");
                        }
                        break;

                    case 10:
                        {
                            double Altura, peso, total;

                            StreamWriter arq = new StreamWriter("C:\\AED\\AED2.txt", true);

                            Console.Write("Qual a altura: ");
                            Altura = double.Parse(Console.ReadLine());
                            arq.WriteLine(Altura);

                            Console.Write("Qual o peso: ");
                            peso = double.Parse(Console.ReadLine());
                            arq.WriteLine(peso);

                            total = Altura / (peso * peso);
                            arq.WriteLine(total);

                            arq.Close();

                            Console.WriteLine(total);
                        }

                        break;

                    case 0:
                        break;
                }

                

            } while (op != 0);

        }
    }
}
