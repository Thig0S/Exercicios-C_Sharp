using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Empresa
    {
        public int Contador
        {
            get;set;
        }
        public string Nome 
        {
            get; set;  
        }
        public string Dono
        {
            get; set;
        }
        public virtual void MostrarEmpresa()
        {
            Console.WriteLine($"O nome da empresa é "+Nome);
            Console.WriteLine($"O dono da empresa é " + Dono);
        }

    }
}
