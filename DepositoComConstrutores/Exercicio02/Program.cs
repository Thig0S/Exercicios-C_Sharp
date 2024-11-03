using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Banco b;

            Console.Write("Digite o número da Conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da Conta: ");
            string nome = Console.ReadLine();
            Console.Write("Deseja efetuar um depósito inicial? (s/n)");
            if (char.Parse(Console.ReadLine().ToLower()) == 's')
            {
                Console.Write("Informe o valor do depósito Inicial: ");
                double saldoinicial = double.Parse(Console.ReadLine());

                b = new Banco(nome,num, saldoinicial);
            }
            else
            {
                b = new Banco(nome,num);
            }


            //funcao escolha
            Console.WriteLine("");
            Console.WriteLine(b);
            Console.WriteLine("");

            Console.WriteLine("\nDigite o valor para Depósito: R$");
            double dep = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            b.Deposito(dep);

            Console.WriteLine(b);

            Console.WriteLine("\nDigite um valor para Saque: R$");
            double saq = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            b.Saque(saq);

            Console.WriteLine(b);
        }
    }
}
