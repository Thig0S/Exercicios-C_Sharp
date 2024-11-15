using Exercicio03.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Entities
{
    internal class Circle:Shape
    {
        public double Radius {  get; set; }

        public Circle()
        {
        }

        public Circle(Color x, double radius) :base(x)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * (Math.Pow(Radius,2));
        }

        public override string ToString()
        {
            return $"{Color} Circle Area: "+Area();
        }
    }
}
