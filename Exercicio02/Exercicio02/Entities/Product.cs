using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; protected set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            string tag = $"{Name} $ {Price} ";

            return tag;
        }
    }
}
