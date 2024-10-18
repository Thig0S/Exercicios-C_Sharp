using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            while (true)
            {

                //Atividade para melhorar o uso de variavéis privadades dentro da Classe Pessoa.cs       

                Console.WriteLine("===|Cadastro TK|===");

                Console.WriteLine("Digite o NOME da pessoa a ser cadastrada");
                string nome = Console.ReadLine();
                pessoa.DefinirNome(nome);

                Console.WriteLine("Digite a IDADE da pessoa a ser cadastrada");
                int idade = 0;
                pessoa.ValidarIdade(idade);

                pessoa.MostrarNomeIdade();
                if (Console.ReadLine().ToLower() != "s")
                {
                    break; // Sai do loop se a resposta não for 's'
                }

            }
        }
    }
}
