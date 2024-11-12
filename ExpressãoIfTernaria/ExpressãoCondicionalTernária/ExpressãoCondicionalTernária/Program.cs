using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressãoCondicionalTernária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto: ");
            double preco = double.Parse(Console.ReadLine());

            double valorComDesconto = (preco > 100) ? preco - (preco * 0.20) : preco;

            Console.WriteLine("Valor final: " +valorComDesconto);
        }
    }
}
