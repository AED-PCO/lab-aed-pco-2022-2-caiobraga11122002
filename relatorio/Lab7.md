-Exercicio 1 - Modele, projete e calcule a complexidade de um programa que:
a) Leia as linhas de um arquivo chamado "arq1.txt".
b) Peça para o usuario inserir um texto no terminal//console.
c) Compare o texto escrito pelo usuário e o texto lido no arquivo, e escreva na tela quantos termos IGUAIS e DIFERENTE.
d) Descreva as operacoes relevantes.
Respostas
a)Comparação e Atribuição.
b)O(n2)
c)(CODIGO)
d)Comparação e atribuição


-Exercicio 2 - Dado o código a seguir, responda:
a) Quantos e quais sao os casos base//condicao de parada para a funcao funcRec1()?
b) Explique com suas palavras o que a funcao funcRec1 calcula.
c) Represente a pilha de execucao para a chamada funcRec1(6).
respostas 
a) A <= 1 e quando estoura o limite.
b) Conta de 3 em 3 ex  6, 9, 12, 15...
c)![TABELA](https://user-images.githubusercontent.com/111787841/198113343-d333eba9-3eb4-4a2a-9278-f98fd777d7fe.png)


-Exercicio 3 - Modele, projete e calcule a complexidade de um programa que:
a) Leia a primeira linha de um arquivo chamado "entrada.txt"
b) Escreva em um arquivo chamado "saida.txt"o conteudo lido no arquivo de entrada ao contrário.
c) Descreva quais as operacoes relevantes.
respostas 
a) (CODIGO)
b) (CODIGO)
c) Atribuicao.


-Exercicio 4 - Um banco enfrenta problemas de consulta em seu banco de registros. Dentre os problemas identificados pela gerencia está a 
localizacao das contas dos seus titulares nas listagens e nos relatorios impressos em diferentes situacoes. Um especialista de TI sugeriu ordenar
as contas por meio dos CPF dos seus n titulares antes das impressoes. Dentre alguns algoritmos pré seleconados para essa ordenacao o especialista 
escolheu o algoritmo de ordenacao por insercao. Se voce fosse o especialista, responda:
a) O especialista escolheu um bom algoritmo?
b) Qual algoritmo de ordenacao utilizaria?
c) Descreva quais operacoes relevantes.
d) Demonstre a viabilidade de sua solucao para 10 registros.
Respostas
a) Não, o algoritimo tem uma complexidade O não constante o que faria com que quanto maior 
for o numero de CPF mais crescente vai ficar a curva de complexidade e menos será aplicavel.
b) MegeSort seria o mais aconcelhavel, pois iria manter a complexidade sempre linear. 
c) omparacao, atribuicao.



-Exercicio 5 - O código a seguir implementa uma funcao recursiva. Analise-o indique o que será retornado pela funcao, caso os parametros possuam os seguintes
dados: V={10,5,7,15,22,9,30} e A =6.
respostas 
a)5, 1, 30,
