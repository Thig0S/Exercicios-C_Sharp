using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia dois valores inteiros L,C 
            //Depois ler uma matriz por L linhas e C colunas contendo números inteiros 
            //Em seguida ler o Numero X que pertence a matriz e mostrar os valores a esquerda, acima,
            //direita e abaixo de X conforme houver

            Console.Write("Digite o número de linhas e colunas: ");
            string[] linhasColunas = Console.ReadLine().Split(' ');

            int L = int.Parse(linhasColunas[0]);
            int C = int.Parse(linhasColunas[1]);

            int[,] matriz = new int[L, C];

            //Percorre as Linhas e Colunas para Add na matriz

            for (int i = 0; i < L; i++)
            {
                Console.Write("Digite os números da coluna: ");
                string[] num = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    matriz[i, j] = int.Parse(num[j]);
                }
            }
            //Percorre a matriz e mostra os elementos nas posições de acordo com o 
            //elemento selecionado.

            Console.Write("\nSelecione um elemento da tabela: ");
            int elementoSelecionado = int.Parse(Console.ReadLine());

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (matriz[i, j] == elementoSelecionado)
                    {
                        Console.WriteLine($"\nElemento na Posição: {i},{j}");

                        //Elemento a Esquerda
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i,j-1]);
                        }
                        //Elemento a Direita
                        if(j + 1 >= 0)
                        {
                            Console.WriteLine("Direita: " + matriz[i,j+1]);
                        }
                        //Elemento Acima
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i-1, j]);
                        }
                        //Elemento Abaixo
                        if (i + 1 >= 0)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i+1, j]);
                        }
                        Console.WriteLine("");
                    }                    
                }
            }
        }
    }
}
