using Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que leia valor N de produtos inserido pelo Usuario
            //Todo produto tem uma etiqueta, cada tipo de produto possui uma etiqueta diferente 
            //Produtos importados tem uma taxa
            //Produtos usados tem data de fabricação
            //Usar uma lista com UpCasting do tipo Produto para guardar os objS

            Console.Write("Enter the number of Products: ");
            int num = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"\nEnter {i}° Product Data: ");

                Console.Write("Common, used or imported: (c, u, i) : ");
                char state = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(state == 'u')
                {
                    Console.Write("ManuFracture Date DD/MM/YYYY : ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                }
                else if(state == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double fee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS: ");

            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag()); ;
            }
        }
    }
}
