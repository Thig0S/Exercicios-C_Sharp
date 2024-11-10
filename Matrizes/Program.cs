using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamanho, tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite os " + tamanho + " valores da matriz: ");
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < tamanho; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Diagonal Principal: ");
            for(int i = 0;i < tamanho; i++)
            {
                Console.Write(matriz[i,i]);
            }

            Console.Write("\nQuantidade de números negativos: ");

            int contador = 0;

            for(int i =0; i < tamanho; i++)
            {
                for(int j = 0;j < tamanho; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contador++;
                    }
                }
            }
            Console.WriteLine("\nA quantidade de números negativos são: "+contador);
        }
    }
}
