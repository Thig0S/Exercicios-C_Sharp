using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação_Orientada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int idade;
                string nome;
                Cachorro cachorro1 = new Cachorro();
                do { 

                    Console.Write("Digite o nome do cachorro: ");
                    nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome)) {
                        Console.Write("O nome do cachorro não pode estar Vazio," +
                            "Digite um nome válido!\n");
                    } 

                cachorro1.Nome = nome;
                    } while (string.IsNullOrWhiteSpace(nome));

                Console.Write("\nDigite o idade do cachorro: ");
                while (!int.TryParse(Console.ReadLine(), out idade))
                {
                    Console.Write("Entrada inválida. Digite um valor válido.");
                }
                cachorro1.Idade = idade;

                Console.Write("O cachorro está com sono? (s/n)");
                if(Console.ReadLine().ToLower() == "s")
                {
                    cachorro1.Sono = true;
                }
                Console.Clear();
                cachorro1.MostrarCachorro();

                Console.Write("\nDeseja Cadastrar Outro Cachorro? (s/n)");
                if (Console.ReadLine().ToLower() != "s")
                {
                    break;
                };
            }
        }
    }
}
