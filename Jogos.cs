using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Jogos:Empresa
    {
        public string JogoEmpresa
        {
            get; set;
        }
        public override void MostrarEmpresa()
        {
            Console.WriteLine("==/Cadastro De Empresa de Jogos/==");
            base.MostrarEmpresa();
            Console.WriteLine($"O modelo de carro da empresa é " + JogoEmpresa);
        }
    }
}
