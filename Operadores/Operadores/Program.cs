using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos números é: {num1 + num2}");
            Console.WriteLine($"A subtração dos números é: {num1 - num2}");
            Console.WriteLine($"A multiplicação dos números é: {num1 * num2}");
            Console.WriteLine($"A divisão dos números é: {num1 / num2}");
            Console.ReadLine();
        }
    }
}
