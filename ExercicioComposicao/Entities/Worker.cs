using ExercicioComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComposicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLvl Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        //Usa-se lista quando a relação é um para um ou para muitos
        public List<HourContract> Contrats { get; set; } = new List<HourContract>();
        public Worker() { }

        public Worker(string name, WorkerLvl level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contrats.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contrats.Remove(contract);
        }
        public double Income(int year, int month)
        {
            //A soma ja comeca com o salario base obv
            
            double sum = BaseSalary;

            foreach (HourContract contract in Contrats) {
                 
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
                return sum;
        }
        public override string ToString()
        {
            return "\nName: " + Name + " \nDepartament: " + Department;
        }
    }
}
