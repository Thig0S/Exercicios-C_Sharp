
namespace ExercicioComposicao.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {

        }
        public Department(string department)
        {
            Name = department;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
