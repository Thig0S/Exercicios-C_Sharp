using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    public class Funcionario
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            this.Id = id;
            this.Name = nome;
            this.Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem /= 100;
            this.Salario += (this.Salario * porcentagem);
        }
        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Name}, {Salario}";
        }
    }
}
