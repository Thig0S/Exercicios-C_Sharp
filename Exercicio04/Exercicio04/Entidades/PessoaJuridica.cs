using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Entidades
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica(string x, double y, int funcionarios) : base(x, y)
        {
            NumFuncionarios = funcionarios;
        }

        public override double ImpostoCalc()
        {
            double imposto = 0;

            if (NumFuncionarios > 10)
            {
                imposto += (RendaAnual * 0.14);
            }
            else
            {
                imposto += (RendaAnual * 0.16);
            }
            return imposto;
        }
        public override string ToString()
        {
            return $"{Name}: $ {ImpostoCalc()}";
        }
    }
}
