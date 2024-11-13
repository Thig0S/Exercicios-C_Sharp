using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDePedidos.Entities;
using SistemaDePedidos.Entities.Enums;

namespace SistemaDePedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date DD/MM/YYYY: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);

            Console.WriteLine("Enter Order Data: ");

            Console.Write("Status: (Pending_Payment, Processing, Shipped, Delivered) : ");
            string status = Console.ReadLine();
            OrderStatus statusConvert = (OrderStatus)Enum.Parse(typeof(OrderStatus), char.ToUpper(status[0]) + status.Substring(1));

            Console.Write("How many itens for this Order: ");
            int times = int.Parse(Console.ReadLine());

            Order order = new Order(statusConvert,client);

            for (int i = 1; i <= times; i++)
            {

                Console.WriteLine($"\n{i}° Order: ");
                Console.Write($"\nProduct Name: ");
                string pdName = Console.ReadLine() ;

                Console.Write($"Product Price: ");
                double pdPrice = double.Parse(Console.ReadLine());

                Product product = new Product(pdName,pdPrice);

                Console.Write($"Product Quantity: ");
                int pdQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(pdQuantity,product);

                order.AddItem(orderItem);
            }
            Console.WriteLine("");
            Console.WriteLine(order);
        }
    }
}
