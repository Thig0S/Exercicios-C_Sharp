using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinharNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            int numSecreto = random.Next(1,10);
            int numero = 0;
            while (numSecreto != numero)
            {
                while (true)
                {
                    Console.Write("Adivinhe o número secreto uau: ");
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        break;
                    }
                    Console.WriteLine("\nDigite um número válido!\n");
                }

                if (numero < numSecreto)
                {
                    Console.WriteLine("\nO número digitado é menor, tente novamente: ");
                }
                else if (numero > numSecreto)
                {
                    Console.WriteLine("\nO número digitado é maior, tente novamente: ");
                }
                else
                {
                    Console.WriteLine($"\nParabêns!!\nVocê acertou o número secreto: {numSecreto}");
                    break;
                }
            }
        }
    }
}
