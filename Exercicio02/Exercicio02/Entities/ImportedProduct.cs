using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; private set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string z, double y, double customFee) : base(z,y)
        {
            CustomFee = customFee;
        }

        private double TotalPrice()
        {
            return Price += CustomFee;
        }
        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Customs Fee: {CustomFee})";
        }
    }
}
