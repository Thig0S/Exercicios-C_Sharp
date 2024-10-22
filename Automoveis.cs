using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Automoveis:Empresa
    {
        public string ModeloCarro
        {
            get; set;
        }
        public override void MostrarEmpresa()
        {
            Console.WriteLine("==/Cadastro De Empresa de AutoMovéis/==");
            base.MostrarEmpresa();
            Console.WriteLine($"O modelo de carro da empresa é " + ModeloCarro);
        }
    }
}
