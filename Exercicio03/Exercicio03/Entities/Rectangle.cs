using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio03.Entities.Enums;

namespace Exercicio03.Entities
{
    internal class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Color x, double width, double height):base(x)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"{Color} Rectangle Area: "+Area();
        }
    }
}
