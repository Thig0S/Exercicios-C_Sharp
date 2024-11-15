using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Entidades
{
    internal class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string x, double y, double gastosSaude) : base(x, y)
        {
            GastosSaude = gastosSaude;
        }

        public override double ImpostoCalc()
        {
            double imposto = 0;
            double discontoSaude = 0;

            if (RendaAnual < 20000.00)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }
            if (GastosSaude != 0)
            {
                discontoSaude += (GastosSaude * 0.5);
            }

            return imposto - discontoSaude;
        }
        public override string ToString()
        {
            return $"{Name}: $ {ImpostoCalc()}";
        }
    }
}