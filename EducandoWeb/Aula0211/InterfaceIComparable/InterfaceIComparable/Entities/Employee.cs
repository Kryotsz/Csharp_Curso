using System.Globalization;

namespace InterfaceIComparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        // construtor recebe a linha do arquivo csv
        public Employee(string csvEmployee)
        {
            // separa a linha onde tem vírgula e coloca em um array
            string[] vetor = csvEmployee.Split(',');
            // separa o array em nome e salário
            Name = vetor[0];
            Salary = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee.");
            }

            // Downcasting
            Employee other = obj as Employee;
            // compara o nome do atual funcionário com o recebido por parâmetro através do list.Sort()
            return Name.CompareTo(other.Name);
        }
    }
}
