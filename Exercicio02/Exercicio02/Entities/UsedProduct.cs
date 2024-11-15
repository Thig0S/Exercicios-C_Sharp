using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Entities
{
    internal class UsedProduct:Product
    {
        public DateTime ManuFactureDate {  get; set; }

        public UsedProduct(string x, double y): base(x, y)
        {
        }

        public UsedProduct(string x, double y, DateTime manuFactureDate):base(x,y)
        {
            ManuFactureDate = manuFactureDate;
        }
        public override string PriceTag()
        {
            return $"{Name} (USED) $ {Price} (ManuFacture date: {ManuFactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
