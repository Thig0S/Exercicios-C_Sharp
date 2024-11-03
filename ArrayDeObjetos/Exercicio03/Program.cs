using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o número de produtos a serem cadastrados: ");
            int num = int.Parse(Console.ReadLine());

            Produtos[] p = new Produtos[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Digite o nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do Produto: ");
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                p[i] = new Produtos(nome, preco);
            }
            double som = 0.0;

            for(int i = 0; i < num; i++)
            {
                som += p[i].Preco;
            }
            double result = som / num;

            Console.WriteLine(result.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
