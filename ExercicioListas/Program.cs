using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func;
            Console.Write("Quantas pessoas serão cadastradas: ");
            int qntPessoas = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i < qntPessoas + 1; i++)
            {

                Console.WriteLine($"\n{i}° Funcionário");

                Console.Write("Digite o ID do funcionário: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o salário do funcionário: R$");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(func = new Funcionario(id, nome, salario));

            }
            Console.Write("\nDigite o ID do funcionario que ira receber o aumento: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionarioEncontrado = funcionarios.Find(f => f.Id == idFuncionario);

            if(funcionarioEncontrado != null)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                double aumento = int.Parse(Console.ReadLine());
                funcionarioEncontrado.AumentarSalario(aumento);
            }
            else
            {
                Console.WriteLine("\nEste usuário não existe!");
            }
            Console.WriteLine("\nLista Atualizada dos funcionarios: ");

            foreach(var f in funcionarios)
            {
                Console.WriteLine(f);
            }
        }
    }
}
