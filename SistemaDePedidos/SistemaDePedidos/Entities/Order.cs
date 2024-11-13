using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDePedidos.Entities.Enums;

namespace SistemaDePedidos.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order()
        {
            Moment = DateTime.Now;
        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order Momment: ");
            sb.AppendLine(Moment.ToString());

            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order itens: ");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(" ");
                sb.AppendLine(item.ToString());
                sb.AppendLine(" ");
            }
            sb.Append("Total Price: ");
            sb.Append(Total().ToString());

            return sb.ToString();
        }
    }
}
