using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;


            Pessoa[] p = new Pessoa[9];

            Console.Write("Quantos estudantes vão alugar os quartos? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                a++;

                Console.WriteLine($"{a}° Rent \n");
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite seu Email: ");
                string email = Console.ReadLine();
                Console.Write("Qual quarto deseja: ");
                int quarto = int.Parse(Console.ReadLine());

                p[quarto] = new Pessoa(nome, email);
            }

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != null)
                {
                    Console.WriteLine($"Quarto {i} Ocupado por: {p[i]}");
                }
            }
        }
    }
}
