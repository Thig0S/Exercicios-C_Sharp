using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empresa> VariasEmpresas = new List<Empresa>();

            while (true)
            {
                Console.WriteLine("Bem-Vindo ao sistema da nossa Empresa");
                Console.WriteLine("1. Cadastrar Empresa de Automovéis");
                Console.WriteLine("2. Cadastrar os Empresa de Games");
                Console.WriteLine("3. Exibir os Cadastros");
                Console.WriteLine("4. Sair");
                Console.Write("Escolher uma opção: ");

                int opcao = 0;

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, insira um número válido");
                    continue;
                }
                switch (opcao)
                {               
                    case 1:
                        Console.WriteLine("Digite o NOME da Empresa de AUTOMOVÉIS");
                        string nomeAuto = Console.ReadLine();
                        Console.WriteLine("Digite o DONO da Empresa");
                        string donoAuto = Console.ReadLine();
                        Console.WriteLine("Digite o MODELO DO AUTOMOVÉL da Empresa");
                        string modelo = Console.ReadLine();

                        Automoveis automoveis = new Automoveis
                        {
                            Nome = nomeAuto,
                            Dono = donoAuto,
                            ModeloCarro = modelo
                        };
                        VariasEmpresas.Add(automoveis);
                        Console.WriteLine("Cadastro concluído com Sucesso!!!");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Digite o NOME da Empresa de JOGOS");
                        string nomeJogos = Console.ReadLine();
                        Console.WriteLine("Digite o DONO da Empresa de JOGOS");
                        string donoJogos = Console.ReadLine();
                        Console.WriteLine("Digite o JOGO da Empresa");
                        string jogo = Console.ReadLine();

                        Jogos jogos = new Jogos
                        {
                            Nome = nomeJogos,
                            Dono = donoJogos,
                            JogoEmpresa = jogo
                        };
                        VariasEmpresas.Add(jogos);
                        Console.WriteLine("Cadastro concluído com Sucesso!!!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\n===== Cadastros =====");
                        foreach (var empresa in VariasEmpresas)
                        {                
                            Console.WriteLine();
                            empresa.MostrarEmpresa();
                            Console.WriteLine('\n');
                        }
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
                        break;
                }
            }
        }
    }
}
