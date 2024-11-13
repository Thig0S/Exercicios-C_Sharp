using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;

namespace ExercicioComposicao
{
    internal class Program
    {

        //Ler os Dados de um trabalhador com N contratos (N fornecido pelo usuario). 
        //Depois solicitar o mes e o ano para o usuario e mostrar qual foi o salario do funcionario deste mes

        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter Worker Data");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string lvlString = Console.ReadLine();
            //Faz a conversão da primeira letra para upperCase
            WorkerLvl lvl = (WorkerLvl)Enum.Parse(typeof(WorkerLvl), char.ToUpper(lvlString[0]) + lvlString.Substring(1));

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(depName);
            Worker worker = new Worker(name, lvl, baseSalary, dept);

            Console.Clear();

            Console.Write("How many contracts to this worker: ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contracts; i++)
            {
                Console.WriteLine($"\nEnter #{i} contract data: ");

                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valueHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (Hours):");
                int timeHours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, valueHour, timeHours);

                worker.AddContract(hourContract);
            }

            Console.Write("Enter with Month and Year to calculate the income: ");
            string[] monthAndYear = Console.ReadLine().Split('/');
            int month = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[1]);

            Console.WriteLine(worker);
            Console.WriteLine($"Income for {month}/{year}: {worker.Income(year,month)}");


        }
    }
}
