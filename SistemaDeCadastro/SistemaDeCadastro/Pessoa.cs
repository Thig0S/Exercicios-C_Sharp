using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{
    class Pessoa
    {
        private string nome;
        private int idade;
 
        public void DefinirNome(string nome)
        {
            this.nome = nome;
        }
        public void ValidarIdade(int idade)
        {
            while (true)
            {
                try
                {
                    idade = int.Parse(Console.ReadLine());
                    if (idade > 0)
                    {
                        DefinirIdade(idade);
                        break;
                    }
                    else
                    { //Criar um error para o chatch caso o numero seja menor que 0
                        throw new ArgumentOutOfRangeException(nameof(idade), "A idade deve ser maior que 0!");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Digite um número válido! ");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    //Provavélmente não precisava deste outro catch
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DefinirIdade(int idade)
        {
            this.idade = idade;   
        }
        public void MostrarNomeIdade()
        {
            Console.WriteLine($"Nome: {this.nome} e idade: {this.idade}");
            Console.ReadLine();
            Console.Clear();
        }     
    }
}
