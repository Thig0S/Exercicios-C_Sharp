using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDePedidos.Entities.Enums;
using System.Globalization;

namespace SistemaDePedidos.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }
        public double SubTotal()
        {
            return Quantity * Product.Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Product.Name);
            sb.Append(", $");
            sb.Append(Product.Price);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", SubTotal: ");
            sb.Append(SubTotal().ToString("F2"));


            return sb.ToString();
        }
    }
}
