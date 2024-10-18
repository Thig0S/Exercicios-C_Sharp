using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDepósito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            while (true)
            {
                int opcao = 0;
                bool opcaoValida = false;

                Console.WriteLine("==|Bem-vindo ao Banco TK|==\n");

                while (!opcaoValida)
                {
                    Console.WriteLine("1 - Para ver seu saldo");
                    Console.WriteLine("2 - Para fazer um saque");
                    Console.WriteLine("3 - Para fazer um depósito");
                    Console.WriteLine("4 - Para encerrar o programa\n");
                    Console.Write("Digite o método desejado: ");

                    try
                    {
                        opcao = int.Parse(Console.ReadLine());

                        if (opcao >= 1 && opcao <= 4)
                        {
                            opcaoValida = true;
                        }
                        else
                        {
                            Console.WriteLine("\nOpção inválida. Por favor, escolha um número entre 1 e 4.\n");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nEntrada inválida. Digite um número.\n");
                    }
                }
                Console.Clear();
                switch (opcao)
                {
                    case 1: // Ver saldo
                        contaBancaria.ExibirSaldo();
                        break;

                    case 2: // Fazer saque
                        Console.Write("Digite o valor do Saque R$: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        contaBancaria.Saque(valorSaque); 
                        break;

                    case 3: // Fazer depósito
                        Console.Write("Digite o valor do Depósito R$: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        contaBancaria.Deposito(valorDeposito);
                        break;

                    case 4: // Sair
                        Console.WriteLine("Obrigado por utilizar o Banco TK. Até logo!");
                        return; 
                }
            }
        }
    }
}
