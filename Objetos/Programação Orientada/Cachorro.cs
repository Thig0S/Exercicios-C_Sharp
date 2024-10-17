using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação_Orientada
{
    internal class Cachorro
    {
        private string nome;
        private int idade;
        private bool sono;

        public string Nome { get { return nome; } set { nome = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public bool Sono { get { return sono; } set { sono = value; } }

        public void MostrarCachorro()
        {
            Console.WriteLine($"\nO nome do cachorro/cachorra é {Nome} e possui {Idade} anos de vida!\n");
            if (Sono)
            {
                Console.WriteLine("O Cachorro Precisa Dormir Coitado!\n");
            }
            else
            {
                Console.WriteLine("O cachorro não está com Sono\n");
            }
        }
    }
}
