using System;
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

using System;
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
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>


Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.3.32825.248
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ProjetoClasse", "ProjetoClasse.csproj", "{EBE5FC88-CAF2-4EE5-80FD-AB4B0443FE28}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{EBE5FC88-CAF2-4EE5-80FD-AB4B0443FE28}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{EBE5FC88-CAF2-4EE5-80FD-AB4B0443FE28}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{EBE5FC88-CAF2-4EE5-80FD-AB4B0443FE28}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{EBE5FC88-CAF2-4EE5-80FD-AB4B0443FE28}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {97A5F49F-19EC-49BD-89E5-51493A968B3B}
	EndGlobalSection
EndGlobal

