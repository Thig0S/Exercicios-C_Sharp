using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio04.Entidades;
using System.Globalization;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> contribuintes = new List<Contribuinte>();

            Console.Write("Digite o número de Contribuintes a serem cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= +n; i++)
            {
                Console.WriteLine($"\nDigite os Dados do {i}° Contribuinte(s): ");

                Console.Write("Pessoa física ou jurídica ? (f/j) : ");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'f')
                {
                    Console.Write("Gasto Saúde: ");
                    double saudeGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contribuintes.Add(new PessoaFisica(nome, renda, saudeGasto));
                }
                else if (tipo == 'j')
                {
                    Console.Write("Número de Funcionários: ");
                    int numFun = int.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaJuridica(nome, renda, numFun));
                }
                else
                {
                    Console.WriteLine("Tipo de pessoa inválida");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Imposto pagos por cada Contribuinte: \n");
            
            double somaImpostos = 0;

            foreach (Contribuinte contribuinte in contribuintes)
            {
                somaImpostos += contribuinte.ImpostoCalc();
                Console.WriteLine(contribuinte);
            }
            Console.WriteLine($"\nTotal de Impostos: $"+somaImpostos);
        }
    }
}
