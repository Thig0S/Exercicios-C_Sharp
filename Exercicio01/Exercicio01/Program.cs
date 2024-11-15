using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Entities;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of Employees: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data: ");
                Console.Write("OutSource (y/n): ");
                char outSource = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outSource == 'y')
                {
                    Console.Write("Aditional Charge: ");
                    double charge = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourceEmployee(name, hours, valuePerHour, charge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
