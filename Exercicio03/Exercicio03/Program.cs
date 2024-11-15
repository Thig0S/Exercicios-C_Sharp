using Exercicio03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio03.Entities.Enums;


namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Shapes: ");
            int num = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= +num; i++)
            {
                Console.WriteLine($"\nShape {i}# data");
                Console.WriteLine("\n1 - Retangle\n2 - Circle");
                Console.Write("\nShape Form: ");
                string choice = Console.ReadLine();

                Console.Write("Color: -Black-White-Red\n-Green-Blue-Yeloow");
                string color = Console.ReadLine();

                Color colorEnum = (Color)Enum.Parse(typeof(Color), char.ToUpper(color[0]) + color.Substring(1));

                if (choice == "1")
                {
                    Console.Write("Rectangle Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Rectangle Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(colorEnum, width, height));
                }
                else if (choice == "2")
                {
                    //Circle
                    Console.Write("Cicle Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(colorEnum, radius));
                }
                else
                {
                    Console.WriteLine("Shape was not Defined");
                }
            }
            Console.Clear();
            Console.WriteLine("Shape Areas: ");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
