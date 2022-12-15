using System;

namespace ABB
{
    class ArvoreBinaria 
    {
        No raiz, valores;
        public ArvoreBinaria()
        {
            raiz = null;
        }
        
        public void inserir(int x)
        {
            raiz = inserirValor(x, raiz);
        }
        No inserirValor(int x, No i) 
        {
                if(i == null)
                {
                    i = new No(x);
                }
                if(x < i.elemento)
                {
                    i.esquerda = inserirValor(x, i.esquerda);
                }
                if(x > i.elemento)
                {
                    i.direita = inserirValor(x, i.direita);
                }
                return i;

        }

        public bool pesquisar(int x)
        {
            return pesquisarValor(x, raiz);
        }
        public bool pesquisarValor(int x, No i)
        {
            bool valor = true;
            
            
                if(i == null) 
                {
                    valor = false;
                }else if(x == i.elemento)
                {
                    valor = true;
                }else if(x < i.elemento)
                {
                    valor = pesquisarValor(x, i.esquerda);
                }else
                {
                    valor = pesquisarValor(x, i.direita);  
                }
                return valor;
        }


        public void remover(int x)
        {
            raiz = removerValor(x, raiz);
        }

        No removerValor(int x, No i)
        {
                if(i == null)
                {
                    Console.WriteLine("Arvore vazia");
                }else if (x < i.elemento)
                {
                    i.esquerda = removerValor(x, i.esquerda);
                }else if (x > i.elemento)
                {
                    i.direita = removerValor(x, i.direita);
                }else if(i.direita == null)
                {
                    i = i.esquerda;
                }else if (i.esquerda == null)
                {
                    i = i.direita;
                }else{
                    i. esquerda = maiorEsquerda(i, i.esquerda);
                }
                return i;
        }

        No maiorEsquerda(No i, No j)
        {
            if(j.direita == null)
            {
                i.elemento = j.elemento;
                j = j.esquerda;
            }else
            {
                j.direita = maiorEsquerda(i, j.direita);
            }
            return j;
        }

        public void EmOrdem()
        {
            exibirOrdem(raiz);
        }
        public void exibirOrdem(No i)
        {
                if(i != null)
                {
                    exibirOrdem(i.esquerda);
                    Console.Write(" {0}",i.elemento);
                    exibirOrdem(i.direita);
                }
        }

        public void preOrdem()
        {
            exibirPreOrdem(raiz);
        }

        public void exibirPreOrdem(No i)
        {
                if(i != null)
                {
                    Console.Write(" {0}",i.elemento);
                    exibirOrdem(i.esquerda);
                    exibirOrdem(i.direita);
                }
        }

        public void posOrdem()
        {
            exibirPosOrdem(raiz);
        }

        public void exibirPosOrdem(No i)
        {
                if(i != null)
                {
                    exibirOrdem(i.esquerda);
                    exibirOrdem(i.direita);
                    Console.Write(" {0}",i.elemento);
                }
           
        }
    }
}

//Classe ABB

using System;

namespace ABB
{
    class No
    {
        public int elemento;
        public No esquerda;
        public No direita;
        public No(int elemento)
        {
            this.Node(elemento,null,null);
        }
        void Node(int elemento, No esquerda, No direita)
        {
            this.elemento = elemento;
            this.esquerda = esquerda;
            this.direita = direita;
            
        }
    }
}
