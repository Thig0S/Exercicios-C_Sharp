using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Entities;
using Exercicio01.Entities.Exceptions;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Account Data: ");
                Console.Write("Number: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double initial = double.Parse(Console.ReadLine());

                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine());

                Account ac = new Account(num, holder, initial, limit);

                Console.WriteLine("");
                Console.Write("Enter the amount of withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                ac.WithDraw(withdraw);
                Console.WriteLine("New balance : $" + ac.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
