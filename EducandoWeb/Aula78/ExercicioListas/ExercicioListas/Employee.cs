using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ExercicioListas
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string nome, double salary)
        {
            Id = id;
            Name = nome;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                +", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
