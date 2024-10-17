using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionaisIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double desconto;          

            Console.WriteLine("====/Calculadora de Descontos/====\n");
            Console.Write("Produtos acima de R$1350,00 recebem 12% de Desconto!\n");
            
            while (true)
            {
                Console.Write("Digite o valor do Produto: R$ ");
                if (!Double.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("Digite um valor VÁLIDO!");
                }
                else
                {
                    break;
                }
            }
            if(valor > 1350.00){
                desconto = valor - (valor * 0.12);
                Console.WriteLine("");
                Console.WriteLine("Desconto de 12% aplicado!\n");
                Console.WriteLine($"O valor final do produto é: R${desconto}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Nenhum desconto foi aplicado!");
                Console.WriteLine($"O valor final do produto é: R${valor}");
                Console.ReadLine();
            }                       
        }
    }
}
