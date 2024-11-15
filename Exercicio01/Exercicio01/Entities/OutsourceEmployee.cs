using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdicionalCharge { get; private set; }

        public OutsourceEmployee(string x, int y, double z) : base(x, y, z)
        {
        }

        public OutsourceEmployee(string x, int y, double z, double adicionalCharge) : base(x, y, z)
        {
            AdicionalCharge = adicionalCharge;
        }

        public override double Payment()
        {
            double Calc = +(1.1 * AdicionalCharge);
            return base.Payment() + Calc;
        }
    }
}
