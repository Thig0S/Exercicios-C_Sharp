using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizarArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.Write("Digite o nome do Produto: ");
            produto.NomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do Produto: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do Produto: ");
            produto.QuantidadeProduto = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do Produto {produto}");

            Console.WriteLine("\nDigite a quantidade de produtos a serem adicionados");
            int remover = int.Parse(Console.ReadLine());
            produto.AddTotalEstoque(remover);

            Console.WriteLine($"\nDados do Produto {produto}");
            Console.WriteLine("\nDigite a quantidade de produtos a serem retirados");
            remover = int.Parse(Console.ReadLine());
            produto.RemoverTotalEstoque(remover);

            Console.WriteLine($"\nDados do Produto {produto}");
        }

    }
}
