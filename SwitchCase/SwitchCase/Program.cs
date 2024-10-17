using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static double Soma(double num1, double num2)
        {
            return num1 + num2;
        }
        static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a calculadora do Thig0S!\n");
            while (true) { 
                Console.Write("Digite o primeiro número: ");
                double num1 = Double.Parse(Console.ReadLine());

                Console.Write("\nDigite o segundo número: ");
                double num2 = Double.Parse(Console.ReadLine());

                Console.Write("\nSoma: 1");
                Console.Write("\nSubtração: 2");
                Console.Write("\nMultiplicação: 3");
                Console.Write("\nDivisão: 4");
                Console.Write("\nDigite o método desejado: ");
                int opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                double resultado;
                switch (opcao) {
                    case 1:
                        resultado = Soma(num1, num2);
                        Console.WriteLine("");
                        Console.WriteLine($"O resultado da SOMA é: {resultado}");                     
                        Console.WriteLine("");
                        break;
                    case 2:
                        resultado = Sub(num1, num2);
                        Console.WriteLine("");
                        Console.WriteLine($"O resultado da SUBTRAÇÃO é: {resultado}");
                        Console.WriteLine("");
                        break;
                    case 3:
                        resultado = Mult(num1, num2);
                        Console.WriteLine("");
                        Console.WriteLine($"O resultado da MULTIPLICAÇÃO é: {resultado}");
                        Console.WriteLine("");
                        break;
                    case 4:
                        resultado = Div(num1, num2);
                        Console.WriteLine("");
                        Console.WriteLine($"O resultado da DIVISÃO é: {resultado}");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Digite um número Válido!");
                        break;
                }
                Console.WriteLine("Deseja continuar? (s/n)");
                string continuar = Console.ReadLine();
                if (continuar.ToLower() != "s") break;
                Console.Clear();
            }
        }
    }
    
}
